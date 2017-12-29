using System;
using System.Windows.Forms;
using Crypto.Core.Lib.Contracts;
using FrontEnd.Models;

namespace FrontEnd
{
    public partial class AsymmetricKey : Form
    {
        public KeyModel PublicKey { get; set; }
        public KeyModel PrivateKey { get; set; }

        private readonly ICryptoKeyManager _keyManager;

        public AsymmetricKey(ICryptoKeyManager keyManager)
        {
            _keyManager = keyManager ?? throw new ArgumentNullException(nameof(keyManager));

            PublicKey = new KeyModel
            {
                KeyCreationTimestamp = DateTime.Now,
                KeyType = KeyType.PublicAsymmetric
            };

            PrivateKey = new KeyModel
            {
                KeyCreationTimestamp = DateTime.Now,
                KeyType = KeyType.PrivateAsymmetric
            };

            _keyManager.GenerateAsymmetricKeys()
                .ContinueWith(tsk =>
                {
                    PublicKey.Key = tsk.Result[AsymmetricKeyType.Public];
                    PrivateKey.Key = tsk.Result[AsymmetricKeyType.Private];

                    PublicKey.KeyLength = Convert.FromBase64String(PublicKey.Key).Length;
                    PrivateKey.KeyLength = Convert.FromBase64String(PrivateKey.Key).Length;

                    BindModel(PublicKey);
                    BindModel(PrivateKey);
                });

            InitializeComponent();

            BindModel(PublicKey);
            BindModel(PrivateKey);

            btnSaveKey.Click += (obj, args) =>
            {
                PublicKey.Name = txtPubKeyName.Text.Trim();
                PublicKey.Description = txtPubKeyDescription.Text.Trim();

                PrivateKey.Name = txtPrivKeyName.Text.Trim();
                PrivateKey.Description = txtPrivKeyDescription.Text.Trim();

                if (string.IsNullOrEmpty(PublicKey.Name))
                    PublicKey.Name = Guid.NewGuid().ToString();

                if (string.IsNullOrEmpty(PrivateKey.Name))
                    PrivateKey.Name = Guid.NewGuid().ToString();

                DialogResult = DialogResult.OK;
                Close();
            };
        }

        private void BindModel(KeyModel model)
        {
            var nameCtrl = model.KeyType == KeyType.PublicAsymmetric
                ? txtPubKeyName 
                : txtPrivKeyName;

            var descCtrl = model.KeyType == KeyType.PublicAsymmetric
                ? txtPubKeyDescription
                : txtPrivKeyDescription;

            var keyCtrl = model.KeyType == KeyType.PublicAsymmetric
                ? txtPubKey
                : txtPrivKey;

            var keyLenCtrl = model.KeyType == KeyType.PublicAsymmetric
                ? txtPubKeyLen
                : txtPrivKeyLen;

            var keyTypeCtrl = model.KeyType == KeyType.PublicAsymmetric
                ? txtPubKeyType
                : txtPrivKeyType;

            var keyTimeCtrl = model.KeyType == KeyType.PublicAsymmetric
                ? txtPubTimeStamp
                : txtPrivTimeStamp;

            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    nameCtrl.Text = model.Name;
                    descCtrl.Text = model.Description;
                    keyCtrl.Text = model.Key;
                    keyLenCtrl.Text = model.KeyLength.ToString();
                    keyTypeCtrl.Text = model.KeyType.ToString();
                    keyTimeCtrl.Text = model.KeyCreationTimestamp.ToString("yyyy-MM-dd HH:mm:ss");
                });
            }
            else
            {
                nameCtrl.Text = model.Name;
                descCtrl.Text = model.Description;
                keyCtrl.Text = model.Key;
                keyLenCtrl.Text = model.KeyLength.ToString();
                keyTypeCtrl.Text = model.KeyType.ToString();
                keyTimeCtrl.Text = model.KeyCreationTimestamp.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
    }
}
