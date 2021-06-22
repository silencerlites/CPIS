using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormCharpWebCam;
using Emgu.CV;
using Emgu.CV.Structure;



namespace CPIS
{
    public partial class admin_CaptureImage : Form
    {

        WebCam webCam = new WebCam();
        VideoCapture cap;


        public admin_CaptureImage()
        {
            InitializeComponent();
            EmgustartCam();
            //WebcamStartCam();
        }

        void WebcamStartCam()
        {
            webCam.InitializeWebCam(ref pbCaptureProcess);
            webCam.Start();
        }

        void EmgustartCam()
        {
            if (cap == null)
            {
                cap = new Emgu.CV.VideoCapture(0);
            }
            cap.ImageGrabbed += Cap_ImageGrabbed;
            cap.Start();
        }

        private void Cap_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                cap.Retrieve(m);
                pbCaptureProcess.Image = m.ToImage<Bgr, byte>().Bitmap;
                
                
            }
            catch (Exception)
            {

            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            pbCaptureProcess.Image = pictureBox2.Image;
        }
    }
}
