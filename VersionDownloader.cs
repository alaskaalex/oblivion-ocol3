using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace OCOL {
    public partial class VersionDownloader : Form {

        public String urlOfUpdate;

        public VersionDownloader(String urlOfUpdate) {
            this.urlOfUpdate = urlOfUpdate;
            InitializeComponent();
        }

        private WebClient webClient = new WebClient();

        private void VersionDownloader_Load(object sender, EventArgs e) {
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            try {
                webClient.DownloadFileAsync(new Uri(urlOfUpdate), Main.tempPath + "OCOLInstaller.exe");
            } catch (System.Net.WebException) {
                MessageBox.Show("Could not download update installer! Check your internet connection and try again.");
                this.Close();
            }

        }

        void ProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
        }

        void Completed(object sender, AsyncCompletedEventArgs e) {
            if (e.Cancelled) {
                this.Close();
                return;
            }

            if (e.Error != null) {
                MessageBox.Show("Could not download update installer! Check your internet connection and try again.");
                this.Close();
                return;
            }
            try {
                System.Diagnostics.Process.Start(Main.tempPath + "OCOLInstaller.exe");
            } catch (System.ComponentModel.Win32Exception exn) {
                if (exn.NativeErrorCode == 1223) {
                    MessageBox.Show("Update cancelled by user.");
                    this.Close();
                    return;
                }
            }
            Application.Exit();
        }

        private void cancelB_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void VersionDownloader_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e) {
            webClient.CancelAsync();
        }

        
    }
}
