using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using PKI.Core.Abstractions;

namespace PKI.Core.Algorithms.MLDSA
{

    /// امضا و اعتبارسنجی با الگوریتم ML-DSA
    public class MlDsaSignatureProvider : ISignatureProvider
    {
        /// امضای داده با ML-DSA
        public byte[] Sign(byte[] data, AsymmetricKeyParameter privateKey)
        {
            var signer = SignerUtilities.GetSigner("ML-DSA");

            signer.Init(true, privateKey);
            signer.BlockUpdate(data, 0, data.Length);

            return signer.GenerateSignature();
        }

     
        /// بررسی صحت امضا
        public bool Verify(byte[] data, byte[] signature, AsymmetricKeyParameter publicKey)
        {
            var signer = SignerUtilities.GetSigner("ML-DSA");

            signer.Init(false, publicKey);
            signer.BlockUpdate(data, 0, data.Length);

            return signer.VerifySignature(signature);
        }
    }
}
