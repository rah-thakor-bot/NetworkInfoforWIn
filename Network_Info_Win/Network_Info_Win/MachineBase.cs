using System;
using System.Configuration;
using System.Diagnostics;

namespace Network_Info_Win
{
    //[DebuggerStepThrough]
    internal class MachineBase
    {
        string _username, _password, _ip, _domainname;

        public readonly string[] DomainList = new string[] { "AUROSURAT", "AUROMFG" };

        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
        public string IP
        {
            get
            {
                return this._ip;
            }
            set
            {
                this._ip = value;
            }
        }
        public string DomainName
        {
            get
            {
                return this._domainname;
            }
            set
            {
                this._domainname = value;
                if (_domainname.ToUpper() == "AUROMFG")
                {
                    _username = MfgUsername();
                    _password = MfgPwd();
                }
                else if (_domainname.ToUpper() == "AUROSURAT")
                {
                    _username = SuratUserName();
                    _password = SuratPwd();
                }
            }
        }

        public MachineBase()
        {
            Username = MfgUsername();
            Password = MfgPwd();
            DomainList = null;
        }

        public void ChangeDomain(string domainName)
        {
            if (domainName.ToUpper() == "AUROMFG")
            {
                _username = MfgUsername();
                _password = MfgPwd();
            }
            else if (domainName.ToUpper() == "AUROSURAT")
            {
                _username = SuratUserName();
                _password = SuratPwd();
            }
        }

        private string MfgUsername()
        {
            return ConfigurationManager.AppSettings["AuroMfgUsername"].ToString();
        }

        private string MfgPwd()
        {
            return ConfigurationManager.AppSettings["AuroMfgPwd"].ToString();
        }

        private string SuratUserName()
        {
            return ConfigurationManager.AppSettings["AuroSuratUsername"].ToString();
        }

        private string SuratPwd()
        {
            return ConfigurationManager.AppSettings["AuroSuratPwd"].ToString();
        }

    }
}
