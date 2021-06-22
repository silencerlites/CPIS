namespace CPIS
{
    partial class admin_BillingStatement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tooth_Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Treatment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbGTotal = new System.Windows.Forms.Label();
            this.txtbPatientN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbAddress = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbBillNo = new System.Windows.Forms.Label();
            this.txtIssuedDate = new System.Windows.Forms.Label();
            this.txtbPayDue = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbPBal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCharNo = new System.Windows.Forms.TextBox();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.bt_Payment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Print = new System.Windows.Forms.Button();
            this.pb_letterhead = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.admin_Payment1 = new CPIS.admin_Payment();
            ((System.ComponentModel.ISupportInitialize)(this.pb_letterhead)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label1.Location = new System.Drawing.Point(420, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Billing No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label2.Location = new System.Drawing.Point(406, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Issued Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 33);
            this.label3.TabIndex = 47;
            this.label3.Text = "Statement of Account";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tooth_Num,
            this.Treatment,
            this.Amount});
            this.listView1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(599, 287);
            this.listView1.TabIndex = 73;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Tooth_Num
            // 
            this.Tooth_Num.Text = "Tooth No.";
            this.Tooth_Num.Width = 90;
            // 
            // Treatment
            // 
            this.Treatment.Text = "Treatment Applied";
            this.Treatment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Treatment.Width = 353;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amount.Width = 152;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(27, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 22);
            this.label20.TabIndex = 74;
            this.label20.Text = "Patient Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(335, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 78;
            this.label5.Text = "Grand Total:";
            // 
            // txtbGTotal
            // 
            this.txtbGTotal.AutoSize = true;
            this.txtbGTotal.Font = new System.Drawing.Font("Open Sans Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtbGTotal.ForeColor = System.Drawing.Color.Black;
            this.txtbGTotal.Location = new System.Drawing.Point(513, 540);
            this.txtbGTotal.Name = "txtbGTotal";
            this.txtbGTotal.Size = new System.Drawing.Size(20, 24);
            this.txtbGTotal.TabIndex = 79;
            this.txtbGTotal.Text = "0";
            // 
            // txtbPatientN
            // 
            this.txtbPatientN.AutoSize = true;
            this.txtbPatientN.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtbPatientN.ForeColor = System.Drawing.Color.Black;
            this.txtbPatientN.Location = new System.Drawing.Point(149, 90);
            this.txtbPatientN.Name = "txtbPatientN";
            this.txtbPatientN.Size = new System.Drawing.Size(56, 22);
            this.txtbPatientN.TabIndex = 80;
            this.txtbPatientN.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(68, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 81;
            this.label8.Text = "Address:";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Open Sans Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(513, 448);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(20, 24);
            this.txtTotal.TabIndex = 83;
            this.txtTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(399, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 22);
            this.label10.TabIndex = 82;
            this.label10.Text = "Total:";
            // 
            // txtbAddress
            // 
            this.txtbAddress.AutoSize = true;
            this.txtbAddress.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtbAddress.ForeColor = System.Drawing.Color.Black;
            this.txtbAddress.Location = new System.Drawing.Point(149, 117);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(73, 22);
            this.txtbAddress.TabIndex = 86;
            this.txtbAddress.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(27, 576);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 22);
            this.label12.TabIndex = 87;
            this.label12.Text = "Payment due by:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(27, 605);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(346, 22);
            this.label13.TabIndex = 88;
            this.label13.Text = "Please make payment into Bank Account No.";
            // 
            // txtbBillNo
            // 
            this.txtbBillNo.AutoSize = true;
            this.txtbBillNo.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtbBillNo.ForeColor = System.Drawing.Color.Black;
            this.txtbBillNo.Location = new System.Drawing.Point(515, 47);
            this.txtbBillNo.Name = "txtbBillNo";
            this.txtbBillNo.Size = new System.Drawing.Size(84, 22);
            this.txtbBillNo.TabIndex = 90;
            this.txtbBillNo.Text = "BN2018-0";
            // 
            // txtIssuedDate
            // 
            this.txtIssuedDate.AutoSize = true;
            this.txtIssuedDate.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtIssuedDate.ForeColor = System.Drawing.Color.Black;
            this.txtIssuedDate.Location = new System.Drawing.Point(515, 76);
            this.txtIssuedDate.Name = "txtIssuedDate";
            this.txtIssuedDate.Size = new System.Drawing.Size(94, 22);
            this.txtIssuedDate.TabIndex = 91;
            this.txtIssuedDate.Text = "00/00/0000";
            // 
            // txtbPayDue
            // 
            this.txtbPayDue.AutoSize = true;
            this.txtbPayDue.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtbPayDue.ForeColor = System.Drawing.Color.Black;
            this.txtbPayDue.Location = new System.Drawing.Point(169, 576);
            this.txtbPayDue.Name = "txtbPayDue";
            this.txtbPayDue.Size = new System.Drawing.Size(94, 22);
            this.txtbPayDue.TabIndex = 92;
            this.txtbPayDue.Text = "00/00/0000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(45, 486);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(306, 20);
            this.label17.TabIndex = 93;
            this.label17.Text = "You have a previous balance in billing no. of ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(348, 485);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 22);
            this.label18.TabIndex = 94;
            this.label18.Text = "BN2018-0";
            // 
            // txtbPBal
            // 
            this.txtbPBal.AutoSize = true;
            this.txtbPBal.Font = new System.Drawing.Font("Open Sans Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtbPBal.ForeColor = System.Drawing.Color.Black;
            this.txtbPBal.Location = new System.Drawing.Point(513, 492);
            this.txtbPBal.Name = "txtbPBal";
            this.txtbPBal.Size = new System.Drawing.Size(20, 24);
            this.txtbPBal.TabIndex = 95;
            this.txtbPBal.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(296, 508);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 20);
            this.label21.TabIndex = 96;
            this.label21.Text = "with the amount of";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 97;
            this.label4.Text = "Previous balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(370, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 98;
            this.label6.Text = "1234567890";
            // 
            // txtCharNo
            // 
            this.txtCharNo.Location = new System.Drawing.Point(670, 126);
            this.txtCharNo.Name = "txtCharNo";
            this.txtCharNo.Size = new System.Drawing.Size(10, 20);
            this.txtCharNo.TabIndex = 99;
            this.txtCharNo.TextChanged += new System.EventHandler(this.txtCharNo_TextChanged);
            // 
            // bt_Ok
            // 
            this.bt_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.bt_Ok.FlatAppearance.BorderSize = 0;
            this.bt_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Ok.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ok.ForeColor = System.Drawing.Color.White;
            this.bt_Ok.Image = global::CPIS.Properties.Resources.icons8_Ok_30px;
            this.bt_Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Ok.Location = new System.Drawing.Point(31, 665);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(70, 37);
            this.bt_Ok.TabIndex = 100;
            this.bt_Ok.Text = "Ok";
            this.bt_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Ok.UseVisualStyleBackColor = false;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_Payment
            // 
            this.bt_Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.bt_Payment.FlatAppearance.BorderSize = 0;
            this.bt_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Payment.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Payment.ForeColor = System.Drawing.Color.White;
            this.bt_Payment.Image = global::CPIS.Properties.Resources.icons8_Cash_in_Hand_30px;
            this.bt_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Payment.Location = new System.Drawing.Point(112, 665);
            this.bt_Payment.Name = "bt_Payment";
            this.bt_Payment.Size = new System.Drawing.Size(158, 37);
            this.bt_Payment.TabIndex = 89;
            this.bt_Payment.Text = "Make Payment";
            this.bt_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Payment.UseVisualStyleBackColor = false;
            this.bt_Payment.Click += new System.EventHandler(this.bt_Payment_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::CPIS.Properties.Resources.icons8_View_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(369, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 85;
            this.button1.Text = "Print Preview";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bt_Print
            // 
            this.bt_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.bt_Print.FlatAppearance.BorderSize = 0;
            this.bt_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Print.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Print.ForeColor = System.Drawing.Color.White;
            this.bt_Print.Image = global::CPIS.Properties.Resources.icons8_Print_30px;
            this.bt_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Print.Location = new System.Drawing.Point(522, 665);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(90, 37);
            this.bt_Print.TabIndex = 84;
            this.bt_Print.Text = "Print";
            this.bt_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Print.UseVisualStyleBackColor = false;
            // 
            // pb_letterhead
            // 
            this.pb_letterhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_letterhead.Image = global::CPIS.Properties.Resources.Untitled_11;
            this.pb_letterhead.Location = new System.Drawing.Point(0, 0);
            this.pb_letterhead.Name = "pb_letterhead";
            this.pb_letterhead.Size = new System.Drawing.Size(641, 89);
            this.pb_letterhead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_letterhead.TabIndex = 44;
            this.pb_letterhead.TabStop = false;
            this.pb_letterhead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_letterhead_MouseDown);
            this.pb_letterhead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_letterhead_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Ok);
            this.groupBox1.Controls.Add(this.txtCharNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtbPBal);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtbPayDue);
            this.groupBox1.Controls.Add(this.txtIssuedDate);
            this.groupBox1.Controls.Add(this.txtbBillNo);
            this.groupBox1.Controls.Add(this.bt_Payment);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtbAddress);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bt_Print);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbPatientN);
            this.groupBox1.Controls.Add(this.txtbGTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 711);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // admin_Payment1
            // 
            this.admin_Payment1.Location = new System.Drawing.Point(112, 93);
            this.admin_Payment1.Name = "admin_Payment1";
            this.admin_Payment1.Size = new System.Drawing.Size(441, 344);
            this.admin_Payment1.TabIndex = 101;
            // 
            // admin_BillingStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 816);
            this.Controls.Add(this.admin_Payment1);
            this.Controls.Add(this.pb_letterhead);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_BillingStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_BillingStatement";
            ((System.ComponentModel.ISupportInitialize)(this.pb_letterhead)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_letterhead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tooth_Num;
        private System.Windows.Forms.ColumnHeader Treatment;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtbGTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtbPBal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label txtbBillNo;
        public System.Windows.Forms.Label txtbPatientN;
        public System.Windows.Forms.Label txtbAddress;
        public System.Windows.Forms.Label txtIssuedDate;
        public System.Windows.Forms.TextBox txtCharNo;
        public System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button bt_Ok;
        private admin_Payment admin_Payment1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label txtbPayDue;
        public System.Windows.Forms.Button bt_Payment;
    }
}