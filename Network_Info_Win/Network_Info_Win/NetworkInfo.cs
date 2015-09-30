using System;
using System.Windows.Forms;
using System.Management;
using libExtension;
using System.Data;
using System.DirectoryServices.ActiveDirectory;


namespace Network_Info_Win
{
    public partial class NetworkInfo : Form
    {
        MachineBase Machine;
        DataTable BasicInfo, HardwareInfo, ProgramInstalled;
        ConnectionOptions conOptn;
        ManagementScope scope;
        bool domainChanged = false;
        bool steppedOutFromRecursion = false;

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
                ConnectRemoteMachine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void getDomainList()
        {
            using (var forest = Forest.GetCurrentForest())
            {
                int cnt = 0;
                foreach (Domain domain in forest.Domains)
                {
                    //Machine.DomainList[cnt] = domain.Name;
                    cnt++;
                    //domain.Dispose();
                }
            }
        }
        private void ConnectRemoteMachine()
        {
            try
            {
                ErrorCode result = ErrorCode.Error;
                int numOfDomain = Machine.DomainList.Length;
                int cnt = 0;
                foreach (string domain in Machine.DomainList)
                {
                    cnt++;
                    Machine.DomainName = domain;
                    result = Connect(GetConnectionOptions(Machine.DomainName), Machine.IP);
                    if(result == ErrorCode.Ok)
                    {
                        break;
                    }
                    if (result != ErrorCode.RecursionNeeded)
                        break;
                    if (result == ErrorCode.RecursionNeeded)
                    {
                        if (cnt <= numOfDomain)
                        {
                            DialogResult diaRes = MessageBox.Show("Would you like to check system with another credential ? ", "Confirmation", MessageBoxButtons.YesNo);
                            if (diaRes == DialogResult.Yes)
                            {

                                continue;
                            }
                            else if (diaRes == DialogResult.No)
                            {
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Can't connect to host with existing domain list. \nNo more interation left with domain list.\n");
                        }
                    }
                }
                if (result == ErrorCode.Ok)
                {
                    GetRemoteSystemInfo(scope);
                    updateBehaviour("SHOW");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private ConnectionOptions GetConnectionOptions(string domain)
        {
            conOptn = new ConnectionOptions();
            conOptn.Username = Machine.Username;
            conOptn.Password = Machine.Password;
            return conOptn;
        }
        private ErrorCode Connect(ConnectionOptions credential, string ip)
        {

            return ErrorCode.Ok;
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

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            updateBehaviour("RESET");
        }

        private DataTable getDataSource(ManagementScope scope,string winClassName)
        {
            DataTable temp = new DataTable();
            temp.Columns.Add("PROPERTY_NAME");
            temp.Columns.Add("PROPERTY_VALUE");
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
                            dr["PROPERTY_VALUE"] = mngmntObj.Properties[property.Name].Value.ToString();
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
