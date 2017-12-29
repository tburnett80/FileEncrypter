using System.IO;
using System.Reflection;

namespace Crypto.Core.Tests
{
    public abstract class TestBaseClass
    {
        #region Resources
        protected string PrivateKeyValue => GetResourceTextByName("key.priv");
        protected string PublicKeyValue => GetResourceTextByName("key.pub");
        protected string TestText => GetResourceTextByName("SampleData.txt");
        #endregion

        #region Embeded Resource Access Helpers
        protected Stream GetResourceStreamByName(string name)
        {
            using (var st = Assembly.GetExecutingAssembly().GetManifestResourceStream($"Crypto.Core.Tests.TestResources.{name}"))
            {
                var ms = new MemoryStream();
                st?.CopyTo(ms);

                ms.Position = 0;
                return ms;
            }
        }

        protected byte[] GetResourceBytesByName(string name)
        {
            using (var st = Assembly.GetExecutingAssembly().GetManifestResourceStream($"Crypto.Core.Tests.TestResources.{name}"))
            using (var ms = new MemoryStream())
            {
                st?.CopyTo(ms);
                return ms.ToArray();
            }
        }

        protected string GetResourceTextByName(string name)
        {
            using (var sr = new StreamReader(GetResourceStreamByName(name)))
            {
                return sr.ReadToEnd();
            }
        }
        #endregion
    }
}
