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
    public partial class admin_BillingStatement : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");

        public admin_BillingStatement()
        {
            InitializeComponent();
            listLoadData();
            sumTotal();
            admin_Payment1.Visible = false;
        }
        public Point mouseLocation;

        void PaymentSeries()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Proc_New_Payment", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            admin_Payment1.txtbPayNo.Text = dt.Rows[0][0].ToString();
        }
        void sumTotal()
        {
            try
            {
                float sum = 0;
                foreach (ListViewItem li in listView1.Items)
                {
                    sum += float.Parse(li.SubItems[2].Text);
                }
                txtTotal.Text = Convert.ToString(sum);
                txtbGTotal.Text = (int.Parse(txtTotal.Text) + int.Parse(txtbPBal.Text)).ToString();
            }
            catch
            {

            }
         
        }
       
        void listLoadData()
        {
            listView1.Items.Clear();
            try
            {
                listView1.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select a.ToothNo, b.Description, b.Amount from [ServTreat_List] b inner join [CharTreatAdult] c on c.Treat_Code=b.Treat_Code inner join [ChartingTeethAdult] a on a.ToothNo = c.ToothNo where c.CharTreatNo = '"+ txtCharNo.Text +"'";
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr["ToothNo"].ToString());
                        item.SubItems.Add(dr["Description"].ToString());
                        item.SubItems.Add(dr["Amount"].ToString());
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

        private void txtCharNo_TextChanged(object sender, EventArgs e)
        {
            listLoadData();
            sumTotal();
        }

        private void bt_Payment_Click(object sender, EventArgs e)
        {
            admin_Payment1.Visible = true;
            bt_Payment.Enabled = false;
            admin_Payment1.lbBillNo.Text = txtbBillNo.Text;
            admin_Payment1.lbName.Text = txtbPatientN.Text;
            admin_Payment1.textBox1.Text = txtTotal.Text;
            PaymentSeries();
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            admin_Payment1.cpVisible(false, false, false, true, true);
            admin_Payment1.Height = 344;
            admin_Payment1.Width = 441;
            this.Hide();
        }

        private void pb_letterhead_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pb_letterhead_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
