using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Crypto.Core.Lib.Contracts;

namespace Crypto.Core.Lib
{
    public sealed class CryptoEngine : ICryptoEngine
    {
        public async Task<IDictionary<AsymmetricKeyType, byte[]>> GenerateAsymmetricKeys(int keySize = 4096)
        {
            return await Task<IDictionary<AsymmetricKeyType, byte[]>>.Factory.StartNew(() =>
            {
                using (var rsa = new RSACryptoServiceProvider(keySize))
                {
                    try
                    {
                        var _public = rsa.ToXmlString(false);
                        var _private = rsa.ToXmlString(true);

                        return new Dictionary<AsymmetricKeyType, byte[]>
                        {
                            { AsymmetricKeyType.Private, Encoding.UTF8.GetBytes(_private) },
                            { AsymmetricKeyType.Public, Encoding.UTF8.GetBytes(_public) }
                        };
                    }
                    catch (Exception) { }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }

                    return new ConcurrentDictionary<AsymmetricKeyType, byte[]>();
                }
            });
        }

        public byte[] AsymmetricEncrypt(byte[] data, byte[] key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(Encoding.UTF8.GetString(key));
                    return rsa.Encrypt(data, false);
                }
                catch (Exception)
                {
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }

                return new byte[0];
            }
        }

        public byte[] AsymmetricDecrypt(byte[] data, byte[] key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(Encoding.UTF8.GetString(key));
                    return rsa.Decrypt(data, false);
                }
                catch (Exception)
                {
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }

                return new byte[0];
            }
        }

        public IDictionary<SymmetricKeyType, byte[]> GenerateSymmetricKeys(int blockSize = 128, int keySize = 256)
        {
            using (var rm = new RijndaelManaged())
            {
                rm.BlockSize = blockSize;
                rm.KeySize = keySize;

                rm.GenerateIV();
                rm.GenerateKey();

                return new Dictionary<SymmetricKeyType, byte[]>
                {
                    { SymmetricKeyType.Key, rm.Key },
                    { SymmetricKeyType.Iv, rm.IV }
                };
            }
        }

        public byte[] SymmetricEncrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (var rm = new RijndaelManaged())
            {
                try
                {
                    rm.Key = key;
                    rm.IV = iv;
                    rm.Mode = CipherMode.CBC;
                    rm.Padding = PaddingMode.PKCS7;

                    return rm.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
                }
                catch (Exception)
                {
                }
            }

            return new byte[0];
        }

        public byte[] SymmetricDecrypt(byte[] data, byte[] key, byte[] iv)
        {

            using (var rm = new RijndaelManaged())
            {
                try
                {
                    rm.Key = key;
                    rm.IV = iv;
                    rm.Mode = CipherMode.CBC;
                    rm.Padding = PaddingMode.PKCS7;

                    return rm.CreateDecryptor().TransformFinalBlock(data, 0, data.Length);
                }
                catch (Exception)
                {
                }
            }

            return new byte[0];
        }

        public async Task SymmetricEncryptStream(Stream data, Stream output, byte[] key, byte[] iv)
        {
            using (var rm = new RijndaelManaged())
            {
                rm.Key = key;
                rm.IV = iv;
                rm.Mode = CipherMode.CBC;
                rm.Padding = PaddingMode.PKCS7;

                using (var crs = new CustomCryptoStream(output, rm.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    await data.CopyToAsync(crs);
                }
            }
        }

        public async Task SymmetricDecryptStream(Stream data, Stream output, byte[] key, byte[] iv)
        {
            using (var rm = new RijndaelManaged())
            {
                rm.Key = key;
                rm.IV = iv;
                rm.Mode = CipherMode.CBC;
                rm.Padding = PaddingMode.PKCS7;

                using (var crs = new CustomCryptoStream(output, rm.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    await data.CopyToAsync(crs);
                }
            }
        }
    }
}
