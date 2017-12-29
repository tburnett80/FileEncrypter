using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd.Contracts;
using FrontEnd.Models;
using Unity;

namespace FrontEnd
{
    public partial class KeyManager : Form
    {
        private readonly ISettingsManager _settingsManager;

        public KeyManager(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager ?? throw new ArgumentNullException(nameof(settingsManager));

            InitializeComponent();
            BindKeys();

            btnNewAsymmKey.Click += async (obj, args) =>
            {
                using (var frm = Program.Container.Resolve<AsymmetricKey>())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    await _settingsManager.AppendKeys(new[] { frm.PublicKey, frm.PrivateKey })
                        .ContinueWith(async tsk => await BindKeys(await tsk));
                }
            };

            btnNewSymmKey.Click += (obj, args) =>
            {
                //TODO: open SymForm
            };

            btnDeleteKey.Click += async (obj, args) =>
            {
                var selected = (KeyModel)lstKeys.SelectedItem;
                if (selected == null)
                    return;

                await _settingsManager.RemoveKey(selected)
                    .ContinueWith(async tsk => await BindKeys(await tsk));
            };

            lstKeys.SelectedIndexChanged += (obj, args) =>
            {
                var selected = (KeyModel) lstKeys.SelectedItem;
                if(selected == null)
                    return;

                txtKey.Text = selected.Key;
                txtKeyDesc.Text = selected.Description;
                txtKeyName.Text = selected.Name;
                txtKeyLen.Text = selected.KeyLength.ToString();
                txtKeyType.Text = selected.KeyType.ToString();
                txtTimestamp.Text = selected.KeyCreationTimestamp.ToString("yyyy-MM-dd HH:mm:ss");
            };
        }

        private async Task BindKeys(IEnumerable<KeyModel> keys = null)
        {
            await _settingsManager.GetSettings()
                .ContinueWith(async tsk =>
                {
                    var settings = await tsk;
                    if (keys != null)
                        settings.Keys = keys.ToList();

                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker) delegate
                        {
                            lstKeys.DataSource = settings.Keys;
                            lstKeys.DisplayMember = "Name";
                            lstKeys.ValueMember = "Name";
                        });
                    }
                    else
                    {
                        lstKeys.DataSource = settings.Keys;
                        lstKeys.DisplayMember = "Name";
                        lstKeys.ValueMember = "Name";
                    }

                    lstKeys.SelectedIndex = 0;
                });
        }
    }
}
