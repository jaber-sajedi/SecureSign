using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using PKI.Core.Abstractions;

namespace PKI.Core.Algorithms.RSA
{
    
    /// پیاده‌سازی امضا و اعتبارسنجی با RSA + SHA256
  
    public class RsaSignatureProvider : ISignatureProvider
    {
     
        /// امضای داده با SHA256withRSA
 
        public byte[] Sign(byte[] data, AsymmetricKeyParameter privateKey)
        {
            var signer = SignerUtilities.GetSigner("SHA256withRSA");

            signer.Init(true, privateKey);
            signer.BlockUpdate(data, 0, data.Length);

            return signer.GenerateSignature();
        }

     
        /// بررسی صحت امضا
        public bool Verify(byte[] data, byte[] signature, AsymmetricKeyParameter publicKey)
        {
            var signer = SignerUtilities.GetSigner("SHA256withRSA");

            signer.Init(false, publicKey);
            signer.BlockUpdate(data, 0, data.Length);

            return signer.VerifySignature(signature);
        }
    }
}
