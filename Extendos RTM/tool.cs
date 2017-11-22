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
           

        }

        private void faderButton4_Click(object sender, EventArgs e)
        {
           
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

        private void logInLogButton2_Click(object sender, EventArgs e)
        {
            WebClient Name = new WebClient();
            string IP = Name.DownloadString("https://webresolver.nl/api.php?key=1IY6H-FJF8Y-YD9FG-LWRPG&action=resolve&string=" + faderTextBox3.Text);
            faderTextBox4.Text = IP;

        }

        private void logInLogButton3_Click(object sender, EventArgs e)
        {
            WebClient Name = new WebClient();
            string IP = Name.DownloadString("https://webresolver.nl/api.php?key=1IY6H-FJF8Y-YD9FG-LWRPG&action=portscan&string=" + faderTextBox5.Text);
            faderTextBox6.Text = IP;
        }

        private void logInLogButton4_Click(object sender, EventArgs e)
        {
            WebClient Name = new WebClient();
            string IP = Name.DownloadString("https://webresolver.nl/api.php?key=1IY6H-FJF8Y-YD9FG-LWRPG&action=email2skype&string=" + faderTextBox7.Text);
            faderTextBox8.Text = IP;
        }

        private void logInLogButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void faderTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void logInLogButton6_Click(object sender, EventArgs e)
        {
            WebClient Name = new WebClient();
            string IP = Name.DownloadString("http://playstationresolver.com/API/auth.php?type=Resolve&psn=" + faderTextBox2.Text);
            faderTextBox9.Text = IP;
        

        }

        private void faderLabel15_Click(object sender, EventArgs e)
        {

        }
    }
}


