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
    public partial class admin_Billing : UserControl
    {
        public admin_Billing()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
            listLoadData();
        }

        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");

        void listLoadData()
        {
            listView2.Items.Clear();
            try
            {
                listView2.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select a.Date, a.BillingNo, f.FName, f.MName, f.LName, a.Amount, d.RemainingBal, c.Discount, c.Status from [CharTreatAdult] b inner join [BillingTrans] a on a.CharTreatNo = b.CharTreatNo inner join [PatientRecord] f on b.PatientID = f.PatientID inner join [Payment] c on c.BillingNo = a.BillingNo inner join [Installment] d on c.PaymentNo = d.PaymentNo";
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr["Date"].ToString());
                        item.SubItems.Add(dr["BillingNo"].ToString());
                        item.SubItems.Add(dr["FName"].ToString() + " " + dr["MName"].ToString() + " " + dr["LName"].ToString());
                        item.SubItems.Add(dr["AmountPaid"].ToString());
                        item.SubItems.Add(dr["RemainingBal"].ToString());
                        item.SubItems.Add(dr["Discount"].ToString());
                        item.SubItems.Add(dr["Status"].ToString());
                        listView2.Items.Add(item);
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

        private void admin_Billing_Load(object sender, EventArgs e)
        {
            listLoadData();
        }
    }
}
