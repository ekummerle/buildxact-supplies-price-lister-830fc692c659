using System.Collections.Generic;

namespace buildxact_supplies
{
    /// <summary>
    /// A class to handle listing 
    /// </summary>
    public class PriceLister
    {
        #region Properties

        /// <summary>
        /// Get/Set a list of price items.
        /// </summary>
        public List<PriceItem> Items { get; private set; } = new List<PriceItem>();

        #endregion

        #region Functions

        /// <summary>
        /// A function to load all the items.
        /// </summary>
        /// <returns></returns>
        public void LoadPriceItems()
        {
        }

        #endregion
    }
}
