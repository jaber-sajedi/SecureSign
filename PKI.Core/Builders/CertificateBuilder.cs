using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace PKI.Core.Builders
{
    /// <summary>
    /// این کلاس مسئول ساخت گواهی‌ها است:
    /// Root / Intermediate / End-Entity
    /// از الگوریتم‌های مختلف (RSA / ML-DSA) پشتیبانی می‌کند
    /// Compatible با BouncyCastle 1.9+
    /// </summary>
    public static class CertificateBuilder
    {
        /// <summary>
        /// ساخت Root CA
        /// </summary>
        public static X509Certificate CreateRootCertificate(
            AsymmetricCipherKeyPair keyPair,
            string subjectName,
            int validYears,
            string algorithmName = "RSA")
        {
            var random = new SecureRandom();
            var certGen = new X509V3CertificateGenerator();

            var cn = new X509Name($"CN={subjectName}");

            // Serial Number تصادفی
            certGen.SetSerialNumber(BigInteger.ProbablePrime(120, random));

            // Subject و Issuer یکسان برای Root
            certGen.SetIssuerDN(cn);
            certGen.SetSubjectDN(cn);

            certGen.SetNotBefore(DateTime.UtcNow.Date);
            certGen.SetNotAfter(DateTime.UtcNow.Date.AddYears(validYears));

            certGen.SetPublicKey(keyPair.Public);

            // Basic Constraints: CA=true
            certGen.AddExtension(
                X509Extensions.BasicConstraints,
                true,
                new BasicConstraints(true));

            // Key Usage
            certGen.AddExtension(
                X509Extensions.KeyUsage,
                true,
                new KeyUsage(KeyUsage.KeyCertSign | KeyUsage.CrlSign));

            // انتخاب Signature Factory بر اساس الگوریتم
            var signatureFactory = GetSignatureFactory(algorithmName, keyPair.Private);

            // Self-signed
            return certGen.Generate(signatureFactory);
        }

        /// <summary>
        /// ساخت Intermediate CA
        /// </summary>
        public static X509Certificate CreateIntermediateCertificate(
            AsymmetricCipherKeyPair intermediateKey,
            string intermediateName,
            int validYears,
            X509Certificate issuerCert,
            AsymmetricKeyParameter issuerKey,
            string algorithmName = "RSA")
        {
            var random = new SecureRandom();
            var certGen = new X509V3CertificateGenerator();

            var subject = new X509Name($"CN={intermediateName}");

            certGen.SetSerialNumber(BigInteger.ProbablePrime(120, random));
            certGen.SetIssuerDN(issuerCert.SubjectDN);
            certGen.SetSubjectDN(subject);

            certGen.SetNotBefore(DateTime.UtcNow.Date);
            certGen.SetNotAfter(DateTime.UtcNow.Date.AddYears(validYears));

            certGen.SetPublicKey(intermediateKey.Public);

            // Basic Constraints: CA=true, pathLenConstraint=1
            certGen.AddExtension(
                X509Extensions.BasicConstraints,
                true,
                new BasicConstraints(1));

            // Key Usage
            certGen.AddExtension(
                X509Extensions.KeyUsage,
                true,
                new KeyUsage(KeyUsage.KeyCertSign | KeyUsage.CrlSign));

            var signatureFactory = GetSignatureFactory(algorithmName, issuerKey);
            return certGen.Generate(signatureFactory);
        }

        /// <summary>
        /// ساخت End-Entity Certificate
        /// </summary>
        public static X509Certificate CreateEndEntityCertificate(
            AsymmetricCipherKeyPair entityKey,
            string entityName,
            int validYears,
            X509Certificate issuerCert,
            AsymmetricKeyParameter issuerKey,
            string algorithmName = "RSA")
        {
            var random = new SecureRandom();
            var certGen = new X509V3CertificateGenerator();

            var subject = new X509Name($"CN={entityName}");

            certGen.SetSerialNumber(BigInteger.ProbablePrime(120, random));
            certGen.SetIssuerDN(issuerCert.SubjectDN);
            certGen.SetSubjectDN(subject);

            certGen.SetNotBefore(DateTime.UtcNow.Date);
            certGen.SetNotAfter(DateTime.UtcNow.Date.AddYears(validYears));

            certGen.SetPublicKey(entityKey.Public);

            // Basic Constraints: CA=false
            certGen.AddExtension(
                X509Extensions.BasicConstraints,
                true,
                new BasicConstraints(false));

            // Key Usage: DigitalSignature, KeyEncipherment
            certGen.AddExtension(
                X509Extensions.KeyUsage,
                true,
                new KeyUsage(KeyUsage.DigitalSignature | KeyUsage.KeyEncipherment));

            var signatureFactory = GetSignatureFactory(algorithmName, issuerKey);
            return certGen.Generate(signatureFactory);
        }

        /// <summary>
        /// ایجاد Signature Factory برای الگوریتم‌های مختلف
        /// </summary>
        private static ISignatureFactory GetSignatureFactory(string algorithmName, AsymmetricKeyParameter key)
        {
            return algorithmName switch
            {
                "RSA" => new Asn1SignatureFactory("SHA256WithRSA", key, new SecureRandom()),
                "ML-DSA-87" => new Asn1SignatureFactory("SHA512/MLDSA", key, new SecureRandom()),
                "ML-DSA-65" => new Asn1SignatureFactory("SHA384/MLDSA", key, new SecureRandom()),
                _ => throw new NotSupportedException($"Algorithm {algorithmName} not supported")
            };
        }
    }
}
