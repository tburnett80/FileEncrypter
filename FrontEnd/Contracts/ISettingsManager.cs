using System.Collections.Generic;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Contracts
{
    public interface ISettingsManager
    {
        Task<SettingsModel> GetSettings();

        Task<SettingsModel> SaveSettings(SettingsModel model);

        Task<IEnumerable<KeyModel>> AppendKeys(IEnumerable<KeyModel> keys);

        Task<IEnumerable<KeyModel>> RemoveKey(KeyModel model);
    }
}
