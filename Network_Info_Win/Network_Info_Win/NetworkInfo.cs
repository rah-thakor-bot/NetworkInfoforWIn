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
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                Ensure.ArgumentNotNullOrEmptyString(txtIP.Text, "IP Address");
                Machine = new MachineBase();
                //getDomainList();
                Machine.IP = txtIP.Text;
                ErrorCode result = Machine.ConnectRemoteMachine();
                if (result == ErrorCode.Ok)
                {
                    GetRemoteSystemInfo(Machine.scope);
                    updateBehaviour("SHOW");
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
                //Call GetRemoteSystemInfo with response with 
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

        /// <summary>
        /// Remote system information 
        /// </summary>
        /// <param name="wmScope"></param>
        private void GetRemoteSystemInfo(ManagementScope wmScope)
        {
            try
            {
                BasicInfo = Machine.getDataSource(wmScope, "Win32_OperatingSystem");
                HardwareInfo = Machine.getDataSource(wmScope, "Win32_Processor");
                ProgramInstalled = Machine.getDataSource(wmScope, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
        
        /// <summary>
        /// Manage UI behaviour for button actions
        /// </summary>
        /// <param name="currAction"></param>
        private void updateBehaviour(string currAction)
        {
            switch (currAction.ToUpper())
            {
                case "SHOW":
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
                default:
                    throw new Exception(string.Format("Failed to update behaviour for {0}", currAction.ToUpperInvariant()));
            }
        }
    }
}
