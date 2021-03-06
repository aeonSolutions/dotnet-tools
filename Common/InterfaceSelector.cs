﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Common
{
    public partial class InterfaceSelectorComboBox : UserControl
    {
        private readonly ComboBox comboBox = new ComboBox();

        public event Action InterfaceDeleted;

        [DefaultValue(false)]
        public bool IncludeIPAddressAny { get; set; }

        public string TextValue
        {
			get
			{
				return comboBox.Text;
			}
			set
			{
				comboBox.Text = value;
			}
        }

        public InterfaceSelectorComboBox()
        {
            InitializeComponent();
            comboBox.Dock = DockStyle.Fill;
            Controls.Add(comboBox);
            this.Height = comboBox.Height;
            RefreshNetworkInterfaces();
            NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
        }

        public void DeleteSelected()
        {
            comboBox.SelectedIndex =
                comboBox.SelectedIndex > 0 ? comboBox.SelectedIndex - 1 : -1;
        }

        private void RefreshNetworkInterfaces()
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)RefreshNetworkInterfaces);
                return;
            }

            // Get all IP v4 addresses
            List<string> newList = GetIPAddresses();
            if (IncludeIPAddressAny)
            {
                newList.Add(IPAddress.Any.ToString());
                newList.Add(IPAddress.IPv6Any.ToString());
            }

            // Add
            foreach (string address in newList)
            {
                if (!comboBox.Items.Contains(address))
                {
                    // Added
                    comboBox.Items.Add(address);
                }
            }

            // Delete
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (!newList.Contains((String)comboBox.Items[i]))
                {
                    // Removed
                    if (comboBox.SelectedIndex == i)
                    {
                        InterfaceDeleted?.Invoke();
                    }
                    comboBox.Items.RemoveAt(i);
                }
            }
        }

        private static List<string> GetIPAddresses()
        {
            List<string> newList = new List<string>();
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface iface in interfaces)
            {
                if (!iface.Supports(NetworkInterfaceComponent.IPv6) ||
                    !iface.Supports(NetworkInterfaceComponent.IPv4) ||
                    iface.OperationalStatus != OperationalStatus.Up)
                {
                    continue;
                }

                IPInterfaceProperties ipProperties = iface.GetIPProperties();
                UnicastIPAddressInformationCollection addresses = ipProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation address in addresses)
                {
                    if (address.Address.AddressFamily == AddressFamily.InterNetwork ||
                        address.Address.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        newList.Add(address.Address.ToString());
                    }
                }
            }
            return newList;
        }

        private void NetworkChange_NetworkAddressChanged(object sender, System.EventArgs e)
        {
            RefreshNetworkInterfaces();
        }
    }
}
