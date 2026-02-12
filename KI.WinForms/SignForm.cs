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
          string privateKeyFile;
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
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    privateKeyFile = dlg.FileName;
                    selectedFile= dlg.FileName;
                     MessageBox.Show($"Key selected: {Path.GetFileName(privateKeyFile)}");
                }
            }

           
        }



        private void btnSignFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFile) || string.IsNullOrEmpty(privateKeyFile))
            {
                MessageBox.Show("ابتدا فایل و کلید خصوصی را انتخاب کنید!");
                return;
            }

            var privateKey = LoadKey.LoadPrivateKey(privateKeyFile);

            ISignatureProvider signer = CryptoFactory.CreateSigner(cmbRootAlgorithm.SelectedItem.ToString());

            var cert = LoadKey.LoadCertificate("endentity.pem"); // اگر certificate میخوای داخل JSON باشه

            var fileSigner = new FileSigner(signer);
            fileSigner.SignFile(selectedFile, privateKey, cert, cmbRootAlgorithm.SelectedItem.ToString());

            MessageBox.Show("File signed successfully!");
        }

        private void SignForm_Load(object sender, EventArgs e)
        {

        }
    }
}
