using System.IO;
using Microsoft.Extensions.Configuration;

namespace MyTestCSharpProject1.Src.Utils.Config
{
	public class SettingsManager
    {
        private static IConfigurationRoot configuration;

        private static void Setup(string filename)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(filename, optional: false, reloadOnChange: true);

            configuration = builder.Build();

            //var section = configuration.GetSection(nameof(Environments)).Get<Environments>().ProdUk;
        }

        public static string GetValueByKey(string key, string filename = "appsettings.json")
        {
            Setup(filename);
            IConfigurationSection section = configuration.GetSection(key);

            return section.Value;
        }
    }
}
