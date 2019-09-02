using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPChanger
{
    public partial class Main : Form
    {
        NetworkSettings c;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            c = new NetworkSettings();
            c.showConnections(listBoxConnections);
        }

        private void buttonSetStatic_Click(object sender, EventArgs e)
        {
            c.IPAddress[0] = textBoxIP.Text;
            c.IPSubnet[0] = textBoxMask.Text;
            c.DefaultIPGateway[0] = textBoxGate.Text;

            c.setNetworkParametersStatic();

            //c.showConnections(listBoxConnections);
            c.showCurNetSettings(textBoxShowIP, textBoxShowMask, textBoxShowGate, textBoxShowDNS1, textBoxShowDNS2);
        }

        private void buttonSetDHCP_Click(object sender, EventArgs e)
        {
            c.setNetworkParametersDHCP();

            System.Threading.Thread.Sleep(2000);

            //c.showConnections(listBoxConnections);
            c.showCurNetSettings(textBoxShowIP, textBoxShowMask, textBoxShowGate, textBoxShowDNS1, textBoxShowDNS2);
        }

        private void listBoxConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxConnections.SelectedIndex != -1)
            {
                c.selectedAdapterDescription = c.adaptersNamesList[listBoxConnections.SelectedIndex];
                //c.macAddress = c.adaptersMACsList[listBoxConnections.SelectedIndex];
                c.showCurNetSettings(textBoxShowIP, textBoxShowMask, textBoxShowGate, textBoxShowDNS1, textBoxShowDNS2);
            }
        }

        private void buttonRebootAdapter_Click(object sender, EventArgs e)
        {
            c.rebootAdapter();
        }

        private void buttonRebootAll_Click(object sender, EventArgs e)
        {
            c.rebootAll();
        }

        private void buttonDisableAdapter_Click(object sender, EventArgs e)
        {
            c.disableAdapter();

            textBoxShowIP.Text = " ";
            textBoxShowMask.Text = " ";
            textBoxShowGate.Text = " ";
            textBoxShowDNS1.Text = " ";
            //textBoxShowDNS2.Text = " ";
        }

        private void buttonEnableAdapter_Click(object sender, EventArgs e)
        {
            c.enableAdapter();
            System.Threading.Thread.Sleep(2000);
            c.showCurNetSettings(textBoxShowIP, textBoxShowMask, textBoxShowGate, textBoxShowDNS1, textBoxShowDNS2);
        }

    }
}
