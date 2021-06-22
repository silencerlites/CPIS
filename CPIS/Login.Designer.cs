namespace CPIS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtbPassLog = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbUserNLog = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lmcClose = new System.Windows.Forms.Label();
            this.lmcMini = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.llNewAcc = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pb_ShowPass = new System.Windows.Forms.PictureBox();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.panelDrag);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 421);
            this.panel1.TabIndex = 0;
            // 
            // panelDrag
            // 
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(748, 45);
            this.panelDrag.TabIndex = 0;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            this.panelDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CPIS.Properties.Resources.pizarro;
            this.pictureBox3.Location = new System.Drawing.Point(37, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(287, 352);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // txtbPassLog
            // 
            this.txtbPassLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtbPassLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPassLog.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassLog.ForeColor = System.Drawing.Color.DarkGray;
            this.txtbPassLog.Location = new System.Drawing.Point(478, 217);
            this.txtbPassLog.Name = "txtbPassLog";
            this.txtbPassLog.Size = new System.Drawing.Size(184, 29);
            this.txtbPassLog.TabIndex = 10;
            this.txtbPassLog.Text = "password";
            this.txtbPassLog.Enter += new System.EventHandler(this.txtbPassLog_Enter);
            this.txtbPassLog.Leave += new System.EventHandler(this.txtbPassLog_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(419, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 2);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(421, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 2);
            this.panel2.TabIndex = 8;
            // 
            // txtbUserNLog
            // 
            this.txtbUserNLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtbUserNLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUserNLog.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUserNLog.ForeColor = System.Drawing.Color.DarkGray;
            this.txtbUserNLog.Location = new System.Drawing.Point(477, 138);
            this.txtbUserNLog.Name = "txtbUserNLog";
            this.txtbUserNLog.Size = new System.Drawing.Size(221, 29);
            this.txtbUserNLog.TabIndex = 7;
            this.txtbUserNLog.Text = "username";
            this.txtbUserNLog.Enter += new System.EventHandler(this.txtbUserNLog_Enter);
            this.txtbUserNLog.Leave += new System.EventHandler(this.txtbUserNLog_Leave);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(591, 273);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(107, 40);
            this.btLogin.TabIndex = 11;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lmcClose
            // 
            this.lmcClose.AutoSize = true;
            this.lmcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lmcClose.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmcClose.ForeColor = System.Drawing.Color.DimGray;
            this.lmcClose.Location = new System.Drawing.Point(706, 10);
            this.lmcClose.Name = "lmcClose";
            this.lmcClose.Size = new System.Drawing.Size(29, 29);
            this.lmcClose.TabIndex = 15;
            this.lmcClose.Text = "X";
            this.lmcClose.Click += new System.EventHandler(this.lmcClose_Click);
            // 
            // lmcMini
            // 
            this.lmcMini.AutoSize = true;
            this.lmcMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lmcMini.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmcMini.ForeColor = System.Drawing.Color.DimGray;
            this.lmcMini.Location = new System.Drawing.Point(672, 8);
            this.lmcMini.Name = "lmcMini";
            this.lmcMini.Size = new System.Drawing.Size(27, 33);
            this.lmcMini.TabIndex = 14;
            this.lmcMini.Text = "-";
            this.lmcMini.Click += new System.EventHandler(this.lmcMini_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(422, 273);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(107, 40);
            this.btCancel.TabIndex = 31;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // llNewAcc
            // 
            this.llNewAcc.AutoSize = true;
            this.llNewAcc.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llNewAcc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.llNewAcc.Location = new System.Drawing.Point(485, 328);
            this.llNewAcc.Name = "llNewAcc";
            this.llNewAcc.Size = new System.Drawing.Size(154, 20);
            this.llNewAcc.TabIndex = 32;
            this.llNewAcc.TabStop = true;
            this.llNewAcc.Text = "create a new account";
            this.llNewAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNewAcc_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(416, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CPIS.Properties.Resources.Lock_Lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(418, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CPIS.Properties.Resources.User_Administrator_Red_icon;
            this.pictureBox1.Location = new System.Drawing.Point(420, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(489, 135);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(285, 326);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pb_ShowPass
            // 
            this.pb_ShowPass.Image = global::CPIS.Properties.Resources.icons8_Eye_25px;
            this.pb_ShowPass.Location = new System.Drawing.Point(669, 219);
            this.pb_ShowPass.Name = "pb_ShowPass";
            this.pb_ShowPass.Size = new System.Drawing.Size(27, 25);
            this.pb_ShowPass.TabIndex = 75;
            this.pb_ShowPass.TabStop = false;
            this.pb_ShowPass.Click += new System.EventHandler(this.pb_ShowPass_Click);
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_Msg.Location = new System.Drawing.Point(431, 380);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(0, 19);
            this.lbl_Msg.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(410, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 77;
            // 
            // Login
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.pb_ShowPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llNewAcc);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lmcClose);
            this.Controls.Add(this.lmcMini);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtbPassLog);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtbUserNLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbPassLog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbUserNLog;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lmcClose;
        private System.Windows.Forms.Label lmcMini;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.LinkLabel llNewAcc;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_ShowPass;
        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.Label label2;
    }
}

