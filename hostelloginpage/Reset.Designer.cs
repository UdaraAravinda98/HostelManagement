
namespace hostelloginpage
{
    partial class Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset));
            this.Txtpass = new System.Windows.Forms.TextBox();
            this.txtpassvarify = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txtpass
            // 
            this.Txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtpass.Location = new System.Drawing.Point(45, 105);
            this.Txtpass.Name = "Txtpass";
            this.Txtpass.Size = new System.Drawing.Size(358, 38);
            this.Txtpass.TabIndex = 0;
            this.Txtpass.TextChanged += new System.EventHandler(this.Txtpass_TextChanged);
            this.Txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtpass_KeyDown);
            // 
            // txtpassvarify
            // 
            this.txtpassvarify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassvarify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassvarify.Location = new System.Drawing.Point(45, 206);
            this.txtpassvarify.Name = "txtpassvarify";
            this.txtpassvarify.Size = new System.Drawing.Size(358, 38);
            this.txtpassvarify.TabIndex = 1;
            this.txtpassvarify.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassvarify_KeyDown);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(127)))), ((int)(((byte)(195)))));
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(44, 278);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(358, 51);
            this.btnreset.TabIndex = 2;
            this.btnreset.Text = "Reset Password";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(127)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnmin);
            this.panel1.Controls.Add(this.btnmax);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 556);
            this.panel1.TabIndex = 3;
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmin.BackgroundImage")));
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(647, 3);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(60, 52);
            this.btnmin.TabIndex = 15;
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click_1);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BackColor = System.Drawing.Color.Transparent;
            this.btnmax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmax.BackgroundImage")));
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmax.ForeColor = System.Drawing.Color.White;
            this.btnmax.Location = new System.Drawing.Point(713, 3);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(60, 52);
            this.btnmax.TabIndex = 14;
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click_1);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = global::hostelloginpage.Properties.Resources.red_close_button_vector_clipart;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(779, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(53, 52);
            this.btnclose.TabIndex = 13;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(362, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 47);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(136, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hostel Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Txtpass);
            this.panel2.Controls.Add(this.txtpassvarify);
            this.panel2.Location = new System.Drawing.Point(362, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 360);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(108)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(41, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(108)))), ((int)(((byte)(112)))));
            this.label5.Location = new System.Drawing.Point(41, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "New Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(127)))), ((int)(((byte)(195)))));
            this.label4.Location = new System.Drawing.Point(-1, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reset Password";
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 556);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset";
            this.Load += new System.EventHandler(this.Reset_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txtpass;
        private System.Windows.Forms.TextBox txtpassvarify;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnmin;
    }
}