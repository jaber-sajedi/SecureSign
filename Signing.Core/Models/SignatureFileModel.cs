using System;
using System.Collections.Generic;
using System.Text;

namespace Signing.Core.Models
{

    /// این کلاس نماینده ساختار فایل امضا است.
    /// اطلاعات مورد نیاز برای اعتبارسنجی در آن ذخیره می‌شود.

    public class SignatureFileModel
    {
        /// نام فایل اصلی
        public string FileName { get; set; }

        /// نام الگوریتم امضا (RSA / ML-DSA-87 و ...)
        public string Algorithm { get; set; }

        /// هش فایل اصلی به صورت Base64
        public string FileHash { get; set; }

        /// مقدار امضا به صورت Base64
        public string Signature { get; set; }

        /// گواهی امضا کننده (برای ساخت Chain)
        public string CertificateBase64 { get; set; }

        /// زمان امضا
        public DateTime Timestamp { get; set; }
    }

}
