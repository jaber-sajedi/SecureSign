using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto.Parameters;
using PKI.Core.Abstractions;
using PKI.Core.Algorithms.MLDSA;
using PKI.Core.Algorithms.RSA;

namespace PKI.Core.Factory
{
    public static class CryptoFactory
    {
        /// ایجاد تولیدکننده کلید بر اساس نام الگوریتم
        public static IKeyAlgorithm CreateKeyAlgorithm(string name)
        {
            return name switch
            {
                "ML-DSA-44" => new MlDsaKeyAlgorithm(MLDsaParameters.ml_dsa_44),
                "ML-DSA-65" => new MlDsaKeyAlgorithm(MLDsaParameters.ml_dsa_65),
                "ML-DSA-87" => new MlDsaKeyAlgorithm(MLDsaParameters.ml_dsa_87),
                _ => throw new NotSupportedException("الگوریتم پشتیبانی نمی‌شود")
            };
        }

        /// ایجاد امضاکننده بر اساس نام الگوریتم
        public static ISignatureProvider CreateSigner(string name)
        {
            return name switch
            {
                "RSA" => new RsaSignatureProvider(),
                "MLDSA" => new MlDsaSignatureProvider(),
                _ => throw new NotSupportedException("الگوریتم پشتیبانی نمی‌شود")
            };
        }
    }
}