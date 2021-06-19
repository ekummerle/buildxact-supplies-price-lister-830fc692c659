using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
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
            using TextReader textReader = new StreamReader(stream);

            using var csvReader = new CsvReader(textReader, CultureInfo.InvariantCulture);

            csvReader.Read();
            csvReader.ReadHeader();

            while (csvReader.Read())
            {
                var record = new PriceItem
                {
                    ID = csvReader.GetField<string>("identifier"),
                    Name = csvReader.GetField<string>("desc"),
                    Price = csvReader.GetField<decimal>("costAUD")
                };

                results.Add(record);
            }

            // Return the results.
            return results;
        }

        #endregion
    }
}
