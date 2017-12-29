using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Crypto.Core.Lib.Contracts;

namespace Crypto.Core.Lib
{
    public sealed class CryptoManager : ICryptoManager, ICryptoKeyManager
    {
        private readonly ICryptoEngine _engine;

        public CryptoManager(ICryptoEngine engine)
        {
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }

        public async Task<IDictionary<AsymmetricKeyType, string>> GenerateAsymmetricKeys(int keyLen = 4096)
        {
            return await _engine.GenerateAsymmetricKeys(keyLen)
                .ContinueWith(tsk => tsk.Result.ToDictionary(p => p.Key, p => Convert.ToBase64String(p.Value)));
        }

        public string GetProtectedSymetricKey(string pubKey)
        {
            var pubBytes = Convert.FromBase64String(pubKey);
            var symKeys = _engine.GenerateSymmetricKeys();

            var bytes = new List<byte>();

            var protectedKey = _engine.AsymmetricEncrypt(symKeys[SymmetricKeyType.Key], pubBytes);
            bytes.AddRange(BitConverter.GetBytes(protectedKey.Length));
            bytes.AddRange(protectedKey);

            var protectedIv = _engine.AsymmetricEncrypt(symKeys[SymmetricKeyType.Iv], pubBytes);
            bytes.AddRange(BitConverter.GetBytes(protectedIv.Length));
            bytes.AddRange(protectedIv);

            return Convert.ToBase64String(bytes.ToArray());
        }

        public byte[] EncryptBytes(byte[] data, string privKey, string symKeys)
        {
            var key = Convert.FromBase64String(privKey);
            var unprotectedSymKeys = UnpackSymKeys(symKeys).ToDictionary(kvp => kvp.Key, kvp => _engine.AsymmetricDecrypt(kvp.Value, key));

            return _engine.SymmetricEncrypt(data, unprotectedSymKeys[SymmetricKeyType.Key], unprotectedSymKeys[SymmetricKeyType.Iv]);
        }

        public byte[] DecryptBytes(byte[] data, string privKey, string symKeys)
        {
            var key = Convert.FromBase64String(privKey);
            var unprotectedSymKeys = UnpackSymKeys(symKeys).ToDictionary(kvp => kvp.Key, kvp => _engine.AsymmetricDecrypt(kvp.Value, key));

            return _engine.SymmetricDecrypt(data, unprotectedSymKeys[SymmetricKeyType.Key], unprotectedSymKeys[SymmetricKeyType.Iv]);
        }

        public async Task EncryptStream(Stream source, Stream output, string privKey, string symKeys)
        {
            var key = Convert.FromBase64String(privKey);
            var unprotectedSymKeys = UnpackSymKeys(symKeys).ToDictionary(kvp => kvp.Key, kvp => _engine.AsymmetricDecrypt(kvp.Value, key));

            await _engine.SymmetricEncryptStream(source, output, unprotectedSymKeys[SymmetricKeyType.Key], unprotectedSymKeys[SymmetricKeyType.Iv]);
        }

        public async Task DecryptStream(Stream source, Stream output, string privKey, string symKeys)
        {
            var key = Convert.FromBase64String(privKey);
            var unprotectedSymKeys = UnpackSymKeys(symKeys).ToDictionary(kvp => kvp.Key, kvp => _engine.AsymmetricDecrypt(kvp.Value, key));

            await _engine.SymmetricDecryptStream(source, output, unprotectedSymKeys[SymmetricKeyType.Key], unprotectedSymKeys[SymmetricKeyType.Iv]);
        }

        public IDictionary<SymmetricKeyType, byte[]> UnpackSymKeys(string symKeys)
        {
            var data = Convert.FromBase64String(symKeys);
            var symKeyBytes = data.Skip(4).Take(BitConverter.ToInt32(data, 0)).ToArray();
            var symKeyIvBytes = data.Skip(symKeyBytes.Length + 8).Take(BitConverter.ToInt32(data, symKeyBytes.Length + 4)).ToArray();

            return new Dictionary<SymmetricKeyType, byte[]>
            {
                { SymmetricKeyType.Key, symKeyBytes },
                { SymmetricKeyType.Iv, symKeyIvBytes }
            };
        }
    }
}
