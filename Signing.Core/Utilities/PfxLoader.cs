using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.X509;

namespace Signing.Core.Utilities
{
    public static class PfxLoader
    {
        public static (X509Certificate cert, AsymmetricCipherKeyPair keyPair)
            Load(string pfxPath, string password)
        {
            using var fs = new FileStream(pfxPath, FileMode.Open, FileAccess.Read);

            var store = new Pkcs12StoreBuilder().Build();
            store.Load(fs, password.ToCharArray());

            foreach (string alias in store.Aliases)
            {
                if (store.IsKeyEntry(alias))
                {
                    var privateKey = store.GetKey(alias).Key;
                    var cert = store.GetCertificate(alias).Certificate;

                    var publicKey = cert.GetPublicKey();

                    var keyPair = new AsymmetricCipherKeyPair(publicKey, privateKey);

                    return (cert, keyPair);
                }
            }

            throw new Exception("No private key found in PFX");
        }

    }
}
