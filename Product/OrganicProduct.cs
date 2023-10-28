namespace mpt_lab_6.Product;

using System;

/// <summary>
/// Represents a type of product that is organic.
/// </summary>
public class OrganicProduct : Product 
{ 
    /// <summary>
    /// Gets or sets the production date of the organic product.
    /// </summary>
    public DateTime ProductionDate { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the organic product.
    /// </summary>
    public DateTime ExpiryDate { get; set; }

    /// <summary>
    /// Gets or sets the country of origin for the organic product.
    /// </summary>
    public Country CountryOfOrigin { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrganicProduct"/> class.
    /// </summary>
    /// <param name="name">The name of the organic product.</param>
    /// <param name="price">The price of the organic product.</param>
    /// <param name="description">The description of the organic product.</param>
    /// <param name="productionDate">The production date of the organic product.</param>
    /// <param name="expiryDate">The expiry date of the organic product.</param>
    /// <param name="countryOfOrigin">The country of origin for the organic product.</param>
    public OrganicProduct(string name, double price, string description, DateTime productionDate, DateTime expiryDate, 
        Country countryOfOrigin) : base(name, price, description)
    {
        ProductionDate = productionDate; 
        ExpiryDate = expiryDate; 
        CountryOfOrigin = countryOfOrigin;
    }

    /// <summary>
    /// Returns a string that represents the current organic product.
    /// </summary>
    /// <returns>A string that includes the basic product information along with production date, expiry date, and
    /// country of origin.</returns>
    public override string ToString()
    { 
        return base.ToString() + $", Production Date: {ProductionDate}, Expiry Date: {ExpiryDate}, Country of Origin: " +
               $"{CountryOfOrigin}";
    }
}