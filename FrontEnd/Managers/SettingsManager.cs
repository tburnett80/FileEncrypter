using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Contracts;
using FrontEnd.Models;

namespace FrontEnd.Managers
{
    public sealed class SettingsManager : ISettingsManager
    {
        #region Constructor and Private Members
        private readonly ISettingsEngine _engine;
        private readonly ISettingsAccessor _accessor;

        public SettingsManager(ISettingsEngine engine, ISettingsAccessor accessor)
        {
            _accessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }
        #endregion

        public async Task<SettingsModel> GetSettings()
        {
            return await await _accessor.ReadSettingsFromDisk()
                .ContinueWith(async tsk => await _engine.UnProtectData(await tsk))
                .ContinueWith(async tsk => await _engine.Deserialize(await await tsk));
        }

        public async Task<SettingsModel> SaveSettings(SettingsModel model)
        {
            return await _engine.Serialize(model)
                .ContinueWith(async tsk => await _engine.ProtectData(await tsk))
                .ContinueWith(async tsk => await _accessor.WriteSettingsToDisk(await await tsk))
                .ContinueWith(tsk => model);
        }

        public async Task<IEnumerable<KeyModel>> AppendKeys(IEnumerable<KeyModel> keys)
        {
            var settings = await GetSettings();
            
            var existingKeys = settings.Keys.ToList();
            existingKeys.AddRange(keys);
            settings.Keys = existingKeys;

            return await SaveSettings(settings)
                .ContinueWith(tsk => tsk.Result.Keys);
        }

        public async Task<IEnumerable<KeyModel>> RemoveKey(KeyModel model)
        {
            var settings = await GetSettings();
            settings.Keys = settings.Keys.ToList().Where(k => !k.Id.Equals(model.Id));

            return await SaveSettings(settings)
                .ContinueWith(tsk => tsk.Result.Keys);
        }
    }
}
