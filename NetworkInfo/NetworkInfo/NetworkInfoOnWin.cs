using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using System.Linq;
using System.Management;

using NetworkInfo.Core;

namespace NetworkInfo
{
    #region Directory Class
    public partial class NetworkInfoOnWin : Form
    {
        #region Types
        public enum TNames
        {
            NetworkTable,
            SystemInfo,
            Processor,
            ProgramList
        };
        #endregion
        #region Struct
        public struct MachinePara {
            public string PrimaryIP;
            public string HostName;
            public string ExtraIP;
            public bool HasError;
        };
        public MachinePara CurrMachine;
        #endregion 

        #region Variable Declaration
        DataSet ds;
        string ActiveDomain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
        string txtInput = string.Empty;
        #endregion 
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

        public NetworkInfoOnWin()
        {
            InitializeComponent();
            ds = new DataSet();
            ds.Tables.Add("NetworkTable");
            ds.Tables.Add("SystemInfo");
            ds.Tables.Add("Processor");
            ds.Tables.Add("ProgramList");
            ds.Tables[(int)TNames.NetworkTable].Columns.Add("IP", typeof(string));
            ds.Tables[(int)TNames.NetworkTable].Columns.Add("HostName", typeof(string));
            ds.Tables[(int)TNames.NetworkTable].Columns.Add("ExtraIP", typeof(string));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(txtIPAdr.Text.Trim())))
                {
                    ds.Tables[(int)TNames.NetworkTable].Rows.Clear();
                    txtInput = txtIPAdr.Text.Trim();
                    int flg = Ensure.IsIPorDomain(txtInput);
                    if (flg == 0)//Ip
                    {
                        Ensure.GetAddressFamily(txtInput);
                        CurrMachine.PrimaryIP = txtInput;
                        RetrieveSystemInfo();
                    }
                    else if (flg == 1)//Domain
                    {
                        GetSystemInfo(txtInput);
                    }
                    else if (flg == -1)//Error
                    {

                    }
                    if (!CurrMachine.HasError)
                    {
                        grdNetworkInfo.DataSource = ds.Tables[(int)TNames.NetworkTable];
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UsingDirectoryEntry_Load(object sender, EventArgs e)
        {
            txtIPAdr.Text = ActiveDomain;
        }

        public void GetSystemInfo(string DomainName)
        {
            DirectoryEntry DomainEntry = new DirectoryEntry("WinNT://" + DomainName);
            DomainEntry.Children.SchemaFilter.Add("computer");
            foreach (DirectoryEntry _machine in DomainEntry.Children)
            {
                string hostName = _machine.Name;
                try
                {
                    string ipAdr = string.Empty;
                    foreach (IPAddress _IpAdr in Dns.GetHostAddresses(hostName))
                    {
                        ipAdr += _IpAdr.ToString() + ((!string.IsNullOrWhiteSpace(ipAdr)) ? "," : string.Empty);
                    }
                    if (ipAdr.Split(',').Length - 1 > 1)
                    {
                        CurrMachine.ExtraIP = ipAdr;
                        CurrMachine.PrimaryIP = ipAdr.Split(',')[0];
                    }
                    else
                    {
                        CurrMachine.PrimaryIP = ipAdr;
                        CurrMachine.ExtraIP = string.Empty;
                    }
                    CurrMachine.HostName = _machine.Name;
                    RetrieveSystemInfo();
                }
                catch (Exception ex)
                {
                    //Dns.GetHostAddresses(hostName) Exception Handler for Connection
                }
            }
        }

        public void RetrieveSystemInfo()
        {
            // Configure the connection settings.
            ConnectionOptions LogonCredential = new ConnectionOptions();
            LogonCredential.Username = "domainadmin"; //could be in domain\user format
            LogonCredential.Password = "mfgauro";
            ManagementPath networkPath = new ManagementPath(String.Format("\\\\{0}\\root\\cimv2", CurrMachine.PrimaryIP));
            ManagementScope networkScope = new ManagementScope(networkPath, LogonCredential);

            // Try and connect to the remote (or local) machine.
            try
            {
                networkScope.Connect();
            }
            catch (ManagementException ex)
            {
                CurrMachine.HasError = true;
            }
            catch (COMException ex)
            {
                CurrMachine.HasError = true;
            }
            catch (UnauthorizedAccessException ex)
            {
                CurrMachine.HasError = true;
            }
            if (!CurrMachine.HasError)
            {
                //Connection established succesfully
                GetData(networkScope);
            }
            
        }

        public void GetData(ManagementScope currScope)
        {
            #region Network able
            if (CurrMachine.HostName == null)
            {
                foreach (ManagementObject mo in new ManagementClass(currScope, new ManagementPath("Win32_OperatingSystem"), null).GetInstances())
                {
                    CurrMachine.HostName = mo["CSName"].ToString();
                }
            }
            ds.Tables[(int)TNames.NetworkTable].Rows.Add(CurrMachine.PrimaryIP, CurrMachine.HostName, CurrMachine.ExtraIP);
            #endregion
            #region Basic system info
            #endregion
            #region Hardware Info
            #endregion
            #region Installed Programs list
            #endregion
        }
    }
    #endregion

}


