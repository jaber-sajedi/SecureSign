using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using PKI.Core.Abstractions;

namespace PKI.Core.Algorithms.RSA
{
    public class RsaKeyAlgorithm : IKeyAlgorithm
    {
     
        /// نام الگوریتم
        public string Name => "RSA-2048";

   
        /// تولید کلید RSA با طول 2048 بیت
        public AsymmetricCipherKeyPair GenerateKeyPair()
        {
            var generator = new RsaKeyPairGenerator();

            // مقداردهی اولیه با اندازه کلید و SecureRandom
            generator.Init(new KeyGenerationParameters(new SecureRandom(), 2048));

            return generator.GenerateKeyPair();
        }
    }
}
