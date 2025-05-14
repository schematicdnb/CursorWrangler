using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace CursorWrangler
{
    public partial class CursorWrangler : Form
    {
        public event EventHandler ActiveStateToggled;

        public CursorWrangler()
        {
            InitializeComponent();
            MinimizeOnCloseCheckBox.Checked = Properties.Settings.Default.MinimizeOnClose;
            MinimizeOnCloseCheckBox.CheckedChanged += MinimizeOnCloseCheckBox_CheckedChanged;
            
            LaunchOnStartupCheckBox.Checked = Properties.Settings.Default.LaunchOnStartup;
            LaunchOnStartupCheckBox.CheckedChanged += LaunchOnStartupCheckBox_CheckedChanged;
        }

        private void MinimizeOnCloseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["MinimizeOnClose"] = MinimizeOnCloseCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void LaunchOnStartupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["LaunchOnStartup"] = LaunchOnStartupCheckBox.Checked;
            Properties.Settings.Default.Save();
            SetStartup(LaunchOnStartupCheckBox.Checked);
        }

        private void SetStartup(bool enable)
        {
            string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            string appName = "CursorWrangler";
            string exePath = Application.ExecutablePath;

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(runKey, true))
            {
                if (enable)
                {
                    key.SetValue(appName, $"\"{exePath}\"");
                } else
                {
                    key.DeleteValue(appName, false);
                }
            }
        }

        private void CursorWrangler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MinimizeOnCloseCheckBox.Checked)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                SetVisibility(false);
            }
            else
            {
                Application.Exit();
            }
        }

        private void CursorWrangler_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                SetVisibility(false);
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            ActiveStateToggled?.Invoke(this, e);
        }

        public void SetVisibility(bool state)
        {
            // Always setting to minimized ensures that the window gets focus when visibility is set to true
            WindowState = FormWindowState.Minimized;

            Visible = state;

            if (state)
                WindowState = FormWindowState.Normal;
        }

        public void ActiveStateChanged(object sender, BoolEventArgs e)
        {
            StatusLabel.Text = e.Bool ? "Waiting for focus" : "Paused";
        }

        public void ForegroundFullscreenStateChanged(object sender, BoolEventArgs e)
        {
            StatusLabel.Text = e.Bool ? "Fullscreen app in focus" : "Waiting for focus";
        }
    }
}
