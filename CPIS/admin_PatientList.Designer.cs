namespace CPIS
{
    partial class admin_PatientList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.PatientNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contact_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.gbPatientList = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btNewP = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btView = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.admin_AddPatient2 = new CPIS.admin_AddPatient();
            this.admin_PatientDataView2 = new CPIS.admin_PatientDataView();
            this.gbPatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientNo,
            this.FullName,
            this.Contact_No,
            this.EmailAdd,
            this.Age,
            this.Birthdate,
            this.Status});
            this.listView1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1002, 481);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.Leave += new System.EventHandler(this.listView1_Leave);
            // 
            // PatientNo
            // 
            this.PatientNo.Text = "Patient No.";
            this.PatientNo.Width = 105;
            // 
            // FullName
            // 
            this.FullName.Text = "Name";
            this.FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FullName.Width = 304;
            // 
            // Contact_No
            // 
            this.Contact_No.Text = "Contact No";
            this.Contact_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Contact_No.Width = 120;
            // 
            // EmailAdd
            // 
            this.EmailAdd.Text = "Email";
            this.EmailAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailAdd.Width = 171;
            // 
            // Age
            // 
            this.Age.DisplayIndex = 5;
            this.Age.Text = "Age";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Age.Width = 62;
            // 
            // Birthdate
            // 
            this.Birthdate.DisplayIndex = 4;
            this.Birthdate.Text = "Birthdate";
            this.Birthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Birthdate.Width = 130;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 106;
            // 
            // txtbID
            // 
            this.txtbID.BackColor = System.Drawing.SystemColors.Control;
            this.txtbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbID.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbID.ForeColor = System.Drawing.Color.DarkGray;
            this.txtbID.Location = new System.Drawing.Point(87, 58);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(101, 21);
            this.txtbID.TabIndex = 21;
            // 
            // txtbSearch
            // 
            this.txtbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbSearch.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtbSearch.Location = new System.Drawing.Point(738, 53);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(274, 28);
            this.txtbSearch.TabIndex = 22;
            this.txtbSearch.TextChanged += new System.EventHandler(this.txtbSearch_TextChanged);
            // 
            // gbPatientList
            // 
            this.gbPatientList.Controls.Add(this.panel9);
            this.gbPatientList.Controls.Add(this.btDelete);
            this.gbPatientList.Controls.Add(this.btNewP);
            this.gbPatientList.Controls.Add(this.pictureBox2);
            this.gbPatientList.Controls.Add(this.txtbSearch);
            this.gbPatientList.Controls.Add(this.txtbID);
            this.gbPatientList.Controls.Add(this.btView);
            this.gbPatientList.Controls.Add(this.listView1);
            this.gbPatientList.Controls.Add(this.btExport);
            this.gbPatientList.Controls.Add(this.label12);
            this.gbPatientList.Controls.Add(this.pictureBox1);
            this.gbPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPatientList.Location = new System.Drawing.Point(0, 0);
            this.gbPatientList.Name = "gbPatientList";
            this.gbPatientList.Size = new System.Drawing.Size(1031, 654);
            this.gbPatientList.TabIndex = 26;
            this.gbPatientList.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Location = new System.Drawing.Point(83, 80);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(109, 2);
            this.panel9.TabIndex = 36;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Image = global::CPIS.Properties.Resources.icons8_Denied_30px_2;
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(156, 587);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 37);
            this.btDelete.TabIndex = 25;
            this.btDelete.Text = "Delete";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btNewP
            // 
            this.btNewP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btNewP.FlatAppearance.BorderSize = 0;
            this.btNewP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewP.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewP.ForeColor = System.Drawing.Color.White;
            this.btNewP.Image = global::CPIS.Properties.Resources.icons8_Add_User_Group_Woman_Man_30px;
            this.btNewP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNewP.Location = new System.Drawing.Point(12, 586);
            this.btNewP.Name = "btNewP";
            this.btNewP.Size = new System.Drawing.Size(138, 37);
            this.btNewP.TabIndex = 24;
            this.btNewP.Text = "New Patient";
            this.btNewP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNewP.UseVisualStyleBackColor = false;
            this.btNewP.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::CPIS.Properties.Resources.icons8_Search_30px;
            this.pictureBox2.Location = new System.Drawing.Point(703, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btView
            // 
            this.btView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btView.FlatAppearance.BorderSize = 0;
            this.btView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btView.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btView.ForeColor = System.Drawing.Color.White;
            this.btView.Image = global::CPIS.Properties.Resources.icons8_View_30px;
            this.btView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btView.Location = new System.Drawing.Point(257, 587);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(83, 37);
            this.btView.TabIndex = 20;
            this.btView.Text = "View";
            this.btView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btView.UseVisualStyleBackColor = false;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btExport
            // 
            this.btExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.btExport.FlatAppearance.BorderSize = 0;
            this.btExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExport.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExport.Image = global::CPIS.Properties.Resources.icons8_Microsoft_Excel_35px;
            this.btExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExport.Location = new System.Drawing.Point(846, 587);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(160, 37);
            this.btExport.TabIndex = 15;
            this.btExport.Text = "Export to Excel";
            this.btExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExport.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(79, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 37);
            this.label12.TabIndex = 12;
            this.label12.Text = "Patient List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CPIS.Properties.Resources.icons8_User_Group_96px;
            this.pictureBox1.Location = new System.Drawing.Point(10, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Image = global::CPIS.Properties.Resources.icons8_Go_Back_42px_31;
            this.pbBack.Location = new System.Drawing.Point(967, 10);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(37, 36);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 101;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // admin_AddPatient2
            // 
            this.admin_AddPatient2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_AddPatient2.Location = new System.Drawing.Point(0, 0);
            this.admin_AddPatient2.Name = "admin_AddPatient2";
            this.admin_AddPatient2.Size = new System.Drawing.Size(1031, 654);
            this.admin_AddPatient2.TabIndex = 102;
            // 
            // admin_PatientDataView2
            // 
            this.admin_PatientDataView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_PatientDataView2.Location = new System.Drawing.Point(0, 0);
            this.admin_PatientDataView2.Name = "admin_PatientDataView2";
            this.admin_PatientDataView2.Size = new System.Drawing.Size(1031, 654);
            this.admin_PatientDataView2.TabIndex = 103;
            // 
            // admin_PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.gbPatientList);
            this.Controls.Add(this.admin_AddPatient2);
            this.Controls.Add(this.admin_PatientDataView2);
            this.Name = "admin_PatientList";
            this.Size = new System.Drawing.Size(1031, 654);
            this.gbPatientList.ResumeLayout(false);
            this.gbPatientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btNewP;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox gbPatientList;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label12;
        private admin_AddPatient admin_AddPatient2;
        private admin_PatientDataView admin_PatientDataView2;
        private System.Windows.Forms.ColumnHeader PatientNo;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Contact_No;
        private System.Windows.Forms.ColumnHeader EmailAdd;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Birthdate;
        private System.Windows.Forms.ColumnHeader Status;
        public System.Windows.Forms.PictureBox pbBack;
    }
}
