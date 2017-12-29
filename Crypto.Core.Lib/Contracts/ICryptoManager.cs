using System.IO;
using System.Threading.Tasks;

namespace Crypto.Core.Lib.Contracts
{
    public interface ICryptoManager
    {
        /// <summary>
        /// Will Encrypt bytes using a protected AES 256 key pair
        /// Requires the RSA private key to read the AES key
        /// </summary>
        /// <param name="data"></param>
        /// <param name="privKey"></param>
        /// <param name="symKeys"></param>
        /// <returns></returns>
        byte[] EncryptBytes(byte[] data, string privKey, string symKeys);

        /// <summary>
        /// Will Decrypt bytes using a protected AES 256 key pair
        /// Requires the RSA private key to read the AES key
        /// </summary>
        /// <param name="data"></param>
        /// <param name="privKey"></param>
        /// <param name="symKeys"></param>
        /// <returns></returns>
        byte[] DecryptBytes(byte[] data, string privKey, string symKeys);

        Task EncryptStream(Stream source, Stream output, string privKey, string symKeys);

        Task DecryptStream(Stream source, Stream output, string privKey, string symKeys);
    }
}
