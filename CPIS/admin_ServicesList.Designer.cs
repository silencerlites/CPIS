namespace CPIS
{
    partial class admin_ServicesList
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbAmount = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.cbCategoryList = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTreatCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCatergID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TreatCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvServiceList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(85, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 38;
            this.label1.Text = "Services List";
            // 
            // txtbSearch
            // 
            this.txtbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbSearch.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtbSearch.Location = new System.Drawing.Point(728, 63);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(274, 28);
            this.txtbSearch.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CPIS.Properties.Resources.icons8_Search_30px;
            this.pictureBox1.Location = new System.Drawing.Point(693, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Image = global::CPIS.Properties.Resources.icons8_Delete_30px_2;
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(904, 509);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 37);
            this.btDelete.TabIndex = 43;
            this.btDelete.Text = "Delete";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = global::CPIS.Properties.Resources.icons8_Doctors_Bag_30px_1;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(812, 509);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(83, 37);
            this.btAdd.TabIndex = 42;
            this.btAdd.Text = "Add";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CPIS.Properties.Resources.icons8_Treatment_48px;
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(32, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Description";
            // 
            // txtbDescription
            // 
            this.txtbDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbDescription.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtbDescription.ForeColor = System.Drawing.Color.Black;
            this.txtbDescription.Location = new System.Drawing.Point(36, 114);
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(241, 22);
            this.txtbDescription.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(32, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Amount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(36, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 2);
            this.panel2.TabIndex = 36;
            // 
            // txtbAmount
            // 
            this.txtbAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtbAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbAmount.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtbAmount.ForeColor = System.Drawing.Color.Black;
            this.txtbAmount.Location = new System.Drawing.Point(36, 239);
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(241, 22);
            this.txtbAmount.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(36, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 2);
            this.panel3.TabIndex = 39;
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.bt_Edit.FlatAppearance.BorderSize = 0;
            this.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.Color.White;
            this.bt_Edit.Image = global::CPIS.Properties.Resources.icons8_Edit_30px;
            this.bt_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Edit.Location = new System.Drawing.Point(58, 419);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(79, 37);
            this.bt_Edit.TabIndex = 44;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // cbCategoryList
            // 
            this.cbCategoryList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoryList.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cbCategoryList.ForeColor = System.Drawing.Color.Black;
            this.cbCategoryList.FormattingEnabled = true;
            this.cbCategoryList.Location = new System.Drawing.Point(36, 175);
            this.cbCategoryList.Name = "cbCategoryList";
            this.cbCategoryList.Size = new System.Drawing.Size(240, 30);
            this.cbCategoryList.TabIndex = 52;
            this.cbCategoryList.SelectedIndexChanged += new System.EventHandler(this.cbCategoryList_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gray;
            this.label21.Location = new System.Drawing.Point(32, 150);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 20);
            this.label21.TabIndex = 53;
            this.label21.Text = "Category";
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.ForeColor = System.Drawing.Color.White;
            this.bt_Save.Image = global::CPIS.Properties.Resources.icons8_Save_as_30px;
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(220, 419);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(79, 37);
            this.bt_Save.TabIndex = 71;
            this.bt_Save.Text = "Save";
            this.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Treatment Code";
            // 
            // txtbTreatCode
            // 
            this.txtbTreatCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtbTreatCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbTreatCode.Enabled = false;
            this.txtbTreatCode.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtbTreatCode.ForeColor = System.Drawing.Color.Black;
            this.txtbTreatCode.Location = new System.Drawing.Point(36, 59);
            this.txtbTreatCode.Name = "txtbTreatCode";
            this.txtbTreatCode.Size = new System.Drawing.Size(241, 22);
            this.txtbTreatCode.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(36, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 2);
            this.panel1.TabIndex = 74;
            // 
            // txtCatergID
            // 
            this.txtCatergID.BackColor = System.Drawing.SystemColors.Control;
            this.txtCatergID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCatergID.Font = new System.Drawing.Font("Open Sans", 1F, System.Drawing.FontStyle.Bold);
            this.txtCatergID.ForeColor = System.Drawing.Color.Black;
            this.txtCatergID.Location = new System.Drawing.Point(261, 164);
            this.txtCatergID.Name = "txtCatergID";
            this.txtCatergID.ReadOnly = true;
            this.txtCatergID.Size = new System.Drawing.Size(10, 2);
            this.txtCatergID.TabIndex = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCatergID);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtbTreatCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.cbCategoryList);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.txtbAmount);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtbDescription);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.groupBox2.Location = new System.Drawing.Point(25, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 350);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treatment Details";
            // 
            // TreatCode
            // 
            this.TreatCode.Text = "Treatment Code";
            this.TreatCode.Width = 136;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Description.Width = 234;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Category.Width = 169;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 108;
            // 
            // lvServiceList
            // 
            this.lvServiceList.BackColor = System.Drawing.Color.DimGray;
            this.lvServiceList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvServiceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TreatCode,
            this.Description,
            this.Category,
            this.Price});
            this.lvServiceList.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvServiceList.ForeColor = System.Drawing.Color.White;
            this.lvServiceList.FullRowSelect = true;
            this.lvServiceList.HoverSelection = true;
            this.lvServiceList.Location = new System.Drawing.Point(353, 99);
            this.lvServiceList.Name = "lvServiceList";
            this.lvServiceList.Scrollable = false;
            this.lvServiceList.Size = new System.Drawing.Size(649, 395);
            this.lvServiceList.TabIndex = 69;
            this.lvServiceList.UseCompatibleStateImageBehavior = false;
            this.lvServiceList.View = System.Windows.Forms.View.Details;
            this.lvServiceList.SelectedIndexChanged += new System.EventHandler(this.lvServiceList_SelectedIndexChanged);
            this.lvServiceList.Click += new System.EventHandler(this.lvServiceList_Click);
            // 
            // admin_ServicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.lvServiceList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "admin_ServicesList";
            this.Size = new System.Drawing.Size(1031, 639);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbAmount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.ComboBox cbCategoryList;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTreatCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCatergID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader TreatCode;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ListView lvServiceList;
    }
}
