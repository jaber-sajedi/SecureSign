using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using PKI.Core.Abstractions;
using PKI.Core.Factory;
using Signing.Core.Services;
using Signing.Core.Utilities;

namespace KI.WinForms
{
    public partial class SignForm : Form
    {
        byte[] fileBytes;
        string selectedFile;
        string selectedFileForSign;
        AsymmetricKeyParameter privateKeyFile;
        string certificateFile;
        public SignForm()
        {
            InitializeComponent();

            cmbRootAlgorithm.Items.AddRange(new string[] { "RSA", "ML-DSA-44", "ML-DSA-65", "ML-DSA-87" });
            cmbRootAlgorithm.SelectedIndex = 0;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {

            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "*.key|*.key";
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    selectedFile = dlg.FileName;
                    lblFileStatus.Text = selectedFile;
                    MessageBox.Show($"Key selected: {Path.GetFileName(selectedFile)}");
                }
            }


        }



        private void btnSignFile_Click(object sender, EventArgs e)
        {
            var privateKey = LoadKey.LoadPrivateKey(selectedFile);

            if (string.IsNullOrEmpty(selectedFile) || privateKey.IsPrivate != true)
            {
                MessageBox.Show("ابتدا فایل و کلید خصوصی را انتخاب کنید!");
                return;
            }


            ISignatureProvider signer = CryptoFactory.CreateSigner(cmbRootAlgorithm.SelectedItem.ToString());

            var cert = LoadKey.LoadCertificate(certificateFile);  

            var fileSigner = new FileSigner(signer);
            fileSigner.SignFile(selectedFileForSign, privateKey, cert, cmbRootAlgorithm.SelectedItem.ToString());
            lblSignFile.Text = selectedFileForSign;
            MessageBox.Show("File signed successfully!");
        }

        private void SignForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectPrivateKeyFile(object sender, EventArgs e)
        {

        }

        private void btnSelectFileForSign_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Select file to sign";
                dlg.Filter = "All Files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    selectedFileForSign = dlg.FileName;
                    lblFileForSignStatus.Text = selectedFileForSign;
                    MessageBox.Show($"File: {Path.GetFileName(selectedFileForSign)}");
                }
            }

        }

        private void btnSelectCert_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Certificate";
                dlg.Filter = "PEM Certificate (*.pem)|*.pem";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    certificateFile = dlg.FileName;
                    lblCertStatus.Text = $"Cert: {Path.GetFileName(certificateFile)}";
                    MessageBox.Show($"Cert: {Path.GetFileName(certificateFile)}");
                }
            }
        }
    }
}
