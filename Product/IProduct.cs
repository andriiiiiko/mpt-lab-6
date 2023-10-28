namespace mpt_lab_6.Product;

/// <summary>
/// Interface defining the basic properties and methods for a product.
/// </summary>
public interface IProduct
{
    /// <summary>
    /// Retrieves the price of the product.
    /// </summary>
    /// <returns>The price of the product.</returns>
    double GetPrice();

    /// <summary>
    /// Retrieves the description of the product.
    /// </summary>
    /// <returns>The description of the product.</returns>
    string GetDescription();
}