﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursorWrangler
{
    class CursorWranglerContext : ApplicationContext
    {
        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem QuitMenuItem;
        private ToolStripMenuItem ShowMenuItem;

        private readonly CursorWrangler fsl;
        private readonly Checker c;

        public CursorWranglerContext()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            InitializeComponent();

            c = new Checker();
            fsl = new CursorWrangler();
            c.ActiveStateChanged += new EventHandler<BoolEventArgs>(fsl.ActiveStateChanged);
            c.ForegroundFullscreenStateChanged += new EventHandler<BoolEventArgs>(fsl.ForegroundFullscreenStateChanged);
            fsl.ActiveStateToggled += new EventHandler(c.ActiveStateToggled);

            TrayIcon.Visible = true;
        }

        private void InitializeComponent()
        {
            TrayIcon = new NotifyIcon();
            TrayIconContextMenu = new ContextMenuStrip();
            ShowMenuItem = new ToolStripMenuItem();
            QuitMenuItem = new ToolStripMenuItem();
            TrayIconContextMenu.SuspendLayout();

            TrayIcon.ContextMenuStrip = TrayIconContextMenu;
            TrayIcon.Icon = Properties.Resources.CursorIcon;
            TrayIcon.Text = "CursorWrangler";
            TrayIcon.Visible = true;
            TrayIcon.MouseClick += new MouseEventHandler(TrayIcon_MouseClick);

            TrayIconContextMenu.Items.AddRange(new ToolStripItem[] {
                ShowMenuItem,
                QuitMenuItem
            });
            TrayIconContextMenu.Name = "TrayIconContextMenu";
            TrayIconContextMenu.Size = new Size(104, 48);

            ShowMenuItem.Name = "ShowMenuItem";
            ShowMenuItem.Size = new Size(103, 22);
            ShowMenuItem.Text = "Show";
            ShowMenuItem.Click += ShowMenuItem_Click;

            QuitMenuItem.Name = "QuitMenuItem";
            QuitMenuItem.Size = new Size(103, 22);
            QuitMenuItem.Text = "Quit";
            QuitMenuItem.Click += QuitMenuItem_Click;

            TrayIconContextMenu.ResumeLayout(false);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            TrayIcon.Visible = false;
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                fsl.SetVisibility(true);
        }

        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            fsl.SetVisibility(true);
        }

        private void QuitMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            //Application.Exit();
        }
    }
}