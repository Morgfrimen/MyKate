using System;
using System.Configuration;

using Grpc.Net.Client;

namespace ProtoConnectionLibWPF
{
    internal static class Cache
    {
        private static Guid _guidUser;

        private static string _urlServer;

        internal static GrpcChannel ChannelServer { get; set; }

        internal static Guid GuidUser
        {
            get => _guidUser;
            set => _guidUser = value;
        }

        internal static string UrlServer
        {
            get => _urlServer;
            set => _urlServer = value;
        }

        internal static void CloseChannel()
        {
            try
            {
                ChannelServer.Dispose();
            }
            catch { } //TODO:!!!!!!!!
        }

        private static void ReadOrWriteSettings(Configuration configFile,
                                                KeyValueConfigurationCollection settings,
                                                string key, string defaultValue, ref string field)
        {
            if (settings[key] == null)
            {
                //settings.Add(nameof(UrlServer), "https://localhost:5001");
                settings.Add(key, defaultValue);
                configFile.Save();
            }
            else
            {
                field = settings[key].Value;
            }
        }

        private static void ReadOrWriteSettings(Configuration configFile,
                                                KeyValueConfigurationCollection settings,
                                                string key, string defaultValue, ref Guid field)
        {
            string fieldStr = default;
            ReadOrWriteSettings(configFile, settings, key, defaultValue, ref fieldStr);
            field = Guid.Parse(fieldStr);
        }

        static Cache()
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration
                (ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;
            ReadOrWriteSettings
                (configFile, settings, nameof(UrlServer), "https://localhost:5001", ref _urlServer);
            ReadOrWriteSettings
                (configFile, settings, nameof(GuidUser), Guid.NewGuid().ToString(), ref _guidUser);
            ChannelServer = GrpcChannel.ForAddress(UrlServer);
        }
    }
}