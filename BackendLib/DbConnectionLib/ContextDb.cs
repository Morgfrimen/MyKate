using System.Configuration;
using System.IO;

using DbConnectionLib.Models;

using Microsoft.EntityFrameworkCore;

namespace DbConnectionLib
{
    public sealed class ContextDb : DbContext
    {
        public ContextDb()
        {
            GetStringConnection();
            _ = Database.EnsureCreated();
        }

        private string Connection { get; set; }
        public DbSet<Admin> Admins { get; set; }

#region Overrides of DbContext

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(Connection);

#endregion

        private void GetStringConnection()
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration
                (ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

            if (settings[nameof(Connection)] == null)
            {
                using StreamReader streamReader = new("ConnectionString.txt");
                Connection = streamReader.ReadToEnd();
                settings.Add(nameof(Connection), Connection);
                configFile.Save();
            }
            else
            {
                Connection = settings[nameof(Connection)].Value;
            }
        }
    }
}