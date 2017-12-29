using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Crypto.Core.Lib.Contracts
{
    public enum AsymmetricKeyType
    {
        Unkown = 0,
        Private,
        Public
    }

    public enum SymmetricKeyType
    {
        Unkown = 0,
        Key,
        Iv
    }

    public interface ICryptoEngine
    {
        Task<IDictionary<AsymmetricKeyType, byte[]>> GenerateAsymmetricKeys(int keySize = 4096);
        byte[] AsymmetricEncrypt(byte[] data, byte[] key);
        byte[] AsymmetricDecrypt(byte[] data, byte[] key);

        IDictionary<SymmetricKeyType, byte[]> GenerateSymmetricKeys(int blockSize = 128, int keySize = 256);
        byte[] SymmetricEncrypt(byte[] data, byte[] key, byte[] iv);
        byte[] SymmetricDecrypt(byte[] data, byte[] key, byte[] iv);

        Task SymmetricEncryptStream(Stream data, Stream output, byte[] key, byte[] iv);
        Task SymmetricDecryptStream(Stream data, Stream output, byte[] key, byte[] iv);
    }
}
