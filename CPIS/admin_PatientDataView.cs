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
    public partial class admin_PatientDataView : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");
        public admin_PatientDataView()
        {
            InitializeComponent();
            Edit(false, false, true, false);
        }

        //method
        void Edit(bool e1,bool e2,bool e3, bool e4)
        {
            groupBox2.Enabled = e1;
            tabPage1.Enabled = e2;
            tabPage2.Enabled = e2;
            bt_Edit.Visible = e3;
            bt_Save.Visible = e4;
            txtbID.Enabled = false;
        }

        void ChartTreatSeries()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_CharTreatCode", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            admin_AdultUpperCharting1.txtCharNo.Text = dt.Rows[0][0].ToString();
        }

        private void ManipulateData(String mData,String mData2)
        {
            //MemoryStream memoryStream = new MemoryStream();
            //pbImageP.Image.Save(memoryStream, pbImageP.Image.RawFormat);
            //byte[] a = memoryStream.GetBuffer();
            //memoryStream.Close();

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = mData;
            //cmd.Parameters.AddWithValue("@Image", a);
            cmd.ExecuteNonQuery();
            cmd.CommandText = mData2;
            cmd.ExecuteNonQuery();
            //cmd.CommandText = mData3;
            //cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void dataGetPatientInfo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From [PatientRecord] where PatientID = '" + txtbID.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbFName.Text = (dr["FName"].ToString());
                txtbMName.Text = (dr["MName"].ToString());
                txtbLName.Text = (dr["LName"].ToString());
                txtbAdd.Text = (dr["Address"].ToString());
                txtbConNum.Text = (dr["ContNum"].ToString());
                txtbEmail.Text = (dr["EmailAdd"].ToString());
                dtpBirthD.Text = (dr["Birthdate"].ToString());
                txtbAge.Text = (dr["Age"].ToString());
                cbGender.Text = (dr["Gender"].ToString());
                cbMarital.Text = (dr["MartialStat"].ToString());
                cbStat.Text = (dr["Status"].ToString());
            }
            conn.Close();
        }

        public void dataGetMedicalInfo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From [PatientRecordMediHis] where PatientID = '" + txtbID.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtGCondi.Text = (dr["GenCondi"].ToString());
                txtbNatTreat.Text = (dr["NatureTreat"].ToString());
                txtbAllerg.Text = (dr["Allergies"].ToString());
                txtbChronicA.Text = (dr["ChroAilments"].ToString());
                txtbBloodP.Text = (dr["BloodPress"].ToString());
            }
            conn.Close();
        }

        public void dataGetDentalInfo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From [PatientRecordDentHis] where PatientID = '" + txtbID.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbOcclusion.Text = (dr["Occlusion"].ToString());
                txtbPerCondi.Text = (dr["PeriodonCon"].ToString());
                txtbOralHyg.Text = (dr["OralHygn"].ToString());
                txtAbnor.Text = (dr["Abnormali"].ToString());
                txtbSUpper.Text = (dr["DentUpp"].ToString());
                txtbSLower.Text = (dr["DentLow"].ToString());
            }
            conn.Close();
        }

        public void loadPicture()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Image From [PatientRecord] where  PatientID = '" + txtbID.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cbd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["Image"]);
            MemoryStream ms = new MemoryStream(ap);
            pbImageP.Image = Image.FromStream(ms);
            pbImageP.SizeMode = PictureBoxSizeMode.StretchImage;
            ms.Close();
        }

        private void bt_Charting_Click(object sender, EventArgs e)
        {
            ChartTreatSeries();
            admin_AdultUpperCharting1.Visible = true;
            groupBox1.Visible = false;
            admin_AdultUpperCharting1.txtbID.Text = txtbID.Text;
            admin_AdultUpperCharting1.bt_Billing.Enabled = true;
            admin_AdultUpperCharting1.plLowerTeeth.Enabled = true;
            admin_AdultUpperCharting1.plUpperTeeth.Enabled = true;
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            Edit(true, true, false, true);
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            ManipulateData("Update [PatientRecord] set FName = '" + txtbFName.Text + "', MName = '" + txtbMName.Text + "', LName = '" + txtbLName.Text + "', Address = '" + txtbAdd.Text + "', ContNum = '" + txtbConNum.Text + "', EmailAdd = '" + txtbEmail.Text + "', Birthdate = '" + dtpBirthD.Text + "', Age = '" + txtbAge.Text + "', Gender = '" + cbGender.Text + "', MartialStat = '" + cbMarital.Text + "', Status = '" + cbStat.Text + "' where PatientID = '" + txtbID.Text + "'", "Update [PatientRecordDentHis] set PatientID = '" + txtbID.Text + "', Occlusion = '" + txtbOcclusion.Text + "', PeriodonCon = '" + txtbPerCondi.Text + "', OralHygn = '" + txtbOralHyg.Text + "',  Abnormali ='" + txtAbnor.Text + "', DentUpp = '" + txtbSUpper.Text + "', DentLow = '" + txtbSLower.Text + "' where PatientID = '" + txtbID.Text + "'");
            Edit(false, false, true, false);

        }
    }
}
