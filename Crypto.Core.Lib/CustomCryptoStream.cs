using System.IO;
using System.Security.Cryptography;

namespace Crypto.Core.Lib
{
    internal sealed class CustomCryptoStream : CryptoStream
    {
        public CustomCryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
            : base(stream, transform, mode)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (!HasFlushedFinalBlock)
                FlushFinalBlock();

            base.Dispose(false);
        }
    }
}
