
namespace hostelloginpage
{
    partial class SentUrlmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentUrlmail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsent = new System.Windows.Forms.Button();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnsent);
            this.panel1.Controls.Add(this.txtbody);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtsub);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txtto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 659);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(394, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 78);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsent
            // 
            this.btnsent.BackColor = System.Drawing.Color.SkyBlue;
            this.btnsent.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsent.Location = new System.Drawing.Point(623, 569);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(195, 78);
            this.btnsent.TabIndex = 7;
            this.btnsent.Text = "Sent Mail";
            this.btnsent.UseVisualStyleBackColor = false;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click);
            // 
            // txtbody
            // 
            this.txtbody.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbody.Location = new System.Drawing.Point(210, 347);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbody.Size = new System.Drawing.Size(608, 191);
            this.txtbody.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Body :";
            // 
            // txtsub
            // 
            this.txtsub.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub.Location = new System.Drawing.Point(210, 263);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(608, 34);
            this.txtsub.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject :";
            // 
            // Txtto
            // 
            this.Txtto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtto.Location = new System.Drawing.Point(210, 134);
            this.Txtto.Multiline = true;
            this.Txtto.Name = "Txtto";
            this.Txtto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txtto.Size = new System.Drawing.Size(608, 83);
            this.Txtto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(387, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sent Mail Here";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // SentUrlmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 659);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SentUrlmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SentUrlmail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtto;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.Button btnsent;
        private System.Windows.Forms.Button button1;
    }
}