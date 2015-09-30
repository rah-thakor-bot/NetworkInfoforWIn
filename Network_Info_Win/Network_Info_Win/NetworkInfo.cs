using System;
using System.Windows;
using System.Windows.Forms;
using System.Management;
using libExtension;
using System.Data;


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
                Ensure.ArgumentNotNullOrEmptyString(txtUsername.Text, "UserName");
                Ensure.ArgumentNotNullOrEmptyString(txtPwd.Text, "Password");
                Ensure.ArgumentNotNullOrEmptyString(txtDomain.Text, "Domain");
                Ensure.ArgumentNotNullOrEmptyString(txtIP.Text, "IP Address");
                Machine = new MachineBase();
                Machine.Username = txtUsername.Text;
                Machine.Password = txtPwd.Text;
                Machine.IP = txtIP.Text;
                ConnectRemoteMachine();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void ConnectRemoteMachine()
        {
            try
            {
                ConnectionOptions conOptn = new ConnectionOptions(string.Empty, Machine.Username, Machine.Password, string.Empty, ImpersonationLevel.Impersonate, AuthenticationLevel.Default, true, null,new TimeSpan(0));
                ManagementScope scope = new ManagementScope(string.Format("\\\\{0}\\root\\cimv2", Machine.IP), conOptn);
                scope.Connect();
                GetRemoteSystemInfo(scope);
                updateBehaviour("SHOW");
            }
            catch (Exception ex)
            {
            }
        }

        private void GetRemoteSystemInfo(ManagementScope wmScope)
        {
            try
            {
                BasicInfo = getDataSource(wmScope, "Win32_OperatingSystem");
                HardwareInfo = getDataSource(wmScope, "Win32_Processor");
                ProgramInstalled = getDataSource(wmScope, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private DataTable getDataSource(ManagementScope scope,string winClassName)
        {
            DataTable temp = new DataTable();
            temp.Columns.Add("PROPERTY_NAME");
            temp.Columns.Add("PROPERTY_VAULE");
            try
            {
                Ensure.ArgumentNotNull(scope, "ManagementScope");
                Ensure.ArgumentNotNullOrEmptyString(winClassName, "Win32Class");
            }
            catch (Exception ex)
            {
                return temp;
            }
            
            ManagementPath wmPath = new ManagementPath(winClassName);
            ManagementClass mngmntClass = new ManagementClass(scope, wmPath, new ObjectGetOptions());

            PropertyDataCollection propColletion = mngmntClass.Properties;

            bool stopExecution = false;
            foreach (ManagementObject mngmntObj in mngmntClass.GetInstances())
            {
                foreach (PropertyData property in propColletion)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(mngmntObj.Properties[property.Name].Value.ToString()))
                        {
                            DataRow dr = temp.NewRow();
                            dr["PROPERTY_NAME"] = property.Name;
                            dr["PROPERTY_VAULE"] = mngmntObj.Properties[property.Name].Value.ToString();
                            temp.Rows.Add(dr);
                        }
                    }
                    catch
                    {
                        stopExecution = true;
                    }
                }
                if (stopExecution)
                {
                    break;
                }
            }
            return temp;

        }
        private void updateBehaviour(string currAction)
        {
            switch (currAction.ToUpper())
            {
                case "SHOW":
                    grdBasicInfo.DataSource = BasicInfo;
                    grdHardware.DataSource = HardwareInfo;
                    grdPrograms.DataSource = ProgramInstalled;

                    grdBasicInfo.Columns["PROPERTY_NAME"].HeaderText = "Property Name";
                    grdBasicInfo.Columns["PROPERTY_NAME"].Width = 150;
                    grdBasicInfo.Columns["PROPERTY_VALUE"].HeaderText = "Property Value";
                    grdBasicInfo.Columns["PROPERTY_VALUE"].Width = 150;

                    grdHardware.Columns["PROPERTY_NAME"].HeaderText = "Property Name";
                    grdHardware.Columns["PROPERTY_NAME"].Width = 150;
                    grdHardware.Columns["PROPERTY_VALUE"].HeaderText = "Property Value";
                    grdHardware.Columns["PROPERTY_VALUE"].Width = 150;
                    break;
                case "RESET":

                    break;
                default:
                    throw new Exception(string.Format("Failed to update behaviour for {0}", currAction.ToUpperInvariant()));
            }
        }
    }
}
