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
    public partial class admin_UserAcc : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");
        
        public admin_UserAcc()
        {
            InitializeComponent();
            txtbPass.UseSystemPasswordChar = true;
            loadData("Select * from [CPIS_UserAcc]");
            enableFunc(false,true,false);
        }

        //method
        void enableFunc (bool enableInfo, bool enableEdit, bool enableSave)
        {
            txtbID.Enabled = false;
            txtbFName.Enabled = txtbLName.Enabled = txtbAdd.Enabled = txtbConNum.Enabled = txtbEmail.Enabled = txtbUserN.Enabled = txtbPass.Enabled = cbUserType.Enabled = pbShow_Pass.Enabled = enableInfo;
            bt_Edit.Enabled = enableEdit;
            btSave.Enabled = enableSave;
        }

        void clear()
        {
            txtbID.Text = txtbID.Text = txtbFName.Text = txtbLName.Text = txtbAdd.Text = txtbConNum.Text = txtbEmail.Text = txtbUserN.Text = txtbPass.Text = cbUserType.Text = "";
        }

        private void ManipulateData(String mData)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = mData;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void loadData(string query)
        {
            lvUserView.Items.Clear();
            try
            {
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["FName"].ToString());
                        item.SubItems.Add(dr["LName"].ToString());
                        item.SubItems.Add(dr["AccType"].ToString());
                        item.SubItems.Add(dr["Address"].ToString());
                        item.SubItems.Add(dr["MobileN"].ToString());
                        item.SubItems.Add(dr["Email"].ToString());
                        item.SubItems.Add(dr["UserName"].ToString());
                        item.SubItems.Add(dr["Password"].ToString());
                        item.SubItems.Add(dr["UserAcc_ID"].ToString());
                        lvUserView.Items.Add(item);
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

        //function
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            enableFunc(true, false, true);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ManipulateData("Update [CPIS_UserAcc] set Fname ='"+txtbFName.Text+"', LName='"+txtbLName.Text+"', Address='"+txtbAdd.Text+"', MobileN='"+txtbConNum.Text+"', Email='"+txtbEmail.Text+"', UserName='"+txtbUserN.Text+"', Password='"+txtbPass.Text+"', AccType='"+cbUserType.Text+"' where UserAcc_ID = '"+txtbID.Text+"'");
            clear();
            enableFunc(false, true, false);
            loadData("Select * from [CPIS_UserAcc]");
        }

        private void lvUserView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUserView.SelectedItems.Count > 0)
            {
                txtbFName.Text = lvUserView.SelectedItems[0].Text;
                txtbLName.Text = lvUserView.SelectedItems[0].SubItems[1].Text;
                cbUserType.Text = lvUserView.SelectedItems[0].SubItems[2].Text;
                txtbAdd.Text = lvUserView.SelectedItems[0].SubItems[3].Text;
                txtbConNum.Text = lvUserView.SelectedItems[0].SubItems[4].Text;
                txtbEmail.Text = lvUserView.SelectedItems[0].SubItems[5].Text;
                txtbUserN.Text = lvUserView.SelectedItems[0].SubItems[6].Text;
                txtbPass.Text = lvUserView.SelectedItems[0].SubItems[7].Text;
                txtbID.Text = lvUserView.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            loadData("Select * from [CPIS_UserAcc] where FName like '%" + txtbSearch.Text + "%' or UserName like '%" + txtbSearch.Text + "%'");
        }

        private void pbShow_Pass_Click(object sender, EventArgs e)
        {
            if (txtbPass.UseSystemPasswordChar == true)
            {
                txtbPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtbPass.UseSystemPasswordChar = true;
            }
        }
    }
}
