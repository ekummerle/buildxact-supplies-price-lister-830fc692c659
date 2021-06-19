using System.Collections.Generic;
using System.IO;

namespace SuppliesPriceLister
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
        public List<PriceItem> LoadPrices()
        {
            // Set up the default results.
            var results = new List<PriceItem>();

            using Stream stream = GetType().Assembly.
                       GetManifestResourceStream($"SuppliesPriceLister.{filename}");
            using StreamReader sr = new StreamReader(stream);

            

            // Return the results.
            return results;
        }

        #endregion
    }
}
