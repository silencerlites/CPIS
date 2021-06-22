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
    public partial class Add_UserAccount : Form
    {
        public Add_UserAccount()
        {
            InitializeComponent();

        }

        public Point mouseLocation;
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");

        private void pAccN_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void pAccN_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        //method
        void Clear()
        {
            txtbFName.Text = txtbLName.Text = txtbAdd.Text = txtbMobile.Text = txtbEmail.Text = txtbUserName.Text = txtbPass.Text = txtbCPass.Text = cbUserType.Text = "";
        }

        void PatientIDSeries()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_UserAccID", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtUserID.Text = dt.Rows[0][0].ToString();
        }

        private void add_data(String ad)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@dateA", DateTime.Now);
            cmd.CommandText = ad;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       
        private void btCancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            PatientIDSeries();
            add_data("Insert into [CPIS_UserAcc] (UserAcc_ID, Fname, Lname, Address, MobileN, Email, UserName, Password, AccType, DateAdded) values ('"+txtUserID.Text+"','"+txtbFName.Text+"','"+txtbLName.Text+"','"+txtbAdd.Text+"','"+txtbMobile.Text+"','"+txtbEmail.Text+"','"+txtbUserName.Text+"','"+txtbPass.Text+"','"+cbUserType.Text+"', @dateA)");
            MessageBox.Show("Record Added");
            Clear();
        }
    }
}
