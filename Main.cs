using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;


namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        string chatchannel = ""; // chat channel name


        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private DateTime FromUnixTime(long unixDateTime)
        {
            return DateTimeOffset.FromUnixTimeSeconds(unixDateTime).DateTime.ToLocalTime();
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


        private void sendmsg_Click(object sender, EventArgs e)
        {
            if (Login.KeyAuthApp.chatsend(chatmsg.Text, chatchannel))
            {
                dataGridView1.Rows.Insert(0, Login.KeyAuthApp.user_data.username, chatmsg.Text, FromUnixTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
            }
            else
                chatmsg.Text = "Status: " + Login.KeyAuthApp.response.message;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            subscriptionDaysLabel.Text = "Expiry: " + Login.KeyAuthApp.expirydaysleft();
            if (subscriptionDaysLabel.Text == "Expiry: 0 Days 0 Hours 0 Minutes 0 Seconds left.")
            {
                closing_Data();
                Environment.Exit(0);
            }


            if (subscription.Text == "Active Subscription: CS 1.6" || subscription.Text == "Active Subscription: Admin")
            {
                CScheatPictureBox.Image = Loader.Properties.Resources.cs16;
                subscriptionPictureBox.Image = Loader.Properties.Resources.cs16;
                CSCheatPanel.Visible = true;

            }
            else
            {
                CSCheatPanel.Visible = false;
            }

            if (subscription.Text == "Active Subscription: Valorant" || subscription.Text == "Active Subscription: Admin")
            {
                ValocheatPictureBox.Image = Loader.Properties.Resources.Valorant_272x380;
                subscriptionPictureBox.Image = Loader.Properties.Resources.Valorant_272x380;
                ValorantCheatPanel.Visible = true;

            }
            else
            {
                ValorantCheatPanel.Visible = false;
            }

            if (subscription.Text == "Active Subscription: Gta V" || subscription.Text == "Active Subscription: Admin")
            {
                GtaVcheatPictureBox.Image = Loader.Properties.Resources.gta_5;
                subscriptionPictureBox.Image = Loader.Properties.Resources.gta_5;
                GtaVCheatPanel.Visible = true;
            }
            else
            {
                GtaVCheatPanel.Visible = false;
            }

            if (subscription.Text == "Active Subscription: League of Legends Bot" || subscription.Text == "Active Subscription: Admin")
            {
                LolcheatPictureBox.Image = Loader.Properties.Resources.lol;
                subscriptionPictureBox.Image = Loader.Properties.Resources.lol;
                LoLBotCheatPanel.Visible = true;
            }
            else
            {
                LoLBotCheatPanel.Visible = false;
            }


        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = random_string();
            try
            {
                Login.KeyAuthApp.check();
                siticoneLabel1.Text = $"Current Session Validation Status: {Login.KeyAuthApp.response.success}";
                key.Text = Login.KeyAuthApp.user_data.username;
                expiry.Text = "Expiry: " + FromUnixTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
                subscription.Text = "Active Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
                ip.Text = "IP Address: " + Login.KeyAuthApp.user_data.ip;
                hwid.Text = "HWID: " + Login.KeyAuthApp.user_data.hwid;
                createDate.Text = "Creation date: " + FromUnixTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
                lastLogin.Text = "Last login: " + FromUnixTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin));
                numUsers.Text = "Number of users: " + Login.KeyAuthApp.app_data.numUsers;
                numOnlineUsers.Text = "Number of online users: " + Login.KeyAuthApp.app_data.numOnlineUsers;
                numKeys.Text = "Number of licenses: " + Login.KeyAuthApp.app_data.numKeys;
                version.Text = "Version: " + Login.KeyAuthApp.app_data.version;
                customerPanelLink.Text = "Customer panel: " + Login.KeyAuthApp.app_data.customerPanelLink;
                timer1.Start();

                if (subscription.Text == "Active Subscription: CS 1.6")
                {
                    var point = new Point(15, 14);
                    CSCheatPanel.Location = point;
                }

                if (subscription.Text == "Active Subscription: Valorant")
                {
                    var point = new Point(15, 14);
                    ValorantCheatPanel.Location = point;
                }

                if (subscription.Text == "Active Subscription: Gta V")
                {
                    var point = new Point(15, 14);
                    GtaVCheatPanel.Location = point;
                }

                if (subscription.Text == "Active Subscription: League of Legends Bot")
                {
                    var point = new Point(15, 14);
                    LoLBotCheatPanel.Location = point;
                }


            }

            catch (Exception)
            {
                MessageBox.Show("Check your internet connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }


            if (Loader.Properties.Settings.Default.loadertop == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }

        }

        private void licensedetailsbutton_Click(object sender, EventArgs e)
        {
            newschangebutton.CustomBorderColor = Color.Transparent;
            cheatsbutton.CustomBorderColor = Color.Transparent;
            settingsbutton.CustomBorderColor = Color.Transparent;
            licensedetailsbutton.CustomBorderColor = Color.DodgerBlue;
            siticoneTabControl1.SelectedTab = tabPage1;
        }

        private void newschangebutton_Click(object sender, EventArgs e)
        {
            newschangebutton.CustomBorderColor = Color.DodgerBlue;
            cheatsbutton.CustomBorderColor = Color.Transparent;
            settingsbutton.CustomBorderColor = Color.Transparent;
            licensedetailsbutton.CustomBorderColor = Color.Transparent;
            siticoneTabControl1.SelectedTab = tabPage2;
        }

        private void cheatsbutton_Click(object sender, EventArgs e)
        {
            newschangebutton.CustomBorderColor = Color.Transparent;
            cheatsbutton.CustomBorderColor = Color.DodgerBlue;
            settingsbutton.CustomBorderColor = Color.Transparent;
            licensedetailsbutton.CustomBorderColor = Color.Transparent;
            siticoneTabControl1.SelectedTab = tabPage3;
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            newschangebutton.CustomBorderColor = Color.Transparent;
            cheatsbutton.CustomBorderColor = Color.Transparent;
            settingsbutton.CustomBorderColor = Color.DodgerBlue;
            licensedetailsbutton.CustomBorderColor = Color.Transparent;
            siticoneTabControl1.SelectedTab = tabPage4;
        }

        private void loadcheatbutton_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.SelectedTab = tabPage5;
        }

        private void buyrenewbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/NUvhvDD5BM");
        }


        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.SelectedTab = tabPage6;
        }

        private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.SelectedTab = tabPage7;
        }

        private void siticoneRoundedGradientButton3_Click(object sender, EventArgs e)
        {
            siticoneTabControl1.SelectedTab = tabPage8;
        }

        private void closing_Data()
        {
            foreach (var process in Process.GetProcessesByName("1"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("hl"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("VALORANT-Win64-Shipping"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("VALORANT"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("Skype"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("RiotClientServices"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcessesByName("LeagueClient"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcessesByName("LeagueClientUx"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcessesByName("LeagueClientUxRender"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("GTA5"))
            {
                process.Kill();
            }

            Thread.Sleep(500);
            string download1 = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp\\1");
            string download2 = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp\\TuYtHgPoMa.zip");
            string download3 = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp\\QwSdCxFrYb.zip");
            string download4 = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp\\GqTsAcXgU.zip");
            string download5 = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp\\PmYvRxEaQw.zip");

            Directory.Delete(download1, true);
            File.Delete(download2);
            File.Delete(download3);
            File.Delete(download4);
            File.Delete(download5);

            Thread.Sleep(500);
        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing_Data();
            Environment.Exit(0);

        }


    }
}
