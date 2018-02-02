using System;
using System.Linq;
using System.Windows.Forms;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd
{
    public partial class ImportKey : Form
    {
        private KeyModel _key;

        public KeyModel KeyFinal { get; set; }

        public ImportKey()
        {
            InitializeComponent();
            btnParse.Enabled = false;

            btnClear.Click += (obj, args) => { Clear(); };

            btnParse.Click += (obj, args) =>
            {
                if (!txtInKey.Text.FromBase64().Any())
                    return;

                try
                {
                    _key = JsonConvert.DeserializeObject<KeyModel>(txtInKey.Text.FromBase64().FromBytes());
                    txtInKey.ReadOnly = true;

                    txtKeyName.Text = _key.Name;
                    txtKeyDesc.Text = _key.Description;
                    txtKey.Text = _key.Key;
                    txtKeyLen.Text = _key.KeyLength.ToString();
                    txtTimestamp.Text = _key.KeyCreationTimestamp.ToString("yyyy-MM-dd HH:mm:ss");
                    txtKeyType.Text = _key.KeyType.ToString();

                    txtKeyDesc.ReadOnly = !txtInKey.ReadOnly;
                    txtKeyName.ReadOnly = !txtInKey.ReadOnly;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not parse key from input.\r\nError:{ex.Message}", "Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnSave.Click += (obj, args) =>
            {
                KeyFinal = new KeyModel
                {
                    Id = _key.Id,
                    AssociatedKey = _key.AssociatedKey,
                    Key = _key.Key,
                    KeyType = _key.KeyType,
                    KeyCreationTimestamp = _key.KeyCreationTimestamp,
                    KeyLength = _key.KeyLength,
                    Description = txtKeyDesc.Text.TryTrim() ?? _key.Description,
                    Name = txtKeyName.Text.TryTrim() ?? _key.Name
                };

                DialogResult = DialogResult.OK;
                Close();
            };

            txtInKey.TextChanged += (obj, args) =>
            {
                btnParse.Enabled = txtInKey.Text.TryTrim().Length > 0;
            };
        }

        private void Clear()
        {
            txtInKey.Clear();
            txtInKey.ReadOnly = false;
            txtKeyDesc.ReadOnly = !txtInKey.ReadOnly;
            txtKeyName.ReadOnly = !txtInKey.ReadOnly;

            txtKey.Clear();
            txtKeyDesc.Clear();
            txtKeyLen.Clear();
            txtKeyName.Clear();
            txtKeyType.Clear();
            txtTimestamp.Clear();
        }
    }
}
