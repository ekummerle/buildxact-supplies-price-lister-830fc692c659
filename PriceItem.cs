namespace SuppliesPriceLister
{
    /// <summary>
    /// A class for handling prices.
    /// </summary>
    public class PriceItem
    {
        #region Properties

        /// <summary>
        /// Get/Set the ID of the item.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Get/Set the Name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get/Set the Price of the item.
        /// </summary>
        public decimal Price { get; set; }

        #endregion

        #region Functions

        /// <summary>
        /// Override the ToString method.
        /// </summary>
        /// <returns>The string to use for displaying the data.</returns>
        public override string ToString()
        {
            return $"{ID}, {Name}, ${Price:2F}";
        }

        #endregion
    }
}
