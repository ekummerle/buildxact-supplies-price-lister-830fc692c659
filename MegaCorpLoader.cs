namespace buildxact_supplies
{
    /// <summary>
    /// A class to handling loading a MageCorp file.
    /// </summary>
    public class MegaCorpLoader : PriceLoaderBase, IPriceLoader
    {
        #region Constructor

        /// <summary>
        /// The constructor for the class.
        /// </summary>
        /// <param name="filename">The filename of the file to load from.</param>
        public MegaCorpLoader(string filename) : base(filename)
        {

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
