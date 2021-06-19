namespace SuppliesPriceLister
{
    /// <summary>
    /// The base class for all price loaders.
    /// </summary>
    public abstract class PriceLoaderBase
    {
        #region Variables

        /// <summary>
        /// The filename of the file to load.
        /// </summary>
        protected string filename;

        #endregion

        #region Constructor

        /// <summary>
        /// The constructor for the class.
        /// </summary>
        /// <param name="filename">The filename of the file to load from.</param>
        public PriceLoaderBase(string filename)
        {
            this.filename = filename;
        }

        #endregion
    }
}
