using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace CygNet.Opc.Ua.AlarmSample
{
    public class SessionManager
    {
        private readonly int ReconnectPeriod = 10;

        public SessionManager()
        {
        }

        private SessionReconnectHandler _reconnectHandler;
        private Session _session;

        public async Task<Session> ConnectSessionAsync(string endpointUrl, UserIdentity user)
        {
            // Create an Application Configuration
            ApplicationInstance application = new ApplicationInstance
            {
                ApplicationName = "CygNet OPC UA Alarm Sample",
                ApplicationType = ApplicationType.Client,
                ConfigSectionName = "OpcUa.AlarmSample"
            };

            // load the application configuration.
            ApplicationConfiguration config = await application.LoadApplicationConfiguration(false);
            config.CertificateValidator.CertificateValidation += ValidateCertificate;

            // Discover endpoints of server
            var selectedEndpoint = CoreClientUtils.SelectEndpoint(endpointUrl, false, 15000);

            // Create a session with OPC UA server
            var endpointConfiguration = EndpointConfiguration.Create(config);
            var endpoint = new ConfiguredEndpoint(null, selectedEndpoint, endpointConfiguration);
            //var cert = new X509Certificate2(@"C:\cert\RootCaClientTest.pfx", "password"); // for using certificate authentication
            _session = await Session.Create(config, endpoint, false, "OPC UA Alarm Sample Client", 60000, user, null);

            // register keep alive handler
            _session.KeepAlive += KeepAlive;

            return _session;
        }

        private void ValidateCertificate(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            // Validate server certificate
            if (e.Error.StatusCode != StatusCodes.Good)
            {
                // In production use you would validate the server certificate here to ensure that it is trusted
                e.Accept = true; 
            }
        }

        private void KeepAlive(Session sender, KeepAliveEventArgs e)
        {
            if (e.Status != null && ServiceResult.IsNotGood(e.Status))
            {
                if (_reconnectHandler == null)
                {
                    _reconnectHandler = new SessionReconnectHandler();
                    _reconnectHandler.BeginReconnect(sender, ReconnectPeriod * 1000, OnReconnectComplete);
                }
            }
        }

        private void OnReconnectComplete(object sender, EventArgs e)
        {
            // ignore callbacks from discarded objects.
            if (!ReferenceEquals(sender, _reconnectHandler))
            {
                return;
            }

            _session = _reconnectHandler.Session;
            _reconnectHandler.Dispose();
            _reconnectHandler = null;
        }
    }
}
