using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using PKI.Core.Builders;
using PKI.Core.Exporters;
using PKI.Core.Factory;
using Signing.Core.Utilities;

namespace KI.WinForms
{
    public partial class GenerateEndfrm : Form
    {
        private X509Certificate cert;
        private AsymmetricCipherKeyPair keyPair;

        private X509Certificate endEntityCert;
        private AsymmetricCipherKeyPair endEntityKey;
        string pfxFilePath;
        public GenerateEndfrm()
        {
            InitializeComponent();
            cmbEndEntityAlgorithm.Items.AddRange(new string[] { "RSA", "ML-DSA-44", "ML-DSA-65", "ML-DSA-87" });
            cmbEndEntityAlgorithm.SelectedIndex = 0;

        }

        private void btnGenerateIntermediate_Click(object sender, EventArgs e)
        {
            (cert, keyPair) =
                PfxLoader.Load(txtRootPfxPath.Text, txtIntermediatePassword.Text);

            if (cert == null || keyPair == null)
            {
                MessageBox.Show("Root CA باید ابتدا ساخته شود!");
                return;
            }


            string cn = txtIntermediateCN.Text;
            var years = int.Parse(txtIntermediateYears.Text);
            string algorithm = cmbEndEntityAlgorithm.SelectedItem.ToString();

            var keyAlgo = CryptoFactory.CreateKeyAlgorithm(algorithm);
            endEntityKey = keyAlgo.GenerateKeyPair();


            endEntityCert = CertificateBuilder.CreateEndEntityCertificate(
                endEntityKey, cn, years, cert, keyPair.Private);

            MessageBox.Show($"End-Entity Certificate Generated ✔ ({keyAlgo.Name})");
        }

        private void btnPfx_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.pf|*.pfx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pfxFilePath = ofd.FileName;
                txtRootPfxPath.Text = pfxFilePath;
            }
        }

        private void btnExportEndEntity_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string folder = dlg.SelectedPath;


                    PemExporter.ExportCertificateToPem(endEntityCert, Path.Combine(folder, "endentity.pem"));
                    PemExporter.ExportPrivateKeyToPem(endEntityKey.Private, Path.Combine(folder, "endentity.key"));

                    MessageBox.Show($"End Entity Certificate Exported ✔ to {folder}");

                }
            }
        }
    }
}
