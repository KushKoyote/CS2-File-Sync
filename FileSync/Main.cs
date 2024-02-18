
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSync
{
    public partial class Main : Form
    {
        public static Dictionary<int, string> download_urls = new Dictionary<int, string>()
        {
            { 0, "https://cloud.gtmds.de/s/Fo5s8mAJoqtYGEx/download/files.zip"}, //MUST BE A ZIP, STRUCTURE files.zip -> sounds -> etc
                                                                                 //                                   -> modals -> etc
                                                                                 //                                   -> shit   -> etc
        };

        public static Dictionary<string, string> download_data = new Dictionary<string, string>()
        {
            { "total", ""},
        };

        private Point offset;
        bool mouseDown;

        //MAIN
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            path_handler();
            load_default_set();
        }

        //FUNCTIONS 
        public void path_handler()
        {
            sync_path.Text = Utils.GetCSGOPath();
            sync_path.Update();
        }

        public void load_default_set()
        {
            if (Properties.Settings.Default.saved_path != "")
            {
                sync_path.Text = Properties.Settings.Default.saved_path;
                game_select.SelectedIndex = Properties.Settings.Default.selected_service;
                game_select.Update();

                if (Properties.Settings.Default.last_sync != null)
                {
                    label6.Text = "Last Sync: " + Properties.Settings.Default.last_sync;
                }
            }
        }
        public void ExtractZipFile(string sourceZipPath, string destinationPath)
        {
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            using (ZipArchive archive = ZipFile.OpenRead(sourceZipPath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (string.IsNullOrEmpty(entry.Name)) 
                    {
                        string directoryPath = Path.Combine(destinationPath, entry.FullName);
                        Directory.CreateDirectory(directoryPath);
                    }
                    else 
                    {
                        string destinationFilePath = Path.Combine(destinationPath, entry.FullName);
                        string directoryPath = Path.GetDirectoryName(destinationFilePath);
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        entry.ExtractToFile(destinationFilePath, true);
                    }
                }
            }
            label1.Visible = true;
        }
        private void gs_better_then_nl(bool istrue) { }
        public async Task DownloadAndUnzipFile(string fileUrl, string savePath, string extractPath)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();

                var totalBytes = response.Content.Headers.ContentLength ?? 0L;
                var receivedBytes = 0L;
                var percentage = 0.0;

                using (var contentStream = await response.Content.ReadAsStreamAsync())
                using (var fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                {
                    var buffer = new byte[8192];
                    var isMoreToRead = true;

                    do
                    {
                        var read = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                        if (read == 0)
                        {
                            isMoreToRead = false;
                        }
                        else
                        {
                            await fileStream.WriteAsync(buffer, 0, read);

                            receivedBytes += read;
                            percentage = (double)receivedBytes / totalBytes * 100;
                            MethodInvoker updateProgress = () => siticoneProgressBar1.Value = (int)percentage;
                            siticoneProgressBar1.Invoke(updateProgress);
                        }
                    }
                    while (isMoreToRead);
                }

                ExtractZipFile(savePath, extractPath);
            }
        }

        private void reset_focus()
        {
            header_panel.Focus();
        }

        //STUFF
        private void header_title_Click(object sender, EventArgs e)
        {

        }

        private void setting_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        //MINIMIZE
        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //CLOSE
        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Process p = Process.GetCurrentProcess();
            p.Kill();
        }

        private void header_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        //MOVEMENT


        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //FOCUS RESET
        private void setting_panel_Click(object sender, EventArgs e)
        {
            reset_focus();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            reset_focus();
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            reset_focus();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            reset_focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void game_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            path_handler();
        }

        private void server_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            path_handler();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.saved_path = sync_path.Text;
            Properties.Settings.Default.selected_service = game_select.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private async void siticoneButton4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.last_sync = DateTime.UtcNow;
            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.last_sync != null)
            {
                label6.Text = "Last Sync: " + Properties.Settings.Default.last_sync;

                if (download_urls.ContainsKey(game_select.SelectedIndex))
                {
                    var downloadUrl = download_urls[game_select.SelectedIndex];
                    await DownloadAndUnzipFile(downloadUrl, Path.Combine(Utils.GetCSGOPath(), "files.zip"), Utils.GetCSGOPath());
                }
                else
                {
                    MessageBox.Show($"No download URL found for the selected index: {game_select.SelectedIndex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
