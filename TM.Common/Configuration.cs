using Microsoft.Extensions.Configuration;
using System;

namespace TM.Common
{
    public static class Configuration
    {
        public static IConfiguration Config { get; set; }

        public static IConfigurationSection AppSettings
        {
            get
            {
                var section = Configuration.Config.GetSection("AppSettings");

                if (section == null)
                {
                    return null;
                }

                return section;
            }
        }

        public static string GetConnectionString(string key)
        {
            return Config.GetConnectionString(key);
        }
    }
}
