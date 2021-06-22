using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CPIS
{
    public partial class admin_ServicesItemAdd : Form
    {
        public admin_ServicesItemAdd()
        {
            InitializeComponent();
            CategoryList();
            txtCatergID.Enabled = false;
        }

        public Point mouseLocation;
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");
        admin_ServicesList aSL = new admin_ServicesList();

        //method
        void CategoryList()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("Select CategoryID,Cat_Description from [Category_Serv_Treat]", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cbCategoryList.DisplayMember = "Cat_Description";
                cbCategoryList.ValueMember = "CategoryID";
                cbCategoryList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        void Clear()
        {
            txtTreatCode.Text = txtbAmount.Text = txtbDescription.Text = "";
        }

        void TreatCode_Series()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_TreatCode", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtTreatCode.Text = dt.Rows[0][0].ToString();
        }

        private void cbCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from [Category_Serv_Treat] where Cat_Description='" + cbCategoryList.Text + "'", conn);
            SqlDataReader myRead;
            try
            {
                conn.Open();
                myRead = cmd.ExecuteReader();
                while (myRead.Read())
                {
                    string CategoryID = myRead.GetString(0);
                    txtCatergID.Text = CategoryID;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ptitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void ptitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void lmcClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            TreatCode_Series();
            if (txtbDescription.Text == "" || txtbAmount.Text == "")
            {
                MessageBox.Show("Please complete all the form");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dateA", DateTime.Now);
                cmd.CommandText = "Insert into [ServTreat_List] (Treat_Code,Description,CategoryID,Amount,DateAdded) values ('" + txtTreatCode.Text + "','" + txtbDescription.Text + "','" + txtCatergID.Text + "','" + txtbAmount.Text + "',@dateA)";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Added");
            }
            Clear();
        }

    }
}
