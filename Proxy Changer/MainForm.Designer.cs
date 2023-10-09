
namespace Proxy_Changer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProxyBtn = new System.Windows.Forms.Button();
            this.ProxyAddressTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openNetModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkAdupterSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProxyBtn
            // 
            this.ProxyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyBtn.Location = new System.Drawing.Point(100, 60);
            this.ProxyBtn.Name = "ProxyBtn";
            this.ProxyBtn.Size = new System.Drawing.Size(109, 34);
            this.ProxyBtn.TabIndex = 0;
            this.ProxyBtn.Text = "button1";
            this.ProxyBtn.UseVisualStyleBackColor = true;
            this.ProxyBtn.Click += new System.EventHandler(this.ProxyBtn_Click);
            // 
            // ProxyAddressTb
            // 
            this.ProxyAddressTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyAddressTb.Location = new System.Drawing.Point(100, 34);
            this.ProxyAddressTb.Name = "ProxyAddressTb";
            this.ProxyAddressTb.Size = new System.Drawing.Size(109, 20);
            this.ProxyAddressTb.TabIndex = 1;
            this.ProxyAddressTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProxyAddressTb.DoubleClick += new System.EventHandler(this.ProxyAddressTb_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proxy Server:Port";
            // 
            // StatusLbl
            // 
            this.StatusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.Location = new System.Drawing.Point(4, 67);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(56, 20);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNetModToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(217, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openNetModToolStripMenuItem
            // 
            this.openNetModToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netModToolStripMenuItem,
            this.networkAdupterSettingsToolStripMenuItem});
            this.openNetModToolStripMenuItem.Name = "openNetModToolStripMenuItem";
            this.openNetModToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openNetModToolStripMenuItem.Text = "Open";
            // 
            // netModToolStripMenuItem
            // 
            this.netModToolStripMenuItem.Name = "netModToolStripMenuItem";
            this.netModToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.netModToolStripMenuItem.Text = "NetMod";
            this.netModToolStripMenuItem.Click += new System.EventHandler(this.netModToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // networkAdupterSettingsToolStripMenuItem
            // 
            this.networkAdupterSettingsToolStripMenuItem.Name = "networkAdupterSettingsToolStripMenuItem";
            this.networkAdupterSettingsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.networkAdupterSettingsToolStripMenuItem.Text = "Network Connections";
            this.networkAdupterSettingsToolStripMenuItem.Click += new System.EventHandler(this.NetworkAdupterSettingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 101);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProxyAddressTb);
            this.Controls.Add(this.ProxyBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProxC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProxyBtn;
        private System.Windows.Forms.TextBox ProxyAddressTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openNetModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkAdupterSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

