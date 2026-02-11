using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;

namespace PKI.Core.Abstractions
{
    public interface ISignatureProvider
    {
        /// امضای داده با استفاده از کلید خصوصی
        byte[] Sign(byte[] data, AsymmetricKeyParameter privateKey);

 
        /// بررسی صحت امضا با استفاده از کلید عمومی
        bool Verify(byte[] data, byte[] signature, AsymmetricKeyParameter publicKey);
    }

}
