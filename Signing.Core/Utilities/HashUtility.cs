using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Signing.Core.Utilities
{
    public static class HashUtility
    {
        /// <summary>
        /// محاسبه هش SHA256 از داده ورودی
        /// </summary>
        public static byte[] ComputeSha256(byte[] data)
        {
            using var sha = SHA256.Create();
            return sha.ComputeHash(data);
        }
    }
}
