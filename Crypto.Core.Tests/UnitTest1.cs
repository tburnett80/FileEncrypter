//using System;
//using System.IO;
//using System.Text;
//using Crypto.Core.Lib;
//using Crypto.Core.Lib.Contracts;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Crypto.Core.Tests
//{
//    [TestClass]
//    public class UnitTest1 : TestBaseClass
//    {
//        /// <summary>
//        /// Tests Asymmetric Crypto Engine by generating key pairs, encrypting random value then decrpting it and verifying the values match.
//        /// </summary>
//        [TestCategory("Unit Test")]
//        [TestMethod]
//        public void AsymmetricCryptoEndToEndTest()
//        {
//            //Arrange
//            var eng = new CryptoEngine();
//            var testValue = Guid.NewGuid().ToString();

//            //Act
//            var keys = eng.GenerateAsymmetricKeys(1024);
//            var encrypted = eng.AsymmetricEncrypt(Encoding.UTF8.GetBytes(testValue), keys[AsymmetricKeyType.Public]);
//            var decrypted = Encoding.UTF8.GetString(eng.AsymmetricDecrypt(encrypted, keys[AsymmetricKeyType.Private]));

//            //Assert
//            Assert.IsNotNull(decrypted, "Should be non null string value");
//            Assert.IsFalse(string.IsNullOrEmpty(decrypted), "Should be non null string value");
//            Assert.AreEqual(testValue, decrypted, "Should be equal");
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        [TestCategory("Unit Test")]
//        [TestMethod]
//        public void SymmetricCryptoEndToEndTest()
//        {
//            //Arrange
//            var eng = new CryptoEngine();
//            var testValue = Guid.NewGuid().ToString();

//            //Act
//            var keys = eng.GenerateSymmetricKeys();
//            var encrypted = eng.SymmetricEncrypt(Encoding.UTF8.GetBytes(testValue), keys[SymmetricKeyType.Key], keys[SymmetricKeyType.Iv]);
//            var decrypted = Encoding.UTF8.GetString(eng.SymmetricDecrypt(encrypted, keys[SymmetricKeyType.Key], keys[SymmetricKeyType.Iv]));

//            //Assert
//            Assert.IsNotNull(decrypted, "Should be non null string value");
//            Assert.IsFalse(string.IsNullOrEmpty(decrypted), "Should be non null string value");
//            Assert.AreEqual(testValue, decrypted, "Should be equal");
//        }

//        /// <summary>
//        /// Test simulates getting pub / priv key and securing symetric keys used for stronger AES encryption
//        /// Then encrypting bytes with that symetric key, and decrypting the bytes with that key.
//        /// This would be the typical flow, generate AES key, secure it with a public key and share with other side
//        /// Then share bytes encrypted with stronger AES symetric encryption.
//        /// </summary>
//        [TestCategory("Integration Test")]
//        [TestMethod]
//        public void EndToEndBytes()
//        {
//            //Arrange
//            var mgr = new CryptoManager(new CryptoEngine());
//            var testValue = Guid.NewGuid().ToString();

//            //Act
//            var keys = mgr.GenerateAsymmetricKeys(1024);
//            var symkey = mgr.GetProtectedSymetricKey(keys[AsymmetricKeyType.Public]);

//            var encrypted = mgr.EncryptBytes(Encoding.UTF8.GetBytes(testValue), keys[AsymmetricKeyType.Private], symkey);
//            var decrypted = Encoding.UTF8.GetString(mgr.DecryptBytes(encrypted, keys[AsymmetricKeyType.Private], symkey));

//            //Assert
//            Assert.IsNotNull(decrypted, "Should be non null string value");
//            Assert.IsFalse(string.IsNullOrEmpty(decrypted), "Should be non null string value");
//            Assert.AreEqual(testValue, decrypted, "Should be equal");
//        }

//        /// <summary>
//        /// Test simulates encrypting a file or other stream using the secured symetric keys / AES encryption.
//        /// </summary>
//        [TestCategory("Integration Test")]
//        [TestMethod]
//        public void TestFile()
//        {
//            //Arrange
//            var mgr = new CryptoManager(new CryptoEngine());
//            var source = GetResourceStreamByName("SampleData.txt");

//            //Act
//            var keys = mgr.GenerateAsymmetricKeys(1024);
//            var symkey = mgr.GetProtectedSymetricKey(keys[AsymmetricKeyType.Public]);

//            var outputStream = new MemoryStream();
//            mgr.EncryptStream(source, outputStream, keys[AsymmetricKeyType.Private], symkey).Wait();

//            outputStream.Position = 0;
//            var clearOutputStream = new MemoryStream();
//            mgr.DecryptStream(outputStream, clearOutputStream, keys[AsymmetricKeyType.Private], symkey).Wait();
//            clearOutputStream.Position = 0;

//            using (var sr = new StreamReader(clearOutputStream))
//            {
//                var result = sr.ReadToEnd();

//                //Assert
//                Assert.IsFalse(string.IsNullOrEmpty(result), "Should match text in SampleData.txt");
//                Assert.AreEqual(TestText, result, "Should be equal");
//            }
//        }
//    }
//}
