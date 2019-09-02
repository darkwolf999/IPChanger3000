using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using Microsoft.Win32;
using System.Diagnostics;
using System.Security.Permissions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace IPChanger
{
    class NetworkSettings
    {




        public static ManagementClass objMCNetAdapConf;
        public static ManagementObjectCollection objMOCNetAdapConf;

        public List<string> adaptersNamesList;
        //public List<string> adaptersMACsList;

        public String selectedAdapterDescription;

        public string[] IPAddress;// = { "192.168.1.150" };
        public string[] IPSubnet;// = { "255.255.255.0" };
        public string[] DefaultIPGateway;// = { "192.168.1.1" };
        //public string[] DNSServerSearchOrder;
        //public UInt16[] GatewayCostMetric;
        //public int proxyStatus;






        public NetworkSettings()
        {
            objMCNetAdapConf = new ManagementClass("Win32_NetworkAdapterConfiguration");
            objMOCNetAdapConf = objMCNetAdapConf.GetInstances();

            adaptersNamesList = new List<string>();
            //adaptersMACsList = new List<string>();

            IPAddress = new string[] { "192.168.1.150" };
            IPSubnet = new string[] { "255.255.255.0" };
            DefaultIPGateway = new string[] { "192.168.1.1" };
        }






        /// <summary>
        /// Установить конфигурацию сетевого адаптера, используя имеющиеся в классе настройки.
        /// В принципе было бы корректно освобождать IP-адрес перед установкой статического адреса. см. msdn.microsoft.com/en-us/library/aa393047(v=vs.85).aspx
        /// (ReleaseDHCPLease)
        /// </summary>
        public void setNetworkParametersStatic()
        {
            objMCNetAdapConf = new ManagementClass("Win32_NetworkAdapterConfiguration");
            objMOCNetAdapConf = objMCNetAdapConf.GetInstances();

            foreach (ManagementObject objMO in objMOCNetAdapConf)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        string _d = (string)objMO["Description"];

                        if (_d.Equals(selectedAdapterDescription))
                        {
                            ManagementBaseObject EnableStatic = objMO.GetMethodParameters("EnableStatic");
                            EnableStatic["IPAddress"] = IPAddress;
                            EnableStatic["SubnetMask"] = IPSubnet;
                            objMO.InvokeMethod("EnableStatic", EnableStatic, null);
 
                            ManagementBaseObject SetGateways = objMO.GetMethodParameters("SetGateways");
                            SetGateways["DefaultIPGateway"] = DefaultIPGateway;
                            objMO.InvokeMethod("SetGateways", SetGateways, null);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public void setNetworkParametersDHCP()
        {
            foreach (ManagementObject objMO in objMOCNetAdapConf)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        string _d = (string)objMO["Description"];

                        if ((_d.Equals(selectedAdapterDescription)))
                        {
                            ManagementBaseObject MBOEnableDHCP = objMO.GetMethodParameters("EnableDHCP");
                            objMO.InvokeMethod("EnableDHCP", MBOEnableDHCP, null);
                            rebootAdapter();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public void rebootAdapter() 
        {
            SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            ManagementObjectSearcher adaptersList = new ManagementObjectSearcher(wmiQuery);

            foreach (ManagementObject item in adaptersList.Get())
            {
                if (((string)item["Description"]).Equals(selectedAdapterDescription))
                {
                    item.InvokeMethod("Disable", null);
                    item.InvokeMethod("Enable", null);
                }
            }
        }

        public void rebootAll()
        {
            SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            ManagementObjectSearcher adaptersList = new ManagementObjectSearcher(wmiQuery);

            foreach (ManagementObject item in adaptersList.Get())
            {
                item.InvokeMethod("Disable", null);
                item.InvokeMethod("Enable", null);
            }
        }

        public void enableAdapter()
        {
            SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            ManagementObjectSearcher adaptersList = new ManagementObjectSearcher(wmiQuery);

            foreach (ManagementObject item in adaptersList.Get())
            {
                if (((string)item["Description"]).Equals(selectedAdapterDescription))
                    item.InvokeMethod("Enable", null);
            }
        }

        public void disableAdapter()
        {
            SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            ManagementObjectSearcher adaptersList = new ManagementObjectSearcher(wmiQuery);

            foreach (ManagementObject item in adaptersList.Get())
            {
                if (((string)item["Description"]).Equals(selectedAdapterDescription))
                    item.InvokeMethod("Disable", null);
            }
        }


        public void showConnections(ListBox list)
        {
            list.Items.Clear();
            foreach (ManagementObject objMO in objMOCNetAdapConf)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    list.Items.Add((string)objMO["Description"]);
                    adaptersNamesList.Add((string)objMO["Description"]);
                    //adaptersMACsList.Add((string)objMO["MACAddress"]);
                }
            }

            //SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            //ManagementObjectSearcher adaptersList = new ManagementObjectSearcher(wmiQuery);

            //foreach (ManagementObject item in adaptersList.Get())
            //{
            //    list.Items.Add((string)item["Description"]);
            //    adaptersNamesList.Add((string)item["Description"]);
            //}
        }


        public void showCurNetSettings(TextBox textBoxShowIP, 
                                       TextBox textBoxShowMask, 
                                       TextBox textBoxShowGate, 
                                       TextBox textBoxShowDNS1, 
                                       TextBox textBoxShowDNS2)
        {
            objMCNetAdapConf = new ManagementClass("Win32_NetworkAdapterConfiguration");
            objMOCNetAdapConf = objMCNetAdapConf.GetInstances();

            foreach (ManagementObject objMO in objMOCNetAdapConf)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        string _d = (string)objMO["Description"];

                        if (_d.Equals(selectedAdapterDescription)) //Беспроводная сеть 2 Ethernet 2
                        {
                            if(((String[])objMO["IPAddress"])[0] != null)
                                textBoxShowIP.Text = ((String[])objMO["IPAddress"])[0];
                            //else
                            //    textBoxShowIP.Text = " ";
                            if (((String[])objMO["IPSubnet"])[0] != null)
                                textBoxShowMask.Text = ((String[])objMO["IPSubnet"])[0];
                            //else
                            //    textBoxShowIP.Text = " ";
                            if (((String[])objMO["DefaultIPGateway"])[0] != null)
                                textBoxShowGate.Text = ((String[])objMO["DefaultIPGateway"])[0];
                            //else
                            //    textBoxShowIP.Text = " ";
                            if ((objMO["DNSServerSearchOrder"]) != null)
                                textBoxShowDNS1.Text = ((String[])objMO["DNSServerSearchOrder"])[0];
                            //else
                            //    textBoxShowIP.Text = " ";
                            //textBoxShowDNS2.Text = ((String[])objMO["DNSServerSearchOrder"])[1];
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }


    }
}
