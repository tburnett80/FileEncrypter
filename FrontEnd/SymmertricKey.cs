using Crypto.Core.Lib.Contracts;
using FrontEnd.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd;
using FrontEnd.Models;

namespace FrontEnds
{
    public partial class SymmertricKey : Form
    {
        private readonly ICryptoKeyManager _keyManager;
        private readonly ISettingsManager _settingsManagers;
        private IList<KeyModel> _keys;
        private KeyModel _key;

        public KeyModel SymmKey { get; set; }

        public SymmertricKey(ICryptoKeyManager keyManager, ISettingsManager settingsManager)
        {
            _keys = new List<KeyModel>();
            _keyManager = keyManager ?? throw new ArgumentNullException(nameof(keyManager));
            _settingsManagers = settingsManager ?? throw new ArgumentNullException(nameof(settingsManager));

            InitializeComponent();
            InitDropDown();

            btnGen.Click += (obj, args) =>
            {
                var pub = (KeyModel) cmbAsymmKey.SelectedItem;
                if(pub == null)
                    return;

                _key = new KeyModel
                {
                    Id = Guid.NewGuid(),
                    AssociatedKey = pub.Id,
                    Name = txtKeyName.Text.TryTrim(),
                    Description = txtKeyDescription.Text.TryTrim(),
                    KeyType = KeyType.Symmetric,
                    Key = _keyManager.GetProtectedSymetricKey(pub.Key),
                    KeyCreationTimestamp = DateTime.Now
                };

                _key.KeyLength = _key.Key.FromBase64().Length;
                BindModel(_key);
            };

            btnSaveKey.Click += (obj, args) =>
            {
                _key.Name = txtKeyName.Text.TryTrim() ?? _key.Name;
                _key.Description = txtKeyDescription.Text.TryTrim() ?? _key.Description;

                SymmKey = _key;
                DialogResult = DialogResult.OK;
                Close();
            };
        }

        private void BindModel(KeyModel key)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker) delegate
                {
                    txtKey.Text = key.Key;
                    txtKeyLen.Text = key.KeyLength.ToString();
                    txtKeyType.Text = key.KeyType.ToString();
                    txtTimstamps.Text = key.KeyCreationTimestamp.ToString("yyyy-MM-dd HH:mm:ss");
                });
            }
            else
            {
                txtKey.Text = key.Key;
                txtKeyLen.Text = key.KeyLength.ToString();
                txtKeyType.Text = key.KeyType.ToString();
                txtTimstamps.Text = key.KeyCreationTimestamp.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private async Task InitDropDown()
        {
            await _settingsManagers.GetSettings()
                .ContinueWith(async tsk => RefreshDropdown((await tsk).Keys.ToList()));
        }

        private void RefreshDropdown(IList<KeyModel> keys = null)
        {
            if(keys != null)
                _keys = keys;

            Invoke((MethodInvoker)delegate
            {
                cmbAsymmKey.DataSource = _keys;
                cmbAsymmKey.DisplayMember = "Name";
                cmbAsymmKey.SelectedItem = _keys.FirstOrDefault(k => k.KeyType == KeyType.PublicAsymmetric);
            });
        }
    }
}
