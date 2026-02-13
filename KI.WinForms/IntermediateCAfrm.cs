using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Xml.Xsl;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using PKI.Core.Builders;
using PKI.Core.Exporters;
using PKI.Core.Factory;
using Signing.Core.Utilities;

namespace KI.WinForms
{
    public partial class IntermediateCAfrm : Form
    {
        string pfxFilePath;

        private X509Certificate intermediateCert;
        private AsymmetricCipherKeyPair intermediateKey;

        private X509Certificate cert; private AsymmetricCipherKeyPair keyPair;


        public IntermediateCAfrm()
        {
            InitializeComponent();
            cmbIntermediateAlgorithm.Items.AddRange(new string[] { "RSA", "ML-DSA-44", "ML-DSA-65", "ML-DSA-87" });
            cmbIntermediateAlgorithm.SelectedIndex = 0;
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

        private void btnGenerateIntermediate_Click(object sender, EventArgs e)
        {
             (cert,keyPair)   =
                PfxLoader.Load(txtRootPfxPath.Text, txtRootPassword.Text);

            if (cert == null || keyPair == null)
            {
                MessageBox.Show("Root CA باید ابتدا ساخته شود!");
                return;
            }

            string cn = txtIntermediateCN.Text;
            var years = int.Parse(txtIntermediateYears.Text);
            string algorithm = cmbIntermediateAlgorithm.SelectedItem.ToString();


            var keyAlgo = CryptoFactory.CreateKeyAlgorithm(algorithm);
            intermediateKey = keyAlgo.GenerateKeyPair();


            intermediateCert = CertificateBuilder.CreateIntermediateCertificate(
                intermediateKey, cn, years, cert, keyPair.Private);

            MessageBox.Show($"End-Entity Certificate Generated ✔ ({keyAlgo.Name})");
        }

        private void btnExportIntermediate_Click(object sender, EventArgs e)
        {
            using (var dlg=new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string folder = dlg.SelectedPath;

                    PfxExporter.Export(Path.Combine(folder, "intermediate.pf"), intermediateCert, intermediateKey.Private, txtIntermediatePassword.Text);
                    PemExporter.ExportCertificateToPem(intermediateCert, Path.Combine(folder, "intermediate.pem"));
                    PemExporter.ExportPrivateKeyToPem(intermediateKey.Private, Path.Combine(folder, "intermediate.key"));
                    MessageBox.Show($"Intermediate CA Exported ✔ to {folder}");
                }
            }
        
        }
    }
}
