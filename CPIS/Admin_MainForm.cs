using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPIS
{
    public partial class Admin_MainForm : Form
    {
        public Admin_MainForm()
        {
            InitializeComponent();
            Date_Time.Start();
            sidePanelShow(true, false, false, false, false, false, false, false);
        }

        public Point mouseLocation;

        //method
        void sidePanel (int sp1,int sp2)
        {
            SidePanel.Height = sp1;
            SidePanel.Top = sp2;
        }

        void sidePanelShow (bool sps1, bool sps2, bool sps3, bool sps4, bool sps5, bool sps6, bool sps7, bool sps8)
        {
            admin_Dashboard1.Visible = sps1;
            admin_PatientList1.Visible = sps2;
            admin_Billing1.Visible = sps3;
            admin_Services1.Visible = sps4;
            admin_UserAcc1.Visible = sps5;
            admin_Report1.Visible = sps6;
            admin_UserLog1.Visible = sps7;
            admin_AdultFullTeethCharting1.Visible = sps8;
        }

        private void btAdmin_Dash_Click(object sender, EventArgs e)
        {
            sidePanel(btAdmin_Dash.Height,btAdmin_Dash.Top);
            sidePanelShow(true, false, false, false, false, false, false, false);
        }

        private void btAdmin_PatientL_Click(object sender, EventArgs e)
        {
            sidePanel(btAdmin_PatientL.Height, btAdmin_PatientL.Top);
            sidePanelShow(false, true, false, false, false, false, false, false);
            admin_PatientList1.BringToFront();
        }

        private void btAdmin_Billing_Click(object sender, EventArgs e)
        {
            sidePanel(btAdmin_Billing.Height, btAdmin_Billing.Top);
            sidePanelShow(false, false, true, false, false, false, false, false);
        }

        private void btAdmin_Services_Click(object sender, EventArgs e)
        {
            sidePanel(btAdmin_Services.Height, btAdmin_Services.Top);
            sidePanelShow(false, false, false, true, false, false, false, false);
        }

        private void btAdmin_Charting_Click(object sender, EventArgs e)
        {
            sidePanel(btAdmin_Charting.Height, btAdmin_Charting.Top);
            sidePanelShow(false, false, false, false, false, false, false, true);
        }

        private void btAdmin_UserAcc_Click(object sender, EventArgs e)
        {
            sidePanel(btAdmin_UserAcc.Height, btAdmin_UserAcc.Top);
            sidePanelShow(false, false, false, false, true, false, false, false);
        }

        private void btAdmin_Sales_Click(object sender, EventArgs e)
        {
            sidePanel(btAdmin_Report.Height, btAdmin_Report.Top);
            sidePanelShow(false, false, false, false, false, true, false, false);
        }

        private void btAdmin_UserLog_Click(object sender, EventArgs e)
        {
            sidePanel(btAdmin_UserLog.Height, btAdmin_UserLog.Top);
            sidePanelShow(false, false, false, false, false, false, true, false);
        }

        private void Date_Time_Tick(object sender, EventArgs e)
        {
            DateTime datetimeObject = DateTime.Now;
            dateTime.Text = datetimeObject.ToString("dddd, MMMM dd, yyyy | hh:mm:ss tt");
        }

        private void Admin_MainForm_Load(object sender, EventArgs e)
        {
            dateTime.Text = DateTime.Now.ToString();
        }

        private void lmcClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void ptitleBar_MouseMove(object sender, MouseEventArgs e)
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
