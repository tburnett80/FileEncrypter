using System;
using System.Windows.Forms;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd
{
    public partial class ExportKey : Form
    {
        private readonly KeyModel _key;

        public ExportKey(KeyModel key)
        {
            _key = key ?? throw new ArgumentNullException(nameof(key));

            InitializeComponent();

            btnClear.Click += (obj, args) =>
            {
                Clear();
            };

            btnExport.Click += (obj, args) =>
            {
               txtResult.Text = JsonConvert.SerializeObject(
                                    new KeyModel
                                        {
                                            Id = _key.Id,
                                            AssociatedKey = _key.AssociatedKey,
                                            Name = txtName.Text.TryTrim() ?? _key.Name,
                                            Description = txtDesc.Text.TryTrim() ?? _key.Description,
                                            Key = _key.Key,
                                            KeyType = _key.KeyType,
                                            KeyLength = _key.KeyLength,
                                            KeyCreationTimestamp = _key.KeyCreationTimestamp
                                        }, 
                                    Formatting.None).ToBytes().ToBase64();

                txtResult.SelectionStart = 0;
                txtResult.SelectionLength = txtResult.Text.Length;
                txtResult.Select();
                Clipboard.SetText(txtResult.Text);
                keyTip.Show("Key coppied to clipboard!\r\nUse Ctrl + V to paste it", txtResult, 3000);
            };

            Clear();
        }

        private void Clear()
        {
            txtName.Text = _key.Name;
            txtDesc.Text = _key.Description;
            txtResult.Text = string.Empty;
            Clipboard.Clear();
        }
    }
}
