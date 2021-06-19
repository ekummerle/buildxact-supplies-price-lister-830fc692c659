using System.Collections.Generic;

namespace SuppliesPriceLister
{
    /// <summary>
    /// An interface for loading prices.
    /// </summary>
    public interface IPriceLoader
    {
        #region Functions

        /// <summary>
        /// A function to load the prices from file.
        /// </summary>
        List<PriceItem> LoadPrices();

        #endregion
    }
}
