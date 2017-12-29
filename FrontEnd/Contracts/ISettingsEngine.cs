using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Contracts
{
    public interface ISettingsEngine
    {
        Task<byte[]> ProtectData(byte[] data);

        Task<byte[]> UnProtectData(byte[] data);

        Task<byte[]> Serialize(SettingsModel model);

        Task<SettingsModel> Deserialize(byte[] data);
    }
}
