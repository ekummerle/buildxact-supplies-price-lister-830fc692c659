using System.Collections.Generic;
using System.Linq;

namespace buildxact_supplies
{
    /// <summary>
    /// A class to handle listing 
    /// </summary>
    public class PriceLister
    {
        #region Variables

        /// <summary>
        /// The list of loader config.
        /// </summary>
        private List<LoaderConfig> loaderConfigs = new List<LoaderConfig>();

        /// <summary>
        /// The exchange rate to use.
        /// </summary>
        private decimal exchangeRate;

        #endregion

        #region Properties

        /// <summary>
        /// Get/Set a list of price items.
        /// </summary>
        public List<PriceItem> Items { get; private set; } = new List<PriceItem>();

        #endregion

        #region Constructor
        
        /// <summary>
        /// The constructor for the class.
        /// </summary>
        /// <param name="loaderConfigs">The list of loader configs to use.</param>
        /// <param name="exchangeRate">The exchange rate to use.</param>
        public PriceLister(List<LoaderConfig> loaderConfigs, decimal exchangeRate)
        {
            this.loaderConfigs = loaderConfigs;
            this.exchangeRate = exchangeRate;
        }

        #endregion

        #region Functions

        /// <summary>
        /// A function to load all the items.
        /// </summary>
        /// <returns></returns>
        public void LoadPriceItems()
        {
            // Loop through all the loader configs.
            foreach (var config in loaderConfigs)
            {
                IPriceLoader loader = null;
                
                // Create the loader.
                switch (config.loader)
                {
                    case "HumphriesLoader":
                        loader = new HumphriesLoader(config.filename);
                        break;
                    case "MegaCorpLoader":
                        loader = new MegaCorpLoader(exchangeRate, config.filename);
                        break;
                }

                // If the loader has a value, load the prices and add them to the list.
                if (loader != null)
                {
                    Items.AddRange(loader.LoadPrices());
                }
            }

            // Order the list by price descending, i.e. high to low.
            Items = Items.OrderByDescending(i => i.Price).ToList();
        }

        #endregion
    }
}
