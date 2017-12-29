using System.Collections.Generic;

namespace FrontEnd.Models
{
    public enum KeyType
    {
        Unspecified = 0,
        PublicAsymmetric,
        PrivateAsymmetric,
        Symmetric
    }

    public sealed class SettingsModel
    {
        public SettingsModel()
        {
            Keys = new KeyModel[0];
        }

        public IEnumerable<KeyModel> Keys { get; set; }
    }
}
