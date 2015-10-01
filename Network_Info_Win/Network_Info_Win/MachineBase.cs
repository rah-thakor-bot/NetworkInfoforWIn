using System;
using System.Configuration;
using System.Diagnostics;
using System.Management;
using System.DirectoryServices.ActiveDirectory;
using System.Data;
using libExtension;
using Microsoft.Win32;

namespace Network_Info_Win
{
    //[DebuggerStepThrough]
    internal class MachineBase
    {
        string _username, _password, _ip, _domainname;
        ConnectionOptions conOptn;
        public ManagementScope scope;
        public readonly string[] DomainList = new string[] { "AUROSURAT" };

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string IP
        {
            get
            {
                return _ip;
            }
            set
            {
                _ip = value;
            }
        }
        public string DomainName
        {
            get
            {
                return _domainname;
            }
            set
            {
                _domainname = value;
            }
        }

        public MachineBase()
        {
            Username = SuratUserName();
            Password = SuratPwd();
        }

        private string SuratUserName()
        {
            return ConfigurationManager.AppSettings["AuroSuratUsername"].ToString();
        }

        private string SuratPwd()
        {
            return ConfigurationManager.AppSettings["AuroSuratPwd"].ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        public ErrorCode ConnectRemoteMachine()
        {
            if (GetOsVersion(IP) == OSVersion.Windows)
            {
                return Connect(GetConnectionOptions(DomainName));
            }
            return ErrorCode.NonWindows;
        }

        /// <summary>
        /// Check for OS version
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        private OSVersion GetOsVersion(string ipAddress)
        {
            try
            {
                using (var reg = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, ipAddress))
                using (var key = reg.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\"))
                {
                    return OSVersion.Windows;
                }
            }
            catch (Exception)
            {
                return OSVersion.NonWindows;
            }
            
        }

        /// <summary>
        /// Get credential of administrator role user
        /// </summary>
        /// <param name="domain">Domain name</param>
        /// <returns></returns>
        private ConnectionOptions GetConnectionOptions(string domain)
        {
            conOptn = new ConnectionOptions();
            conOptn.Username = Username;
            conOptn.Password = Password;
            return conOptn;
        }

        /// <summary>
        /// Current domain name on which current user is logged on
        /// </summary>
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

        /// <summary>
        /// Connect with remote host with ip and credential details
        /// </summary>
        /// <param name="credential"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        private ErrorCode Connect(ConnectionOptions credential)
        {
            scope = new ManagementScope(string.Format("\\\\{0}\\root\\cimv2", IP), credential);
            try
            {
                scope.Connect();
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                return ErrorCode.RPCUnavailable;
            }
            catch (Exception)
            {
                return ErrorCode.Error;
            }
            return ErrorCode.Ok;
        }

        /// <summary>
        /// Get win32_* classes details for given scope and class name
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="winClassName"></param>
        /// <returns></returns>
        public DataTable getDataSource(ManagementScope scope, string winClassName)
        {
            DataTable temp = new DataTable();
            temp.Columns.Add("PROPERTY_NAME");
            temp.Columns.Add("PROPERTY_VALUE");
            try
            {
                Ensure.ArgumentNotNull(scope, "ManagementScope");
                Ensure.ArgumentNotNullOrEmptyString(winClassName, "Win32Class");
            }
            catch (Exception)
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
    }
}
