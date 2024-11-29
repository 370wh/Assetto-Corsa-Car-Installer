using System;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.IO.Compression;
namespace Test
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderBrowserDialog1;
        WebClient webClient;
        public Form1()
        {
            InitializeComponent();
            folderBrowserDialog1 = new FolderBrowserDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discords : 370zz. - Installer Dev, Bench - Owner", "Contact Us!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.gg/swim6ix") { UseShellExecute = true });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
     
            Serverlist form2 = new Serverlist();

        
            this.Hide();

       
            form2.Show();
        }

        private void a_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In your assetto corsa folder select the content folder", "Installation Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string downloadFolderPath = folderBrowserDialog1.SelectedPath;

          
                webClient = new WebClient();
                webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;

       
                webClient.DownloadFileAsync(new Uri("your-download-link-here-it-must-be-a-raw-download-link-to-a-zip-file"), Path.Combine(downloadFolderPath, "downloadedFile.zip"));
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            guna2ProgressBar1.Value = e.ProgressPercentage;
        }

        private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                string downloadFolderPath = folderBrowserDialog1.SelectedPath;
                string zipFilePath = Path.Combine(downloadFolderPath, "downloadedFile.zip");
                string extractPath = Path.Combine(downloadFolderPath);

                // Extract the downloaded zip file
                if (!Directory.Exists(extractPath))
                    Directory.CreateDirectory(extractPath);

                ZipFile.ExtractToDirectory(zipFilePath, extractPath);

                MessageBox.Show("Files downloaded and extracted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error occurred during download: " + e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            webClient.Dispose();
        }

     
        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
