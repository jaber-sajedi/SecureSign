using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;

namespace PKI.Core.Abstractions
{
    public interface IKeyAlgorithm
    {
        /// نام الگوریتم (برای نمایش در UI و ذخیره در فایل امضا)

        string Name { get; }

        // تولید جفت کلید (Public / Private)
        AsymmetricCipherKeyPair GenerateKeyPair();
    }
}
