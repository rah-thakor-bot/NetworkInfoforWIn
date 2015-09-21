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
using NetworkInfo.Core;

namespace NetworkInfo.Core
{
    public static class Ensure
    {
        public static int IsIPorDomain(string validationStr)
        {
            int i = 0;//0 for IP

            if (validationStr.Split('.').Length - 1 == 1)
                i = 1;//Domain
            else if (validationStr.Split('.').Length == 4)
                i = 0;//IP
            else
                i = -1;//Error
            return i;
        }

        public static string GetAddressFamily(string ip)
        {
            string retFlag = string.Empty;
            IPAddress address;
            if (IPAddress.TryParse(ip, out address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        retFlag = "IPv4";
                        break;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        retFlag = "IPv6";
                        break;
                    default:
                        throw new Exception(string.Format("Failed to get addressfamily for Ip : {0}", ip));
                }
                return retFlag;
            }
            return null;
        }
    }
}
