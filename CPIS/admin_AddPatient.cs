using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CPIS
{
    public partial class admin_AddPatient : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\iLites\Documents\Visual Studio 2017\Projects\CPIS\CPIS\db.CPIS.mdf;Integrated Security = True");

        public admin_AddPatient()
        {
            InitializeComponent();
            cbStat.SelectedIndex = 0;
            cbStat.Enabled = false;
            cbGender.SelectedIndex = 0;
            cbMarital.SelectedIndex = 0;
            checkBoxDen();
            tabControl2.Enabled = false;
            txtbID.Enabled = false;
            txtbAge.Enabled = false;
        }

        //method

        void Clear()
        {
            txtbID.Text = txtbFName.Text = txtbMName.Text = txtbLName.Text = txtbAdd.Text = txtbConNum.Text = txtbEmail.Text = dtpBirthD.Text = txtbAge.Text = cbGender.Text = cbMarital.Text = "";
            txtbOcclusion.Text = txtbPerCondi.Text = txtbOralHyg.Text = txtAbnor.Text = txtbSUpper.Text = txtbSLower.Text = "";
            txtGCondi.Text = txtbNatTreat.Text = txtbAllerg.Text = txtbChronicA.Text = txtbBloodP.Text = cbPHBleed.Text = "";
            cbUpper.Checked = false;
            cbLower.Checked = false;
            pbImageClient.Image.Dispose();
            pbImageClient.Image = null;
        }

        void PatientIDSeries()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_PatientID", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtbID.Text = dt.Rows[0][0].ToString();
        }

        void checkBoxDen()
        {
            if (cbUpper.Checked == true)
            {
                txtbSUpper.Enabled = true;
            }
            else
            {
                txtbSUpper.Enabled = false;
            }

            if (cbLower.Checked == true)
            {
                txtbSLower.Enabled = true;
            }
            else
            {
                txtbSLower.Enabled = false;
            }
        }
        private void dtpBirthD_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtpBirthD.Value;
            DateTime to = DateTime.Now;
            TimeSpan TSpan = to - from;
            double days = TSpan.TotalDays;
            txtbAge.Text = (days / 365).ToString("0");
        }

        private void btTakePhoto_Click(object sender, EventArgs e)
        {
            admin_CaptureImage captureImage = new admin_CaptureImage();
            captureImage.Show();
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openF = new OpenFileDialog();
                openF.Filter = "(*.jpg;*.jpeg;*.bmp;*.png;*.gif)| *.jpg; *.jpeg; *.bmp; *.png";
                DialogResult dr = openF.ShowDialog();
                pbImageClient.Image = Image.FromFile(openF.FileName);
            }
            catch(Exception ex)
            {
                
            }
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            PatientIDSeries();

            if (txtbFName.Text == "" || txtbLName.Text == "" || txtbAdd.Text == "" || txtbConNum.Text == "" || txtbEmail.Text == "" || dtpBirthD.Text == "" || txtbAge.Text == "" || cbGender.Text == "" || cbMarital.Text == "")
            {
                MessageBox.Show("Please complete all the form");
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream();
                pbImageClient.Image.Save(memoryStream, pbImageClient.Image.RawFormat);
                byte[] a = memoryStream.GetBuffer();
                memoryStream.Close();

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Image", a);
                cmd.Parameters.AddWithValue("@jdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@Bdate", dtpBirthD.Value.Date);
                cmd.CommandText = "Insert into [PatientRecord] (PatientID, FName, MName, LName, Address, ContNum, EmailAdd, Birthdate, Age, Gender, MartialStat, Image, Status, DateAdded) values('" + txtbID.Text + "','" + txtbFName.Text + "','" + txtbMName.Text + "','" + txtbLName.Text + "','" + txtbAdd.Text + "','" + txtbConNum.Text + "','" + txtbEmail.Text + "', @Bdate ,'" + txtbAge.Text + "','" + cbGender.Text + "','" + cbMarital.Text + "', @image ,'" + cbStat.Text + "', @jdate)";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = "Insert into [PatientRecordDentHis] (PatientID, Occlusion, PeriodonCon, OralHygn, Abnormali, DentUpp, DentLow) values ('" + txtbID.Text + "','" + txtbOcclusion.Text + "','" + txtbPerCondi.Text + "','" + txtbOralHyg.Text + "','" + txtAbnor.Text + "','" + txtbSUpper.Text + "','" + txtbSLower.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = "Insert into [PatientRecordMediHis] (PatientID, GenCondi, NatureTreat, Allergies, ChroAilments, BloodPress) values ('" + txtbID.Text + "','" + txtGCondi.Text + "','" + txtbNatTreat.Text + "','" + txtbAllerg.Text + "','" + txtbChronicA.Text + "','" + txtbBloodP.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Added");
                Clear();
            }
        }

        private void cbUpper_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDen();
        }

        private void cbLower_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDen();
        }
    }
}
