using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using PKI.Core.Abstractions;
using PKI.Core.Builders;
using PKI.Core.Exporters;
using PKI.Core.Factory;

namespace KI.WinForms
{
    public partial class RootCAfrm : Form
    {
        private X509Certificate rootCert;
        private AsymmetricCipherKeyPair rootKey;
        public RootCAfrm()
        {
            InitializeComponent();
            InitUI();
        }
        private void InitUI()
        {
            // پر کردن ComboBox الگوریتم
            cmbRootAlgorithm.Items.AddRange(new string[] { "RSA", "ML-DSA-44", "ML-DSA-65", "ML-DSA-87" });
            cmbRootAlgorithm.SelectedIndex = 0;

        }
        private void RootCA_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateRootCertificate_Click(object sender, EventArgs e)
        {
            string cn = txtCommonName.Text;
            int years = int.Parse(txtRootYears.Text);
            string algorithm = cmbRootAlgorithm.SelectedItem.ToString();

            IKeyAlgorithm keyAlgorithm = CryptoFactory.CreateKeyAlgorithm(algorithm);
            rootKey = keyAlgorithm.GenerateKeyPair();

            rootCert = CertificateBuilder.CreateRootCertificate(rootKey, cn, years);
            MessageBox.Show($"Root CA Generated ✔ ({keyAlgorithm.Name}");

        }

        private void btnExportRoot_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string folder = dlg.SelectedPath;

                    PfxExporter.Export(Path.Combine(folder, "root.pfx"), rootCert, rootKey.Private, txtRootPassword.Text);
                    PemExporter.ExportCertificateToPem(rootCert, Path.Combine(folder, "root.pem"));
                    PemExporter.ExportPrivateKeyToPem(rootKey.Private, Path.Combine(folder, "root.key"));

                    MessageBox.Show($"Root CA Exported ✔ to {folder}");
                }
            }
        }
    }
}
