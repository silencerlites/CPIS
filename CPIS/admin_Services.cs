using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPIS
{
    public partial class admin_Services : UserControl
    {
        public admin_Services()
        {
            InitializeComponent();
            ServPanelShow(false, true, false);

        }

        void ServPanelShow(bool sps1, bool sps2, bool sps3)
        {
            admin_ServicesList1.Visible = sps1;
            gbService.Visible = sps2;
            pbBack.Visible = sps3;
        }

        private void btView_Click(object sender, EventArgs e)
        {
            ServPanelShow(true, false,true);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            ServPanelShow(false, true, false);
            admin_ServicesList1.ServListloadData("Select a.Treat_Code, a.Description, b.Cat_Description, a.Amount from [ServTreat_List] a inner join [Category_Serv_Treat] b on a.CategoryID=b.CategoryID");

        }
    }
}
