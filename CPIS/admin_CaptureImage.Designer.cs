namespace CPIS
{
    partial class admin_CaptureImage
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
            this.ptitleBar = new System.Windows.Forms.Panel();
            this.lmcClose = new System.Windows.Forms.Label();
            this.pbCaptureProcess = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.ptitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ptitleBar
            // 
            this.ptitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.ptitleBar.Controls.Add(this.lmcClose);
            this.ptitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptitleBar.Location = new System.Drawing.Point(0, 0);
            this.ptitleBar.Name = "ptitleBar";
            this.ptitleBar.Size = new System.Drawing.Size(577, 43);
            this.ptitleBar.TabIndex = 43;
            // 
            // lmcClose
            // 
            this.lmcClose.AutoSize = true;
            this.lmcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lmcClose.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lmcClose.ForeColor = System.Drawing.Color.White;
            this.lmcClose.Location = new System.Drawing.Point(537, 8);
            this.lmcClose.Name = "lmcClose";
            this.lmcClose.Size = new System.Drawing.Size(29, 29);
            this.lmcClose.TabIndex = 16;
            this.lmcClose.Text = "X";
            this.lmcClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbCaptureProcess
            // 
            this.pbCaptureProcess.Location = new System.Drawing.Point(22, 62);
            this.pbCaptureProcess.Name = "pbCaptureProcess";
            this.pbCaptureProcess.Size = new System.Drawing.Size(258, 203);
            this.pbCaptureProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaptureProcess.TabIndex = 44;
            this.pbCaptureProcess.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(296, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(38, 290);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 46;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // admin_CaptureImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 346);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbCaptureProcess);
            this.Controls.Add(this.ptitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_CaptureImage";
            this.Text = "admin_CaptureImage";
            this.ptitleBar.ResumeLayout(false);
            this.ptitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ptitleBar;
        private System.Windows.Forms.Label lmcClose;
        private System.Windows.Forms.PictureBox pbCaptureProcess;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btStart;
    }
}