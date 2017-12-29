using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crypto.Core.Lib.Contracts
{
    public interface ICryptoKeyManager
    {
        /// <summary>
        /// Will generate a new public / private key pair
        /// </summary>
        /// <param name="keyLen"></param>
        /// <returns>RSA Public / Private key pair</returns>
        Task<IDictionary<AsymmetricKeyType, string>> GenerateAsymmetricKeys(int keyLen = 4096);

        /// <summary>
        /// Will generate a new AES Key and encrpt it with a public key
        /// </summary>
        /// <param name="pubKey"></param>
        /// <returns>RSA protected AES Encrption key pair</returns>
        string GetProtectedSymetricKey(string pubKey);
    }
}
