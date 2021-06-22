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

namespace CPIS
{
    public partial class admin_PatientList : UserControl
    {

        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");

        public admin_PatientList()
        {
            InitializeComponent();
            listLoadData("Select * from PatientRecord");
            patientInfoShow(false, false, true, false);
            txtbID.Enabled = false;


            btView.Enabled = false;
            btDelete.Enabled = false;
        }

        //method

        void patientInfoShow(bool addPatient, bool viewPatient, bool patientList, bool backpb)
        {
            admin_AddPatient2.Visible = addPatient;
            admin_PatientDataView2.Visible = viewPatient;
            gbPatientList.Visible = patientList;
            pbBack.Visible = backpb;
        }

        //public void dataGetPatientInfo()
        //{
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("Select a.BillingNo, b.PaymentNo from [BillingTrans] a inner join [CharTreatAdult] c on c.CharTreatNo=a.CharTreatNo inner join [FullPay] b on b.BillingNo=a.BillingNo inner join [PatientRecornd] d on d.PatientID=c.PatientID where d.PatientID='" + txtbID.Text + "'", conn);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        txtBill.Text = (dr["a.BillingNo"].ToString());
        //    }
        //    conn.Close();
        //}

        void data_deletion()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "Delete from [Installment] where exists (Select a.PaymentNo from [Payment] a inner join [BillingTrans] b on a.BillingNo=b.BillingNo inner join [CharTreatAdult] c on b.CharTreatNo=c.CharTreatNo where c.PatientId = '" + txtbID.Text + "')";
                //cmd.ExecuteNonQuery();
                //cmd.CommandText = "Delete from [FullPay] where exists (Select a.PaymentNo from [Payment] a inner join [BillingTrans] b on a.BillingNo=b.BillingNo inner join [CharTreatAdult] c on b.CharTreatNo=c.CharTreatNo where c.PatientId = '" + txtbID.Text + "')";
                //cmd.ExecuteNonQuery();
                //cmd.CommandText = "Delete from [Payment] where exists (Select BillingNo from [CharTreatAdult] where PatientId = '" + txtbID.Text + "')";
                //cmd.ExecuteNonQuery();
                //cmd.CommandText = "Delete from [BillingTrans] where exists (Select CharTreatNo from [CharTreatAdult] where PatientId = '" + txtbID.Text + "')";
                //cmd.ExecuteNonQuery();
                //cmd.CommandText = " Delete from [CharTreatAdult] where PatientId = '" + txtbID.Text + "' ";
                //cmd.ExecuteNonQuery();
                cmd.CommandText = "Delete from [PatientRecordMediHis] where PatientId = '" + txtbID.Text + "' ";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Delete from [PatientRecordDentHis] where PatientId = '" + txtbID.Text + "' ";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Delete from [PatientRecord] where PatientId = '" + txtbID.Text + "' ";
                cmd.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("ERROR! Please delete a existing Transaction", "Warning!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

       public void listLoadData(string q)
        {
            listView1.Items.Clear();
            try
            {
                listView1.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = q;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr["PatientID"].ToString());
                        item.SubItems.Add(dr["FName"].ToString() + " " + dr["MName"].ToString() + " " + dr["LName"].ToString());
                        item.SubItems.Add(dr["ContNum"].ToString());
                        item.SubItems.Add(dr["EmailAdd"].ToString());
                        item.SubItems.Add(dr["Age"].ToString());
                        item.SubItems.Add(dr["Birthdate"].ToString());
                        item.SubItems.Add(dr["Status"].ToString());
                        listView1.Items.Add(item);
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                
            }

            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            patientInfoShow(true, false, false, true);
            pbBack.BringToFront();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            admin_PatientDataView2.txtbID.Text = txtbID.Text;
            admin_PatientDataView2.dataGetPatientInfo();
            admin_PatientDataView2.dataGetMedicalInfo();
            admin_PatientDataView2.dataGetDentalInfo();
            admin_PatientDataView2.loadPicture();
            patientInfoShow(false, true, false, true);
            pbBack.BringToFront();
            btView.Enabled = false;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            listLoadData("Select * from PatientRecord");
            patientInfoShow(false, false, true, false);
            txtbID.Text = "";
            btView.Enabled = false;
            btDelete.Enabled = false;
            admin_PatientDataView2.groupBox1.Visible = true;
            admin_PatientDataView2.admin_AdultUpperCharting1.Visible = false;
            admin_AdultUpperCharting adAUC = new admin_AdultUpperCharting();
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            listLoadData("select * from PatientRecord where fname like '%" + txtbSearch.Text + "%' or mname like '%" + txtbSearch.Text + "%' or lname like '%" + txtbSearch.Text + "%' ");
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                btView.Enabled = true;
                btDelete.Enabled = true;
                btNewP.Enabled = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtbID.Text = listView1.SelectedItems[0].Text;
            }
        }

        private void listView1_Leave(object sender, EventArgs e)
        {
            btNewP.Enabled = true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to continue!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dialogResult == DialogResult.Yes)
            {
                data_deletion();
                MessageBox.Show("Record Delete");
            }
            else
            {
                MessageBox.Show("Record Deleted Fail");
            }

            listLoadData("Select * from PatientRecord");
            txtbID.Text = "";
            btView.Enabled = false;
            btDelete.Enabled = false;
            btNewP.Enabled = true;
        }
    }
}
