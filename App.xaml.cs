using Opc.Ua;
using Opc.Ua.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CygNet.Opc.Ua.AlarmSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static App Instance { get => Current as App; }
        public Session Session;

        private SessionManager _sessionMgr;

        public async void App_Startup(object sender, StartupEventArgs e)
        {
            await StartOpcuaSession();

            // Create main application window, starting minimized if specified
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private async Task StartOpcuaSession()
        {
            string username = ConfigurationManager.AppSettings["Username"];
            string password = ConfigurationManager.AppSettings["Password"];
            string endpointUrl = ConfigurationManager.AppSettings["EndpointUrl"];

            var user = new UserIdentity(username, password);
            _sessionMgr = new SessionManager();
            Session = await _sessionMgr.ConnectSessionAsync(endpointUrl, user);
        }
    }
}
