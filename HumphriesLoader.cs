namespace buildxact_supplies
{
    /// <summary>
    /// A class to handle loading a Humphries file.
    /// </summary>
    public class HumphriesLoader : PriceLoaderBase, IPriceLoader
    {
        #region Constructor

        /// <summary>
        /// The constructor for the class.
        /// </summary>
        /// <param name="filename">The filename of the file to load from.</param>
        public HumphriesLoader(string filename) : base (filename)
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
