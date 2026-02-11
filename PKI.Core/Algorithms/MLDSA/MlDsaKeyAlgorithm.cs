using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using PKI.Core.Abstractions;

 
 
/// پیاده‌سازی الگوریتم ML-DSA به صورت داینامیک.
/// سطح امنیت از بیرون تزریق می‌شود (44 / 65 / 87).
public class MlDsaKeyAlgorithm : IKeyAlgorithm
{
 
    /// پارامتر امنیتی انتخاب شده (مثلاً ml_dsa_87)
    private readonly MLDsaParameters _parameters;
    /// سازنده کلاس که پارامتر امنیتی را دریافت می‌کند.
    public MlDsaKeyAlgorithm(MLDsaParameters parameters)
    {
        _parameters = parameters;
    }

    /// نام الگوریتم جهت نمایش در UI
    public string Name => $"ML-DSA-{_parameters.Name}";

    /// تولید جفت کلید عمومی و خصوصی
    public AsymmetricCipherKeyPair GenerateKeyPair()
    {
        var random = new SecureRandom();

        var generator = new MLDsaKeyPairGenerator();

        generator.Init(new MLDsaKeyGenerationParameters(random, _parameters));

        return generator.GenerateKeyPair();
    }
}
