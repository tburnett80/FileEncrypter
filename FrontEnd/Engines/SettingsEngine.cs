using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FrontEnd.Contracts;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Engines
{
    public sealed class SettingsEngine : ISettingsEngine
    {
        public async Task<byte[]> ProtectData(byte[] data)
        {
            if (!data.Any())
                return data;

            return await Task.Factory.StartNew(() => 
                ProtectedData.Protect(data, Encoding.UTF8.GetBytes(Assembly.GetExecutingAssembly().GetType().GUID.ToString()), DataProtectionScope.CurrentUser));
        }

        public async Task<byte[]> UnProtectData(byte[] data)
        {
            if (!data.Any())
                return data;

            return await Task.Factory.StartNew(() => 
                ProtectedData.Unprotect(data, Encoding.UTF8.GetBytes(Assembly.GetExecutingAssembly().GetType().GUID.ToString()), DataProtectionScope.CurrentUser));
        }

        public async Task<byte[]> Serialize(SettingsModel model)
        {
            return await Task.Factory.StartNew(() => 
                Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(model, Formatting.None)));
        }

        public async Task<SettingsModel> Deserialize(byte[] data)
        {
            if (!data.Any())
                return new SettingsModel();

            return await Task.Factory.StartNew(() => 
                JsonConvert.DeserializeObject<SettingsModel>(Encoding.UTF8.GetString(data)));
        }
    }
}
