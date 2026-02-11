using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Org.BouncyCastle.Crypto;
using PKI.Core.Abstractions;
using Signing.Core.Models;
using Signing.Core.Utilities;
using Org.BouncyCastle.X509;

namespace Signing.Core.Services
{
    /// این کلاس مسئول امضای فایل است.
    /// الگوریتم به صورت داینامیک تزریق می‌شود.
    public class FileSigner
    {
        private readonly ISignatureProvider _signatureProvider;

      /// سازنده که امضاکننده مورد نظر (RSA یا MLDSA) را دریافت می‌کند
       public FileSigner(ISignatureProvider signatureProvider)
        {
            _signatureProvider = signatureProvider;
        }


        /// <param name="filePath">مسیر فایل اصلی</param>
        /// <param name="privateKey">کلید خصوصی</param>
        /// <param name="certificate">گواهی امضا کننده</param>
        /// <param name="algorithmName">نام الگوریتم</param>
        public void SignFile(
            string filePath,
            AsymmetricKeyParameter privateKey,
            X509Certificate certificate,
            string algorithmName)
        {
            // خواندن فایل
            var fileBytes = File.ReadAllBytes(filePath);

            // محاسبه هش
            var hash = HashUtility.ComputeSha256(fileBytes);

            // تولید امضا
            var signatureBytes = _signatureProvider.Sign(hash, privateKey);

            // ساخت مدل خروجی
            var signatureModel = new SignatureFileModel
            {
                FileName = Path.GetFileName(filePath),
                Algorithm = algorithmName,
                FileHash = Convert.ToBase64String(hash),
                Signature = Convert.ToBase64String(signatureBytes),
                CertificateBase64 = Convert.ToBase64String(certificate.GetEncoded()),
                Timestamp = DateTime.UtcNow
            };

            // تبدیل به JSON
            var json = JsonSerializer.Serialize(signatureModel, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            // ذخیره فایل امضا
            var outputPath = filePath + ".sig";
            File.WriteAllText(outputPath, json);
        }
    }
}
