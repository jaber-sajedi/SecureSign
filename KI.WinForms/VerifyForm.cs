using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Signing.Core.Models;
using Signing.Core.Services;
using Signing.Core.Utilities;

namespace KI.WinForms
{
    public partial class VerifyForm : Form
    {
        string OriginalFilePath;
        string SignFilePath;
        public VerifyForm()
        {
            InitializeComponent();
        }

        private void btnoriginalFilePath_Click(object sender, EventArgs e)
        {

            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    OriginalFilePath = dlg.FileName;
                    lblOriginalFilePath.Text= OriginalFilePath;
                    MessageBox.Show($"Key selected: {Path.GetFileName(OriginalFilePath)}");
                }
            }
        }

        private void btnSignFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "All Files (*.sig)|*.sig";
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    SignFilePath = dlg.FileName;
                    lblSignFile.Text= SignFilePath;
                    MessageBox.Show($"Key selected: {Path.GetFileName(SignFilePath)}");
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            FileVerifier verifier=new FileVerifier();
          var res= verifier.VerifyFile(OriginalFilePath, SignFilePath);



            if (!res)
            {
                MessageBox.Show("File has been modified ❌");
                lblVerifyState.Text = "File has been modified ❌";
                return;
            }

            lblVerifyState.Text = "File has been success";
            MessageBox.Show("File has been success ");



        }
    }
}
