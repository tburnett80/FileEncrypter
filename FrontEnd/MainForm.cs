using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto.Core.Lib.Contracts;
using FrontEnd.Contracts;
using FrontEnd.Models;
using Unity;

namespace FrontEnd
{
    public partial class MainForm : Form
    {
        private readonly ICryptoManager _cryptoManager;
        private readonly ISettingsManager _settingsManager;

        public MainForm(ISettingsManager settingsManager, ICryptoManager cryptoManager)
        {
            _settingsManager = settingsManager ?? throw new ArgumentNullException(nameof(cryptoManager));
            _cryptoManager = cryptoManager ?? throw new ArgumentNullException(nameof(cryptoManager));

            InitializeComponent();
            PopulateDrops();

            rbEncrypt.CheckedChanged += (obj, args) =>
            {
                rbDecrypt.Checked = !rbEncrypt.Checked;
                btnSymAction.Text = rbEncrypt.Checked
                    ? rbEncrypt.Text
                    : rbDecrypt.Text;
            };

            btnSymAction.Click += async (obj, args) =>
            {
                var symmSelected = (dynamic)cmbSym.SelectedItem;

                if (rbEncrypt.Checked)
                    Encrypt(txtInFile.Text, txtOutFile.Text, symmSelected.Id, await _settingsManager.GetSettings());
                else
                    Decrypt(txtInFile.Text, txtOutFile.Text, symmSelected.Id, await _settingsManager.GetSettings());
            };

            btnGen.Click += (obj, args) =>
            {
                using (var keyMgrForm = Program.Container.Resolve<KeyManager>())
                {
                    if(keyMgrForm.ShowDialog() != null)
                        PopulateDrops();
                }
            };

            txtInFile.Click += (obj, args) =>
            {
                if(txtInFile.Text.TryTrim().Length > 0)
                    return;

                var ofd = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    CheckFileExists = true,
                    CheckPathExists = true
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var fi = new FileInfo(ofd.FileName);
                    txtInFile.Text = ofd.FileName;
                    txtOutFile.Text = $"{fi.FullName.Replace(fi.Extension, "")}.enc{fi.Extension}";
                }
            };

            txtOutFile.Click += (obj, args) =>
            {
                if (txtOutFile.Text.TryTrim().Length > 0)
                    return;

                var ofd = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    CheckFileExists = true,
                    CheckPathExists = true
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtOutFile.Text = ofd.FileName;
                }
            };

            rbEncrypt.Checked = true;
        }

        private async Task PopulateDrops()
        {
            await _settingsManager.GetSettings()
                .ContinueWith(async tsk =>
                {
                    var set = await tsk;
                    var symm = set.Keys.Where(k => k.KeyType == KeyType.Symmetric)
                                       .Select(ks => new { ks.Name, ks.Id })
                                       .ToList();

                    Invoke((MethodInvoker)delegate
                    {
                        cmbSym.DataSource = symm;
                        cmbSym.DisplayMember = "Name";
                        cmbSym.ValueMember = "Id";
                    });
                });
        }

        private async Task Encrypt(string inFile, string outFile, Guid symKeyId,  SettingsModel settings)
        {
            using (var fsOpen = File.Open(inFile, FileMode.Open))
            using (var fsWrite = File.Open(outFile, FileMode.Create))
            {
                var symm = settings.Keys.FirstOrDefault(k => k.Id == symKeyId);
                var pub = settings.Keys.FirstOrDefault(k => k.Id == symm?.AssociatedKey);
                var priv = settings.Keys.FirstOrDefault(k => k.Id == pub?.AssociatedKey);

                ttMain.Show("Encryption started...", rbEncrypt, 2000);
                await _cryptoManager.EncryptStream(fsOpen, fsWrite, priv?.Key, symm?.Key)
                    .ContinueWith(tsk => MessageBox.Show("Encryption Complete.", "Encryption Complete.", MessageBoxButtons.OK, MessageBoxIcon.Information));
            }
        }

        private async Task Decrypt(string inFile, string outFile, Guid symKeyId, SettingsModel settings)
        {
            using (var fsOpen = File.Open(inFile, FileMode.Open))
            using (var fsWrite = File.Open(outFile, FileMode.Create))
            {
                var symm = settings.Keys.FirstOrDefault(k => k.Id == symKeyId);
                var pub = settings.Keys.FirstOrDefault(k => k.Id == symm?.AssociatedKey);
                var priv = settings.Keys.FirstOrDefault(k => k.Id == pub?.AssociatedKey);

                ttMain.Show("Decryption started...", rbEncrypt, 2000);
                await _cryptoManager.DecryptStream(fsOpen, fsWrite, priv.Key, symm.Key)
                    .ContinueWith(tsk => MessageBox.Show("Decryption Complete.", "Decryption Complete.", MessageBoxButtons.OK, MessageBoxIcon.Information));
            }
        }
    }
}
