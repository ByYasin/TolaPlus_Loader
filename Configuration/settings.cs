using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader.Configuration
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
            Rememberme_Init_Data();
            Autologin_Inıt_Data();
            Logintop_Inıt_Data();
            Loadertop_Inıt_Data();
        }

        private void Rememberme_Init_Data()
        {
            if (Properties.Settings.Default.remember == true)
            {
                rememberme.Checked = true;
            }
            else
            {

            }

        }

        private void Rememberme_Save_Data()
        {
            if (rememberme.Checked)
            {
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.Save();
            }

        }

        private void Autologin_Inıt_Data()
        {
            if (Properties.Settings.Default.autologinsave == true)
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
                Properties.Settings.Default.autologinsave = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.autologinsave = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Logintop_Inıt_Data()
        {
            if (Properties.Settings.Default.logintop == true)
            {
                logintopcheckbox.Checked = true;
            }
            else
            {

            }
        }

        private void Logintop_Save_Data()
        {
            if (logintopcheckbox.Checked)
            {
                Properties.Settings.Default.logintop = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.logintop = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Loadertop_Inıt_Data()
        {
            if (Properties.Settings.Default.loadertop == true)
            {
                loadertopcheckbox.Checked = true;
            }
            else
            {

            }
        }

        private void Loadertop_Save_Data()
        {
            if (loadertopcheckbox.Checked)
            {
                Properties.Settings.Default.loadertop = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.loadertop = false;
                Properties.Settings.Default.Save();
            }
        }



        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void rememberme_CheckedChanged(object sender, EventArgs e)
        {
            Rememberme_Save_Data();
        }

        private void autologin_CheckedChanged(object sender, EventArgs e)
        {
            Autologin_Save_Data();
        }

        private void logintopcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Logintop_Save_Data();
        }

        private void loadertopcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Loadertop_Save_Data();
        }




    }
}
