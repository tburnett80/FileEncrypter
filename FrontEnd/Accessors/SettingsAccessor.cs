using System;
using System.IO;
using System.Threading.Tasks;
using FrontEnd.Contracts;

namespace FrontEnd.Accessors
{
    public sealed class SettingsAccessor : ISettingsAccessor
    {
        private static readonly object Lock = new object();
        private const string SettingName = "Settings.json";
        private readonly string _settingPath;

        public SettingsAccessor()
        {
            _settingPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\CryptoTool\{SettingName}";
        }

        public async Task<byte[]> ReadSettingsFromDisk()
        {
            return await Task.Factory.StartNew(() =>
            {
                lock (Lock)
                {
                    return !File.Exists(_settingPath) 
                        ? new byte[0] 
                        : File.ReadAllBytes(_settingPath);
                }
            });
        }

        public async Task WriteSettingsToDisk(byte[] settings)
        {
            await Task.Factory.StartNew(() =>
            {
                lock (Lock)
                {
                    if (!Directory.Exists(_settingPath.Replace(SettingName, "")))
                        Directory.CreateDirectory(_settingPath.Replace(SettingName, ""));

                    File.WriteAllBytes(_settingPath, settings);
                }
            });
        }
    }
}
