using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd.Contracts;
using FrontEnd.Models;
using FrontEnds;
using Unity;
using Unity.Resolution;

namespace FrontEnd
{
    public partial class KeyManager : Form
    {
        private readonly ISettingsManager _settingsManager;
        private KeyModel _selected;

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

            btnNewSymmKey.Click += async (obj, args) =>
            {
                using (var frm = Program.Container.Resolve<SymmertricKey>())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    await _settingsManager.AppendKeys(new[] { frm.SymmKey })
                        .ContinueWith(async tsk => await BindKeys(await tsk));
                }
            };

            btnDeleteKey.Click += async (obj, args) =>
            {
                if (_selected == null)
                    return;

                await _settingsManager.RemoveKey(_selected)
                    .ContinueWith(async tsk => await BindKeys(await tsk));

                ClearForm();
            };

            btnImport.Click += async (obj, args) =>
            {
                using (var frm = Program.Container.Resolve<ImportKey>())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    await _settingsManager.AppendKeys(new[] { frm.KeyFinal })
                        .ContinueWith(async tsk => await BindKeys(await tsk));
                }
            };

            btnExport.Click += (obj, args) =>
            {
                using (var frm = Program.Container.Resolve<ExportKey>(new ParameterOverride("key", _selected )))
                {
                    frm.ShowDialog();
                }
            };

            lstKeys.SelectedIndexChanged += (obj, args) =>
            {
                _selected = (KeyModel) lstKeys.SelectedItem;
                if (_selected == null)
                {
                    btnExport.Enabled = false;
                    return;
                }

                btnExport.Enabled = true;
                txtKey.Text = _selected.Key;
                txtKeyDesc.Text = _selected.Description;
                txtKeyName.Text = _selected.Name;
                txtKeyLen.Text = _selected.KeyLength.ToString();
                txtKeyType.Text = _selected.KeyType.ToString();
                txtTimestamp.Text = _selected.KeyCreationTimestamp.ToString("yyyy-MM-dd HH:mm:ss");
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

        private void ClearForm()
        {
            txtKey.Clear();
            txtKeyDesc.Clear();
            txtKeyName.Clear();
            txtKeyLen.Clear();
            txtKeyType.Clear();
            txtTimestamp.Clear();
        }
    }
}
