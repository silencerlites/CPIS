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
    public partial class admin_Payment : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");

        public admin_Payment()
        {
            InitializeComponent();
            cpVisible(false, false, false, true, true);
            cbDiscount.SelectedIndex = 0;
        }

        string PaymentTerm;

        void data_manipulate(String dl1)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = dl1;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        void Discount(TextBox d1)
        {
            int total = int.Parse(textBox1.Text);
            double alltotal = 0;

#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (cbDiscount.SelectedItem == "PWD")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                alltotal = total - ((total * 20) / 100);
            }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            else if (cbDiscount.SelectedItem == "Senior Citizen")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                alltotal = total - ((total * 20) / 100);
            }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            else if (cbDiscount.SelectedItem == "No Discount")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                alltotal = total - ((total * 0) / 100);
            }
            d1.Text = Convert.ToString(alltotal);

        }
        
        public void cpVisible(bool ok,bool grp1,bool grp2,bool full,bool ins)
        {
            bt_OK.Visible = ok;
            groupBox1.Visible = grp1;
            groupBox2.Visible = grp2;
            bt_FullPay.Visible = full;
            bt_Instal.Visible = ins;
        }

        private void bt_FullPay_Click(object sender, EventArgs e)
        {
            lbStat.Text = "Paid";
            Discount(txtbFullAmount);
            cbDiscount.Enabled = false;
            if  (this.Height == 344 &  this.Width == 441) 
            {
                cpVisible(true, false, true, false, false);
                Point fullP = new Point(181, 426);
                this.Height = 474;
                this.Width = 441; 
                Button b = (Button)sender;
                b = bt_OK;
                b.Location = fullP;
            } else {
                this.Height = 344; 
                this.Width = 441;
            }
        }

        private void bt_Instal_Click(object sender, EventArgs e)
        {
            lbStat.Text = "Unpaid";
            Discount(txtInstalAmount);
            dtpDueDate.Value = dtpDueDate.Value.AddDays(15);
            cbDiscount.Enabled = false;
            if (this.Height == 344 & this.Width == 441)
            {
                cpVisible(true, true, false, false, false);
                Point fullP = new Point(181, 592);
                this.Height = 640; 
                this.Width = 441;
                Button b = (Button)sender;
                b = bt_OK;
                b.Location = fullP;
            }
            else
            {
                this.Height = 344;
                this.Width = 441;
            }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            data_manipulate("Insert Into [Payment] (PaymentNo,BillingNo,Discount,PaymentTerms,Date,Status) values ('" + txtbPayNo.Text + "','" + lbBillNo.Text + "','" + cbDiscount.Text + "','" + PaymentTerm + "','" + DateTime.Now + "','" + lbStat.Text + "')");

            if (lbStat.Text == "Paid")
            {
                data_manipulate("Insert into [FullPay] (PaymentNo,AmountPaid,OR_No) values ('" + txtbPayNo.Text + "','" + txtbFullAmount.Text + "','" + txtbAmount.Text + "')");
            }
            else if (lbStat.Text == "Unpaid")
            {
                data_manipulate("Insert into [Installment](PaymentNo,AmountPaid,RemainingBal,OR_No,DueDate) values ('" + txtbPayNo.Text + "','" + txtCash.Text + "','" + txtRemain.Text + "','" + txtORInst.Text + "','" + dtpDueDate.Text + "')");
            }
            this.Visible = false;
            cbDiscount.Enabled = true;
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtCash.Text);
                int num2 = int.Parse(txtInstalAmount.Text);

                if (num2 > 0)
                {
                    double amount = num2 - num1;
                    txtRemain.Text = Convert.ToString(amount);
                }
            }
            catch (Exception)
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PaymentTerm = "Cash";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PaymentTerm = "Check";
        }
    }
}
