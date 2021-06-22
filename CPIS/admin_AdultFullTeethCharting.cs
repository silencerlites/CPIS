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
    public partial class admin_AdultFullTeethCharting : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\iLites\\Documents\\Visual Studio 2017\\Projects\\CPIS\\CPIS\\db.CPIS.mdf;Integrated Security = True");

        public admin_AdultFullTeethCharting()
        {
            InitializeComponent();
            treeNode_PatientList();
        }

        void treeNode_PatientList()
        {

            TreeNode ParentNode;
            ParentNode = tvr_PatientList.Nodes.Add("List All Patient");
            ParentNode.Nodes.Add("*");

        }

        private void tvr_PatientList_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode nodeSelected, nodeChild;
            nodeSelected = tvr_PatientList.Nodes[0];
            nodeSelected.Nodes.Clear();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from [PatientRecord] ORDER BY FName ASC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nodeChild = nodeSelected.Nodes.Add(dr["FName"].ToString());
                    nodeChild.Tag = dr["PatientID"].ToString();
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

    }
    } 
