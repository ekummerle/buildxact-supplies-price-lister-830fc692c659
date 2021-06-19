namespace buildxact_supplies
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
        public void LoadPrices()
        {

        }

        #endregion
    }
}
