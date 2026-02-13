using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.OpenSsl;

namespace Signing.Core.Utilities
{
    using Org.BouncyCastle.X509;
    using Org.BouncyCastle.OpenSsl;
    using System.IO;

    public static class LoadKey
    {
        public static AsymmetricKeyParameter LoadPrivateKey(string keyPath)
        {
            using var reader = File.OpenText(keyPath);
            var pemReader = new PemReader(reader);

            var keyObject = pemReader.ReadObject();

            if (keyObject is AsymmetricCipherKeyPair keyPair)
                return keyPair.Private;

            if (keyObject is AsymmetricKeyParameter keyParameter)
                return keyParameter;

            throw new Exception("Invalid private key file.");
        }

        public static X509Certificate LoadCertificate(string certPath)
        {
            using var reader = File.OpenText(certPath);
            var pemReader = new PemReader(reader);

            var certObject = pemReader.ReadObject();
            if (certObject is X509Certificate cert)
                return cert;

            throw new Exception("Invalid certificate file.");
        }
    }

}
