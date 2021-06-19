using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace SuppliesPriceLister
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            if (string.IsNullOrEmpty(config["audUsdExchangeRate"]))
            {
                Console.WriteLine("Cannot find the exchange range in the app settings file.");
                return;
            }

            if (!decimal.TryParse(config["audUsdExchangeRate"], out decimal exchangeRate))
            {
                Console.WriteLine("The exchange rate defined in the app settings file is invalid.");
            }

            var section = config.GetSection("loaders");

            var loaders = section.Get<List<LoaderConfig>>();

            var lister = new PriceLister(loaders, exchangeRate);

            lister.LoadPriceItems();
        }
    }
}
