using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using System.IO;
using Org.BouncyCastle.OpenSsl;

namespace PKI.Core.Exporters
{
    /// این کلاس برای خروجی گرفتن گواهی بصورت PEM یا CER
    public static class PemExporter
    {
        /// ذخیره گواهی در فرمت PEM
        public static void ExportCertificateToPem(X509Certificate cert, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                var pemWriter = new PemWriter(writer);
                pemWriter.WriteObject(cert);
            }
        }

        /// <summary>
        /// ذخیره کلید خصوصی در فرمت PEM
        /// </summary>
        public static void ExportPrivateKeyToPem(AsymmetricKeyParameter privateKey, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                var pemWriter = new PemWriter(writer);
                pemWriter.WriteObject(privateKey);
            }
        }
    }
}
