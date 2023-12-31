﻿using Microsoft.Win32;
using Proxy_Changer.Connection;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Proxy_Changer {
    public partial class MainForm : Form {
        private const string proxyRegistryPath = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";
        private const string proxyEnableValueName = "ProxyEnable";
        private const string proxyServerValueName = "ProxyServer";

        public MainForm() {
            InitializeComponent();
        }

        private void ProxyBtn_Click(object sender, EventArgs e) {
            ToggleProxy();
        }

        private bool IsProxyEnabled() {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(proxyRegistryPath)) {
                if (key != null) {
                    object value = key.GetValue(proxyEnableValueName);
                    if (value != null && int.TryParse(value.ToString(), out int proxyEnable)) {
                        return proxyEnable == 1;
                    }
                }
            }
            return false;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Create an instance of DatabaseHelper and initialize the database
            string databasePath = "proxy.db";
            DatabaseHelper dbHelper = new DatabaseHelper(databasePath);
            dbHelper.InitializeDatabase();

            // Load the saved proxy address from the database and populate the textbox
            string savedProxyAddress = dbHelper.LoadProxyAddress();
            if (string.IsNullOrEmpty(savedProxyAddress)) {
                savedProxyAddress = "26.4.2.1:9090";
                dbHelper.SaveProxyAddress(savedProxyAddress);
            }
            ProxyAddressTb.Text = savedProxyAddress;

            ProxyAddressTb.ReadOnly = true;
            ProxyAddressTb.DoubleClick += ProxyAddressTb_DoubleClick;

            bool isProxyEnabled = IsProxyEnabled();
            UpdateButtonStatus(isProxyEnabled);
        }

        private void ToggleProxy() {
            bool isProxyEnabled = IsProxyEnabled();

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(proxyRegistryPath, true)) {
                if (key != null) {
                    if (isProxyEnabled) {
                        // Disable the proxy
                        key.SetValue(proxyEnableValueName, 0, RegistryValueKind.DWord);
                        key.DeleteValue(proxyServerValueName, false);
                        MessageBox.Show("Proxy is now OFF", "Proxy Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        // Enable the proxy
                        key.SetValue(proxyEnableValueName, 1, RegistryValueKind.DWord);

                        // Use the proxy address entered by the user
                        string proxyAddress = ProxyAddressTb.Text.Trim();
                        key.SetValue(proxyServerValueName, proxyAddress, RegistryValueKind.String);

                        // Save the proxy address to the database
                        string databasePath = "proxy.db";
                        DatabaseHelper dbHelper = new DatabaseHelper(databasePath);
                        dbHelper.SaveProxyAddress(proxyAddress);

                        MessageBox.Show($"Proxy is now ON with address {proxyAddress}", "Proxy Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            Process.Start(Application.ExecutablePath);
            Environment.Exit(0);
        }

        private void UpdateButtonStatus(bool isProxyEnabled) {
            if (isProxyEnabled) {
                ProxyBtn.Text = "Disable Proxy";
                StatusLbl.Text = "Enabled";
            } else {
                ProxyBtn.Text = "Enable Proxy";
                StatusLbl.Text = "Disabled";
                StatusLbl.ForeColor = Color.FromArgb(43, 43, 34);
            }
        }

        private void ProxyAddressTb_DoubleClick(object sender, EventArgs e) {
            ProxyAddressTb.ReadOnly = false;
        }

        private void netModToolStripMenuItem_Click(object sender, EventArgs e) {
            string netModPath = @"C:\Program Files (x86)\NetMod\NetMod.exe";
            if (System.IO.File.Exists(netModPath)) {
                Process.Start(netModPath);
            } else {
                MessageBox.Show("NetMod not found! Please install first.", "NetMod Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NetworkAdupterSettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            string command = "control ncpa.cpl";

            ProcessStartInfo processStartInfo = new ProcessStartInfo {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process {
                StartInfo = processStartInfo
            };

            process.Start();

            process.StandardInput.WriteLine(command);
            process.StandardInput.Flush();
            process.StandardInput.Close();

            process.WaitForExit();
            process.Close();
        }
    }
}
