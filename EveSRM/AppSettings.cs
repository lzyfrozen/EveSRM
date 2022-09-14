using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveSRM
{
    public class AppSettings
    {
        private static readonly IConfigurationRoot _config;

        static AppSettings()
        {
            var builder=new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
            _config=builder.Build();
        }

        public static string app(params string[] sections)
        {
            try
            {
                if (sections.Any())
                {
                    return _config[string.Join(":", sections)];
                }
            }
            catch (Exception) { }

            return string.Empty;
        }

        /// <summary>
        /// OrganizationId
        /// </summary>
        public static string OrganizationId => _config["OrganizationId"];

        /// <summary>
        /// WarehouseId
        /// </summary>
        public static string WarehouseId => _config["WarehouseId"];
    }
}
