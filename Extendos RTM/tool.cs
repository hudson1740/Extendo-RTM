using System;
using System.Windows.Forms;
using PS3Lib;
using PS3Lib.NET;
using System.Drawing;
using System.Net;


namespace Extendos_RTM
{
    public partial class tool : Form
    {
        public tool()
        {
            InitializeComponent();
        }

     

        public static bool istmapi = true;
        private PS3API PS3 = new PS3API();
        private uint[] processIDs;

       
        public uint processID { get; private set; }

        private void faderMinimalTheme1_Click(object sender, EventArgs e)
        {

        }


        private void faderButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PS3.ConnectTarget(0);
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Successfully Connected To PS3");
            }
            catch
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Failed To Connect");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void faderButton2_Click(object sender, EventArgs e)
        {
            try
            {
                PS3.AttachProcess();

                PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Successfully Attached To TrickyModz Black Ops II RTM Tool!");
            }
            catch
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Failed To Attach :/");
            }

        }

        private void faderButton3_Click(object sender, EventArgs e)
        {
            PS3.DisconnectTarget();
            MessageBox.Show("You Have Successfully Disconnect your PS3 Console.", "Successful.", MessageBoxButtons.OK);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void logInLogButton1_Click(object sender, EventArgs e)
        {
            webBrowser2.Visible = true;
            webBrowser2.Navigate("https://geoiptool.com/en/?ip=");
            SendKeys.Send(faderTextBox2.Text);

        }

        private void faderButton4_Click(object sender, EventArgs e)
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
           label5.Text = (externalip);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if
                (label1.ForeColor == Color.Red)
                label1.ForeColor = Color.Blue;
            else if
                (label1.ForeColor == Color.Blue)
                label1.ForeColor = Color.Lime;
            else if
                (label1.ForeColor == Color.Lime)
                label1.ForeColor = Color.Yellow;
            else if
                (label1.ForeColor == Color.Yellow)
                label1.ForeColor = Color.Red;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            label5.Text = (externalip);
        }
    }
    }


