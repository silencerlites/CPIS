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
    public partial class admin_AdultUpperCharting : UserControl
    {
        public admin_AdultUpperCharting()
        {
            InitializeComponent();
            string query = "select CategoryID, Cat_Description from Category_Serv_Treat";
            fillCombo(cbCategoryList, query, "Cat_Description", "CategoryID"); 
            cbCategoryList_SelectedIndexChanged(null,null);
            disable(false, false, false, false, false, false);
            btGoToLow.BringToFront();
            buttonHide(false, false, true, true);
            listLoadData();
        }

       // Admin_MainForm adMain = new Admin_MainForm();
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");
        admin_BillingStatement bl = new admin_BillingStatement();

        void fetchData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from [PatientRecord] where PatientID = @patID ", conn);
            cmd.Parameters.AddWithValue("@patID", txtbID.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                bl.txtbPatientN.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][3].ToString();
                bl.txtbAddress.Text = dt.Rows[0][4].ToString();

                DateTime datetimeObject = DateTime.Now;
                bl.txtIssuedDate.Text = datetimeObject.ToString("MM/dd/yyyy");
            }

            conn.Close();
        }

        void BillingSeries()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Billing", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bl.txtbBillNo.Text = dt.Rows[0][0].ToString();
        }

        void buttonHide(bool bh1,bool bh2, bool bh3, bool bh4)
        {
            bt_Edit.Visible = bh1;
            btSave.Visible = bh2;
            btAdd.Visible = bh3;
            btDelete.Visible = bh4;
        }

        void listLoadData()
        {
            listView1.Items.Clear();
            try
            {
                listView1.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select a.ToothNo, b.Description from [ServTreat_List] b inner join [CharTreatAdult] c on c.Treat_Code=b.Treat_Code inner join [ChartingTeethAdult] a on a.ToothNo = c.ToothNo where c.CharTreatNo = '"+txtCharNo.Text+ "' and c.PatientID = '"+txtbID.Text+"'";
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr["ToothNo"].ToString());
                        item.SubItems.Add(dr["Description"].ToString());
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

        void showPanel(bool sp1, bool sp2, bool sp3, bool sp4)
        {
            plUpperTeeth.Visible = sp1;
            plLowerTeeth.Visible = sp2;
            btGoToLow.Visible = sp3;
            btGoToUp.Visible = sp4;
        }

        void data_manipulate(String dl1)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = dl1;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            combo.DataSource = tb;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        void ToothInsert(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbTootNo.Text = (dr["ToothNo"].ToString());
            }
            conn.Close();
        }

        void disable(bool ds1, bool ds2, bool ds3,bool ds4,bool ds5,bool ds6)
        {
            groupBox1.Enabled = ds1;
            groupBox2.Enabled = ds2;
            bt_Edit.Enabled = ds3;
            btAdd.Enabled = ds4;
            btDelete.Enabled = ds5;
            btSave.Enabled = ds6;
            txtbID.Enabled = false;
            txtCharNo.Enabled = false;
        }

        void clear()
        {
            txtbTootNo.Text = "";
           // cbCategoryList.SelectedIndex = -1;
            //cbTreatment.SelectedIndex = -1;
        }

        void DetailClear()
        {
            txtCharNo.Text = "";
        }

        private void btGoToUp_Click(object sender, EventArgs e)
        {
            showPanel(true, false, true, false);
        }

        private void btGoToLow_Click(object sender, EventArgs e)
        {
            showPanel(false, true, false, true);
        }

        private void pbTooth1_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 1");
            disable(false, true, false, true, false,false);
        }

        private void pbTooth2_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 2");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth3_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 3");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth4_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 4");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth5_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 5");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth6_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 6");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth7_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 7");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth8_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 8");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth9_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 9");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth10_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 10");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth11_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 11");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth12_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 12");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth13_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 13");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth14_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 14");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth15_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 15");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth16_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 16");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth17_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 17");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth18_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 18");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth19_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 19");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth20_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 20");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth21_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 21");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth22_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 22");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth23_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 23");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth24_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 24");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth25_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 25");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth26_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 26");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth27_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 27");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth28_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 28");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth29_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 29");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth30_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 30");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth31_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 31");
            disable(false, true, false, true, false, false);
        }

        private void pbTooth32_Click(object sender, EventArgs e)
        {
            ToothInsert("select * from ChartingTeethAdult where ToothNo = 32");
            disable(false, true, false, true, false, false);
        }

        private void cbCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Treat_Code, Description, CategoryID from [ServTreat_List] where CategoryID = @CID", conn);
            cmd.Parameters.AddWithValue("@CID", cbCategoryList.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            cbTreatment.DataSource = tb;
            cbTreatment.DisplayMember = "Description";
            cbTreatment.ValueMember = "Treat_Code";
        }

        private void cbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from [ServTreat_List] where Description='" + cbTreatment.Text + "'", conn);
            SqlDataReader myRead;
            try
            {
                conn.Open();
                myRead = cmd.ExecuteReader();
                while (myRead.Read())
                {
                    string Treat_Code = myRead.GetString(0);
                    txtTreatCode.Text = Treat_Code;
                    string Description = myRead.GetString(1);
                    txbDescription.Text = Description;
                    int Amount = myRead.GetInt32(3);
                    txtbAmount.Text = Amount.ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            data_manipulate("Insert into [CharTreatAdult] (CharTreatNo,PatientID,ToothNo,Treat_Code) values ('" + txtCharNo.Text + "','" + txtbID.Text + "','" + txtbTootNo.Text + "','" + txtTreatCode.Text + "')");
            clear();
            disable(false, false, false, false, false, false);
            listLoadData();
        }

        private void txtCharNo_TextChanged(object sender, EventArgs e)
        {
            listLoadData();
        }

        private void bt_Billing_Click(object sender, EventArgs e)
        {
            BillingSeries();
            fetchData();
            bl.txtCharNo.Text = txtCharNo.Text;
            data_manipulate("Insert into [BillingTrans] (BillingNo,CharTreatNo,Date,Amount) values ('" + bl.txtbBillNo.Text + "','" + txtCharNo.Text + "','" + bl.txtIssuedDate.Text + "','" + bl.txtTotal.Text + "')");
            bl.Show();
            DetailClear();
            bt_Billing.Enabled = false;
            bl.bt_Payment.Enabled = true;
            plUpperTeeth.Enabled = false;
            plLowerTeeth.Enabled = false;
            
        }
    }
}
