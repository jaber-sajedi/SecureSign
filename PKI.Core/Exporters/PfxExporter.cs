using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace PKI.Core.Exporters
{
  /// این کلاس مسئول خروجی گرفتن PFX (PKCS#12) است
 public static class PfxExporter
    {
      /// Export Certificate + Private Key به PFX
      /// <param name="path">مسیر ذخیره فایل</param>
        /// <param name="cert">گواهی</param>
        /// <param name="privateKey">کلید خصوصی</param>
        /// <param name="password">رمزگذاری PFX</param>
        public static void Export(string path, X509Certificate cert, AsymmetricKeyParameter privateKey, string password)
        {
            // ساخت store
            var store = new Pkcs12StoreBuilder().Build();

            string friendlyName = cert.SubjectDN.ToString();

            // اضافه کردن کلید خصوصی و گواهی
            var certificateEntry = new X509CertificateEntry(cert);
            store.SetKeyEntry(friendlyName, new AsymmetricKeyEntry(privateKey), new[] { certificateEntry });

            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                store.Save(fs, password.ToCharArray(), new SecureRandom());
            }
        }
    }
}
