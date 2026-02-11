using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Org.BouncyCastle.X509;
using PKI.Core.Factory;
using Signing.Core.Models;
using Signing.Core.Utilities;

namespace Signing.Core.Services
{
    public class FileVerifier
    {
        /// <summary>
        /// بررسی صحت فایل و امضا
        /// </summary>
        public bool VerifyFile(string filePath, string signatureFilePath)
        {
            // خواندن فایل امضا
            var json = File.ReadAllText(signatureFilePath);

            var signatureModel = JsonSerializer.Deserialize<SignatureFileModel>(json);

            // خواندن فایل اصلی
            var fileBytes = File.ReadAllBytes(filePath);

            // محاسبه هش جدید
            var newHash = HashUtility.ComputeSha256(fileBytes);

            // مقایسه هش
            var storedHash = Convert.FromBase64String(signatureModel.FileHash);

            if (!newHash.SequenceEqual(storedHash))
                return false;

            // استخراج گواهی
            var certBytes = Convert.FromBase64String(signatureModel.CertificateBase64);
            var certParser = new X509CertificateParser();
            var certificate = certParser.ReadCertificate(certBytes);

            // انتخاب الگوریتم
            var signer = CryptoFactory.CreateSigner(signatureModel.Algorithm);

            // بررسی امضا
            var signatureBytes = Convert.FromBase64String(signatureModel.Signature);

            return signer.Verify(
                storedHash,
                signatureBytes,
                certificate.GetPublicKey());
        }
    }
}
