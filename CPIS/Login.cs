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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtbPassLog.UseSystemPasswordChar = true;
        }

        static int attempt = 3;
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");
        public Point mouseLocation;
        public string accType;

        private void panelDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        //text placeholder
        private void txtbUserNLog_Enter(object sender, EventArgs e)
        {
            if (txtbUserNLog.Text == "username")
            {
                txtbUserNLog.Text = "";
                txtbUserNLog.ForeColor = Color.DimGray;
            }
        }

        private void txtbUserNLog_Leave(object sender, EventArgs e)
        {
            if (txtbUserNLog.Text == "")
            {
                txtbUserNLog.Text = "username";
                txtbUserNLog.ForeColor = Color.DarkGray;
            }
        }

        private void txtbPassLog_Enter(object sender, EventArgs e)
        {
            if (txtbPassLog.Text == "password")
            {
                txtbPassLog.Text = "";
                txtbPassLog.ForeColor = Color.DimGray;
            }
        }

        private void txtbPassLog_Leave(object sender, EventArgs e)
        {
            if (txtbPassLog.Text == "")
            {
                txtbPassLog.Text = "password";
                txtbPassLog.ForeColor = Color.DarkGray;
            }
        }

        private void lmcMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lmcClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
                label2.Text = ("*LOGIN FAILED - PLEASE CONTACT ADMIN");
                return;
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from [CPIS_UserAcc] where UserName = @usr and Password = @pwd",conn);
            cmd.Parameters.AddWithValue("@usr", txtbUserNLog.Text);
            cmd.Parameters.AddWithValue("@pwd", txtbPassLog.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
         
                if (dt.Rows.Count > 0)
                {
                    accType = dt.Rows[0]["AccType"].ToString().Trim();
                    if (accType == "Administrator")
                    {
                        MessageBox.Show("admin");
                        Clear();
                        Admin_MainForm adMain = new Admin_MainForm();
                        adMain.Show();
                        this.Hide();
                        adMain.label3.Text = "Welcome, " + dt.Rows[0][1].ToString() + "";
                }
                    else if (accType == "Assistant")
                    {

                    }
                    else if (accType == "Dentist")
                    {

                    }
                }
            else
            {
                lbl_Msg.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try!");
                --attempt;
                txtbUserNLog.Clear();
                txtbPassLog.Clear();
                txtbUserNLog.Focus();
            }
            conn.Close();
        }

        void Clear()
        {
            txtbUserNLog.Text = txtbPassLog.Text = "";
        }

        private void llNewAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_UserAccount accN = new Add_UserAccount();
            accN.Show();
            this.Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_ShowPass_Click(object sender, EventArgs e)
        {
            if(txtbPassLog.UseSystemPasswordChar == true)
            {
                txtbPassLog.UseSystemPasswordChar = false;
            }
            else
            {
                txtbPassLog.UseSystemPasswordChar = true;
            }
        }
    }
}
