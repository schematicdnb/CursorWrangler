using System.Windows.Forms;

namespace CursorWrangler
{
    partial class CursorWrangler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ToggleButton;
        private System.Windows.Forms.Label StatusLabel;
        //private System.Windows.Forms.Label MadeByLabel;
        private System.Windows.Forms.CheckBox MinimizeOnCloseCheckBox;
        private System.Windows.Forms.CheckBox LaunchOnStartupCheckBox;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursorWrangler));
            this.ToggleButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            //this.MadeByLabel = new System.Windows.Forms.Label();
            this.MinimizeOnCloseCheckBox = new System.Windows.Forms.CheckBox();
            this.LaunchOnStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ToggleButton
            // 
            this.ToggleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleButton.Location = new System.Drawing.Point(57, 12);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(113, 37);
            this.ToggleButton.TabIndex = 0;
            this.ToggleButton.Text = "Toggle";
            this.ToggleButton.UseVisualStyleBackColor = true;
            this.ToggleButton.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StatusLabel.Location = new System.Drawing.Point(-1, 52);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(230, 24);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Waiting for focus";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LaunchOnStartupCheckBox
            // 
            this.LaunchOnStartupCheckBox.AutoSize = true;
            this.LaunchOnStartupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LaunchOnStartupCheckBox.Location = new System.Drawing.Point(18, 90);
            this.LaunchOnStartupCheckBox.Name = "LaunchOnStartupCheckBox";
            this.LaunchOnStartupCheckBox.Size = new System.Drawing.Size(187, 17);
            this.LaunchOnStartupCheckBox.TabIndex = 2;
            this.LaunchOnStartupCheckBox.Text = "Launch at startup";
            this.LaunchOnStartupCheckBox.UseVisualStyleBackColor = true;
            this.LaunchOnStartupCheckBox.Checked = true;
            // 
            // MinimizeOnCloseCheckBox
            // 
            this.MinimizeOnCloseCheckBox.AutoSize = true;
            this.MinimizeOnCloseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MinimizeOnCloseCheckBox.Location = new System.Drawing.Point(18, 125);
            this.MinimizeOnCloseCheckBox.Name = "MinimizeOnCloseCheckBox";
            this.MinimizeOnCloseCheckBox.Size = new System.Drawing.Size(187, 17);
            this.MinimizeOnCloseCheckBox.TabIndex = 3;
            this.MinimizeOnCloseCheckBox.Text = "Minimize to taskbar on close";
            this.MinimizeOnCloseCheckBox.UseVisualStyleBackColor = true;
            this.MinimizeOnCloseCheckBox.Checked = true;
            // 
            // MadeByLabel
            // 
            //this.MadeByLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            //this.MadeByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            //this.MadeByLabel.Location = new System.Drawing.Point(12, 150);
            //this.MadeByLabel.Name = "MadeByLabel";
            //this.MadeByLabel.Size = new System.Drawing.Size(205, 44);
            //this.MadeByLabel.TabIndex = 4;
            //this.MadeByLabel.Text = "✨ Made by Blåberry and the community ✨";
            //this.MadeByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CursorWrangler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.ToggleButton);
            this.Controls.Add(this.LaunchOnStartupCheckBox);
            this.Controls.Add(this.MinimizeOnCloseCheckBox);
            //this.Controls.Add(this.MadeByLabel);
            this.Controls.Add(this.StatusLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = Properties.Resources.CursorIcon;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 200);
            this.MinimumSize = new System.Drawing.Size(250, 200);
            this.Name = "CursorWrangler";
            this.ShowIcon = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CursorWrangler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CursorWrangler_FormClosing);
            this.Resize += new System.EventHandler(this.CursorWrangler_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


    }
}
