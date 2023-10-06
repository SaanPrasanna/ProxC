
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
            this.SuspendLayout();
            // 
            // ProxyBtn
            // 
            this.ProxyBtn.Location = new System.Drawing.Point(100, 38);
            this.ProxyBtn.Name = "ProxyBtn";
            this.ProxyBtn.Size = new System.Drawing.Size(109, 34);
            this.ProxyBtn.TabIndex = 0;
            this.ProxyBtn.Text = "button1";
            this.ProxyBtn.UseVisualStyleBackColor = true;
            this.ProxyBtn.Click += new System.EventHandler(this.ProxyBtn_Click);
            // 
            // ProxyAddressTb
            // 
            this.ProxyAddressTb.Location = new System.Drawing.Point(100, 12);
            this.ProxyAddressTb.Name = "ProxyAddressTb";
            this.ProxyAddressTb.Size = new System.Drawing.Size(109, 20);
            this.ProxyAddressTb.TabIndex = 1;
            this.ProxyAddressTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProxyAddressTb.DoubleClick += new System.EventHandler(this.ProxyAddressTb_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proxy Server:Port";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 79);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProxyAddressTb);
            this.Controls.Add(this.ProxyBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProxC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProxyBtn;
        private System.Windows.Forms.TextBox ProxyAddressTb;
        private System.Windows.Forms.Label label1;
    }
}

