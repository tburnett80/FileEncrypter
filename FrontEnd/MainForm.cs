using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Crypto.Core.Lib.Contracts;
using FrontEnd.Contracts;
using FrontEnd.Models;
using Newtonsoft.Json;
using Unity;

namespace FrontEnd
{
    public partial class MainForm : Form
    {
        private readonly ICryptoManager _cryptoManager;
        private readonly ISettingsManager _settingsManager;


        private SettingsModel _settings;
        private readonly object _settingsLock = new object();
        private readonly string _settingsName = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Settings.json";

        public MainForm(ISettingsManager settingsManager, ICryptoManager cryptoManager)
        {
            _settingsManager = settingsManager ?? throw new ArgumentNullException(nameof(cryptoManager));
            _cryptoManager = cryptoManager ?? throw new ArgumentNullException(nameof(cryptoManager));

            //var settingTsk = _settingsManager.ReadSettings();

            InitializeComponent();

            rbEncrypt.CheckedChanged += (obj, args) =>
            {
                rbDecrypt.Checked = !rbEncrypt.Checked;
                btnSymAction.Text = rbEncrypt.Checked
                    ? rbEncrypt.Text
                    : rbDecrypt.Text;
            };

            btnSymAction.Click += (obj, args) =>
            {
                //TODO: impl sym encrypt / decrpyt
            };

            btnGen.Click += (obj, args) =>
            {
                using (var keyMgrForm = Program.Container.Resolve<KeyManager>())
                {
                    keyMgrForm.ShowDialog();
                }
            };

            rbEncrypt.Checked = true;

            //settingTsk.Wait();
            //_settings = settingTsk.Result;
        }

        #region Settings Management
        private void SaveSettings()
        {
            lock (_settingsLock)
            {
                var settings = JsonConvert.SerializeObject(_settings, Formatting.None);
                File.WriteAllBytes(_settingsName, Encoding.UTF8.GetBytes(settings));
            }
        }

        private void LoadSettings()
        {
            lock (_settingsLock)
            {
                if (File.Exists(_settingsName))
                {
                    var json = File.ReadAllBytes(_settingsName);
                    _settings = JsonConvert.DeserializeObject<SettingsModel>(Encoding.UTF8.GetString(json));
                }
                else
                {
                    _settings = new SettingsModel();
                }
            }
        }
        #endregion
    }
}
