using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace SuppliesPriceLister
{
    /// <summary>
    /// A class to handling loading a MageCorp file.
    /// </summary>
    public class MegaCorpLoader : PriceLoaderBase, IPriceLoader
    {
        #region Variables

        /// <summary>
        /// The exchange rate to use when working out prices.
        /// </summary>
        private decimal exchangeRate;

        #endregion

        #region Constructor

        /// <summary>
        /// The constructor for the class.
        /// </summary>
        /// <param name="exchangeRate">The exchange rate to use.</param>
        /// <param name="filename">The filename of the file to load from.</param>
        public MegaCorpLoader(decimal exchangeRate, string filename) : base(filename)
        {
            this.exchangeRate = exchangeRate;
        }

        #endregion

        #region Functions

        /// <summary>
        /// A function to load the prices from file.
        /// </summary>
        public List<PriceItem> LoadPrices()
        {
            // Set up the default results.
            var results = new List<PriceItem>();

            using Stream stream = GetType().Assembly.
                       GetManifestResourceStream($"SuppliesPriceLister.{filename}");
            using StreamReader sr = new StreamReader(stream);

            using (JsonTextReader reader = new JsonTextReader(sr))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);

                foreach (var partner in o2["partners"])
                {
                    foreach (var record in partner["supplies"])
                    {
                        var item = new PriceItem
                        {
                            ID = record["id"].ToString(),
                            Name = record["description"].ToString(),
                            Price = decimal.Parse(record["priceInCents"].ToString())
                        };

                        results.Add(item);
                    }
                }
            }

            // Return the results.
            return results;
        }

        #endregion
    }
}
