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
    public partial class admin_Dashboard : UserControl
    {
        public admin_Dashboard()
        {
            InitializeComponent();
            lbdateMonth.Text = DateTime.Now.ToString("MMMM yyyy");
        }


    }
}
