using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KeyAuth;
using Siticone.Desktop.UI.WinForms.Suite;


namespace KeyAuth
{
    public partial class Login : Form
    {
        // KeyAuthApp.register("username", "password", "key");
        //KeyAuthApp.login("username", "password"); 

        public static api KeyAuthApp = new api(
            name: "TolaPlus",
            ownerid: "fuE7N6dyWl",
            secret: "c179566b29ee7e9b75b606e4726b084b5ae95452ccf088e02a28e997ee162992",
            version: "0.0.2"
        );

        public Login()
        {
            InitializeComponent();
            Rememberme_Init_Data();
            Autologin_Init_Data();
        }

        private void Rememberme_Init_Data()
        {
            if (Loader.Properties.Settings.Default.username != string.Empty)
            {
                if (Loader.Properties.Settings.Default.password != string.Empty)
                {
                    if (Loader.Properties.Settings.Default.remember == true)
                    {
                        {
                            username.Text = Loader.Properties.Settings.Default.username;
                            password.Text = Loader.Properties.Settings.Default.password;
                            rememberme.Checked = true;
                        }
                    }
                    else
                    {
                        username.Text = Loader.Properties.Settings.Default.username;
                        password.Text = Loader.Properties.Settings.Default.password;
                    }
                }
            }

        }

        private void Rememberme_Save_Data()
        {
            if (rememberme.Checked)
            {
                Loader.Properties.Settings.Default.username = username.Text.Trim();
                Loader.Properties.Settings.Default.password = password.Text.Trim();
                Loader.Properties.Settings.Default.remember = true;
                Loader.Properties.Settings.Default.Save();
            }
            else
            {
                Loader.Properties.Settings.Default.username = "";
                Loader.Properties.Settings.Default.password = "";
                Loader.Properties.Settings.Default.remember = false;
                Loader.Properties.Settings.Default.Save();
            }

        }

        private void Autologin_Init_Data()
        {
            if (Loader.Properties.Settings.Default.autologinsave == true)
            {
                autologin.Checked = true;
            }
            else
            {

            }
        }

        private void Autologin_Save_Data()
        {
            if (autologin.Checked)
            {
                Loader.Properties.Settings.Default.autologinsave = true;
                Loader.Properties.Settings.Default.Save();
            }
            else
            {
                Loader.Properties.Settings.Default.autologinsave = false;
                Loader.Properties.Settings.Default.Save();
            }
        }


        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }

            return str;

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Rememberme_Save_Data();
            Autologin_Save_Data();

            try
            {

                KeyAuthApp.login(username.Text, password.Text);
                if (KeyAuthApp.response.success)
                {
                    //siticoneMessageDialog1.Show();
                    Hide();
                    Dashboard mainloader = new Dashboard();
                    mainloader.Show();
                }
                else
                {
                    loginstatus.Text = "Status: " + KeyAuthApp.response.message;
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Check your internet connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(registerusername.Text, registerpassword.Text, registerkey.Text);
            if (KeyAuthApp.response.success)
            {
                siticoneTabControl1.SelectedTab = tabPage1;
            }
            else
            {
                registerstatus.Text = "Status: " + KeyAuthApp.response.message;
            }

        }

        private void UpgradeBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.upgrade(upgradeusername.Text, upgradekey.Text);
            if (KeyAuthApp.response.success)
            {

            }
            else
            {
                upgradestatus.Text = "Status: " + KeyAuthApp.response.message;
            }

            if (upgradestatus.Text == "Status: Upgraded successfully")
            {
                Thread.Sleep(1000);
                siticoneTabControl1.SelectedTab = tabPage1;
            }

        }

        private void KeyBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(keylogin.Text);
            if (KeyAuthApp.response.success)
            {
                Dashboard main = new Dashboard();
                main.Show();
                this.Hide();
            }
            else
            {
                keystatus.Text = "Status: " + KeyAuthApp.response.message;
            }


        }

        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.SelectedTab = tabPage2;
        }

        private void siticoneRoundedGradientButton3_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.SelectedTab = tabPage3;
        }

        private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.SelectedTab = tabPage4;
        }

        private void siticoneRoundedGradientButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://tolaplus.com");
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.SelectedTab = tabPage1;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //themecolor_Data();
            try
            {
                //loginstatus.TextAlign = ContentAlignment.MiddleCenter;
                KeyAuthApp.init();
                if (KeyAuthApp.response.message == "invalidver")
                {
                    if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                    {
                        DialogResult dialogResult = MessageBox.Show("'Yes' An update is available! Click to download automatically! \n\n 'No' Exit.", "Auto update available!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (dialogResult)
                        {
                            case DialogResult.No:
                                //Process.Start(KeyAuthApp.app_data.downloadLink);
                                Environment.Exit(0);
                                break;
                            case DialogResult.Yes:
                                WebClient webClient = new WebClient();
                                //string destFile = Application.ExecutablePath;
                                string destFile = $"{Application.ExecutablePath}/UpdateFolder/";

                                string rand = random_string();

                                //destFile = destFile.Replace(".exe", $"-{rand}.exe");
                                webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                                Process.Start(destFile);
                                Process.Start(new ProcessStartInfo()
                                {
                                    Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    CreateNoWindow = true,
                                    FileName = "cmd.exe"
                                });
                                Environment.Exit(0);
                                break;
                            default:
                                MessageBox.Show("Invalid option ?");
                                Environment.Exit(0);
                                break;
                        }
                    }
                    MessageBox.Show("[ENG] The software is currently in update! Please wait for it to update, when it is updated it will be announced in the community and it will automatically update itself when you start the software! \n _______________________________________________________________ \n [TR] Yazılım şu anda güncelleniyor! Lütfen güncellenmesini bekleyin, güncellendiğinde toplulukta duyurulacak ve yazılımı başlattığınızda otomatik olarak kendini güncelleyecektir!", "Updating...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }

                if (!KeyAuthApp.response.success)
                {
                    MessageBox.Show(KeyAuthApp.response.message);
                    Environment.Exit(0);
                }
                if (KeyAuthApp.checkblack())
                {
                    MessageBox.Show("Your device has been banned! You can contact the developer.", "Hwid lock!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                else
                {
                    //MessageBox.Show("user is not blacklisted");
                }
                KeyAuthApp.check();
                siticoneLabel1.Text = $"Current Session Validation Status: {KeyAuthApp.response.success}";
                //siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.GreenYellow;  

            }
            
            catch (Exception)
            {
                //MessageBox.Show("Check your internet connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
                //Environment.Exit(0);
            }

            if (Loader.Properties.Settings.Default.logintop == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }

            string create = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp\\1");
            Directory.CreateDirectory(create);

            if (Loader.Properties.Settings.Default.autologinsave == true)
            {
                timer1.Enabled = true;
            }
            else
            {

            }
            this.Text = random_string();


            Process[] processesByName = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (processesByName.Length > 1)
            {
                //MessageBox.Show("It's already working!");
                Environment.Exit(0);
            }
            else
            {
                return;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoginBtn.PerformClick();
            timer1.Enabled = false;
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


    }
}



