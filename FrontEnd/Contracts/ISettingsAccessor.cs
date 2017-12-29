using System.Threading.Tasks;

namespace FrontEnd.Contracts
{
    public interface ISettingsAccessor
    {
        Task<byte[]> ReadSettingsFromDisk();

        Task WriteSettingsToDisk(byte[] settings);
    }
}
