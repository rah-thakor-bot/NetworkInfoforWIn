using System;
using System.Windows.Forms;
using libExtension;
using System.Data;
using System.Management;

namespace Network_Info_Win
{
    public partial class NetworkInfo : Form
    {
        MachineBase Machine;
        DataTable BasicInfo, HardwareInfo, ProgramInstalled;
        
        public NetworkInfo()
        {
            InitializeComponent();
            Machine = new MachineBase();
            updateBehaviour("LOAD");
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                Ensure.ArgumentNotNullOrEmptyString(txtIP.Text, "IP Address");
                Machine.IP = txtIP.Text;
                ErrorCode result = Machine.ConnectRemoteMachine();
                if (result == ErrorCode.Ok)
                {
                    updateBehaviour("SHOW");
                }
                else if (result == ErrorCode.Auth)
                {
                    MessageBox.Show(string.Format("Can't connect with current credential"));
                }
                else if (result == ErrorCode.RPCUnavailable)
                {
                    MessageBox.Show(string.Format("Failed to connect remote host.\n\nSuggestions :\n-Make sure firewall is off\n-Allow app or feature through windows firewall.\n-Enable Domain Privilege for Windows Management Instrumentation(WMI)"));
                }
                else if (result == ErrorCode.NonWindows)
                {
                    MessageBox.Show(string.Format("{0} is not based on windows os.", Machine.IP));
                }
                else
                {
                    MessageBox.Show(string.Format("Failed to get remote system information for {0}", Machine.IP));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            updateBehaviour("RESET");
        }

        private void txtIP_Enter(object sender, EventArgs e)
        {
        }

        private void txtIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessTabKey(true);
            }
        }

        /// <summary>
        /// Remote system information 
        /// </summary>
        /// <param name="wmScope"></param>
        private void GetRemoteSystemInfo(ManagementScope wmScope)
        {
            try
            {
                BasicInfo = Machine.getDataSource(wmScope, wmScope == null ? string.Empty : "Win32_OperatingSystem");
                HardwareInfo = Machine.getDataSource(wmScope, wmScope == null ? string.Empty : "Win32_Processor");
                ProgramInstalled = Machine.getDataSource(wmScope, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCredential_Click(object sender, EventArgs e)
        {
            Ensure.ArgumentNotNullOrEmptyString(txtUsername.Text, "Username");
            Ensure.ArgumentNotNullOrEmptyString(txtPassword.Text, "Password");
            try
            {
                Ensure.ArgumentNotNull(Machine, "Machine");
            }
            catch (Exception)
            {
                Machine = new MachineBase();
            }
            Machine.Username = txtUsername.Text;
            Machine.Password = txtPassword.Text;
            updateBehaviour("SAVECREDENTIAL");
        }

        private void btnChangeCredential_Click(object sender, EventArgs e)
        {
            Machine.SetDefaultCredential();
            updateBehaviour("SHOWCREDENTIAL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateBehaviour("CLOSEPANEL");
        }

        /// <summary>
        /// Manage UI behaviour for button actions
        /// </summary>
        /// <param name="currAction"></param>
        private void updateBehaviour(string currAction)
        {
            switch (currAction.ToUpper())
            {
                case "LOAD":
                    GetRemoteSystemInfo(null);
                    panelCredential.Visible = false;
                    SetGridProperty();
                    break;
                case "SHOW":
                    GetRemoteSystemInfo(Machine.scope);
                    SetGridProperty();
                    break;
                case "SHOWCREDENTIAL":
                    panelCredential.Visible = true;
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    break;
                case "RESET":
                    txtIP.Text = string.Empty;
                    if (BasicInfo.Rows.Count > 0)
                        BasicInfo.Rows.Clear();
                    if (HardwareInfo.Rows.Count > 0)
                        HardwareInfo.Rows.Clear();
                    if (ProgramInstalled.Rows.Count > 0)
                        ProgramInstalled.Rows.Clear();
                    break;
                case "CLOSEPANEL":
                    panelCredential.Visible = false;
                    break;
                case "SAVECREDENTIAL":
                    panelCredential.Visible = false;
                    txtIP.Focus();
                    break;
                default:
                    throw new Exception(string.Format("Failed to update behaviour for {0}", currAction.ToUpperInvariant()));
            }
        }


        private void SetGridProperty()
        {
            grdBasicInfo.DataSource = BasicInfo;
            grdHardware.DataSource = HardwareInfo;
            grdPrograms.DataSource = ProgramInstalled;

            grdBasicInfo.Columns["PROPERTY_NAME"].HeaderText = "Property Name";
            grdBasicInfo.Columns["PROPERTY_NAME"].Width = 450;
            grdBasicInfo.Columns["PROPERTY_VALUE"].HeaderText = "Property Value";
            grdBasicInfo.Columns["PROPERTY_VALUE"].Width = 250;

            grdHardware.Columns["PROPERTY_NAME"].HeaderText = "Property Name";
            grdHardware.Columns["PROPERTY_NAME"].Width = 450;
            grdHardware.Columns["PROPERTY_VALUE"].HeaderText = "Property Value";
            grdHardware.Columns["PROPERTY_VALUE"].Width = 250;

            grdPrograms.Columns["PROPERTY_NAME"].HeaderText = "Property Name";
            grdPrograms.Columns["PROPERTY_NAME"].Width = 450;
            grdPrograms.Columns["PROPERTY_VALUE"].HeaderText = "Property Value";
            grdPrograms.Columns["PROPERTY_VALUE"].Width = 250;
        }
    }
}
