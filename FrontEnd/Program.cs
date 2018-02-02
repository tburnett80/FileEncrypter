using System;
using System.Windows.Forms;
using Crypto.Core.Lib;
using Crypto.Core.Lib.Contracts;
using FrontEnd.Accessors;
using FrontEnd.Contracts;
using FrontEnd.Engines;
using FrontEnd.Managers;
using FrontEnds;
using Unity;
using Unity.Lifetime;

namespace FrontEnd
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<MainForm>());
        }

        private static IUnityContainer _container;
        internal static IUnityContainer Container
        {
            get
            {
                if (_container != null)
                    return _container;

                _container = InitContainer(new UnityContainer());
                return _container;
            }
        }

        private static IUnityContainer InitContainer(IUnityContainer container)
        {
            container.RegisterType<ISettingsAccessor, SettingsAccessor>(new ContainerControlledLifetimeManager());

            container.RegisterType<ICryptoEngine, CryptoEngine>(new ContainerControlledLifetimeManager());
            container.RegisterType<ISettingsEngine, SettingsEngine>(new ContainerControlledLifetimeManager());

            container.RegisterType<ICryptoKeyManager, CryptoManager>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICryptoManager, CryptoManager>(new ContainerControlledLifetimeManager());
            container.RegisterType<ISettingsManager, SettingsManager>(new ContainerControlledLifetimeManager());

            container.RegisterType<ImportKey>(new PerResolveLifetimeManager());
            container.RegisterType<ExportKey>(new PerResolveLifetimeManager());
            container.RegisterType<AsymmetricKey>(new PerResolveLifetimeManager());
            container.RegisterType<SymmertricKey>(new PerResolveLifetimeManager());
            container.RegisterType<KeyManager>(new PerResolveLifetimeManager());
            container.RegisterType<MainForm>(new PerResolveLifetimeManager());
    
            return container;
        }
    }
}
