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
    public partial class admin_ServicesList : UserControl
    {
        public admin_ServicesList()
        {
            InitializeComponent();
            CategoryList();
            ServListloadData("Select a.Treat_Code, a.Description, b.Cat_Description, a.Amount from [ServTreat_List] a inner join [Category_Serv_Treat] b on a.CategoryID=b.CategoryID");
            bDisable(true, false, false, false, false);
        }

        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");

        void Clear()
        {
            txtbTreatCode.Text = txtbDescription.Text = txtCatergID.Text = txtbAmount.Text = "";
        }

        void data_deletion(String dl1)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = dl1;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        void bDisable(bool bD1, bool bD2, bool bD3, bool bD4, bool bD5)
        {
            btAdd.Enabled = bD1;
            bt_Edit.Enabled = bD2;
            btDelete.Enabled = bD3;
            bt_Save.Enabled = bD4;
            groupBox2.Enabled = bD5;
        }

        void CategoryList()
        {
            SqlCommand cmd = new SqlCommand("Select * from [Category_Serv_Treat]", conn);
            SqlDataReader myRead;
            try
            {
                conn.Open();
                myRead = cmd.ExecuteReader();
                while (myRead.Read())
                {
                    string Description = myRead.GetString(1);
                    cbCategoryList.Items.Add(Description);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ServListloadData(string query)
        {
            lvServiceList.Items.Clear();
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
                        ListViewItem item = new ListViewItem(dr["Treat_Code"].ToString());
                        item.SubItems.Add(dr["Description"].ToString());
                        item.SubItems.Add(dr["Cat_Description"].ToString());
                        item.SubItems.Add(dr["Amount"].ToString());
                        lvServiceList.Items.Add(item);
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
            admin_ServicesItemAdd servAdd = new admin_ServicesItemAdd();
            servAdd.Show();
        }

        private void lvServiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvServiceList.SelectedItems.Count > 0)
            {
                txtbTreatCode.Text = lvServiceList.SelectedItems[0].Text;
                txtbDescription.Text = lvServiceList.SelectedItems[0].SubItems[1].Text;
                cbCategoryList.Text = lvServiceList.SelectedItems[0].SubItems[2].Text;
                txtbAmount.Text = lvServiceList.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void cbCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from [Category_Serv_Treat]", conn);
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            data_deletion("Delete from [ServTreat_List] where Treat_Code ='"+txtbTreatCode.Text+"' ");
            ServListloadData("Select a.Treat_Code, a.Description, b.Cat_Description, a.Amount from [ServTreat_List] a inner join [Category_Serv_Treat] b on a.CategoryID=b.CategoryID");
            bDisable(true, false, false, false, false);
        }

        private void lvServiceList_Click(object sender, EventArgs e)
        {
            bDisable(false, true, true, false, false);
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            bDisable(false, false, false, true, true);
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            bDisable(true, false, false, false, false);
            ServListloadData("Select a.Treat_Code, a.Description, b.Cat_Description, a.Amount from [ServTreat_List] a inner join [Category_Serv_Treat] b on a.CategoryID=b.CategoryID");
            Clear();
        }
    }
}
