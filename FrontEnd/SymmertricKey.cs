using Crypto.Core.Lib.Contracts;
using FrontEnd.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd.Models;

namespace FrontEnds
{
    public partial class SymmertricKey : Form
    {
        private readonly ICryptoKeyManager _keyManager;
        private readonly ISettingsManager _settingsManagers;
        private IList<KeyModel> _keys;

        public KeyModel SymmKey { get; set; }

        public SymmertricKey(ICryptoKeyManager keyManager, ISettingsManager settingsManager)
        {
            _keys = new List<KeyModel>();
            _keyManager = keyManager ?? throw new ArgumentNullException(nameof(keyManager));
            _settingsManagers = settingsManager ?? throw new ArgumentNullException(nameof(settingsManager));

            PopulateDropDown();
            
            InitializeComponent();

            cmbAsymmKey.DataSource = _keys;
            cmbAsymmKey.DisplayMember = "Name";
        }

        private async Task PopulateDropDown()
        {
            _keys = await _settingsManagers.GetSettings()
                .ContinueWith(tsk => tsk.Result.Keys.ToList());
        }
    }
}
