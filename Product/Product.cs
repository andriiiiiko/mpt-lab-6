namespace mpt_lab_6.Product;

/// <summary>
/// Represents an abstract class for a product.
/// </summary>
public abstract class Product : IProduct
{
    /// <summary>
    /// Gets the name of the product.
    /// </summary>
    public readonly string Name;

    private double _price;
    private string _description;

    /// <summary>
    /// Initializes a new instance of the <see cref="Product"/> class.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="price">The price of the product.</param>
    /// <param name="description">The description of the product.</param>
    public Product(string name, double price, string description)
    {
        Name = name;
        _price = price;
        _description = description;
    }

    /// <summary>
    /// Gets the price of the product.
    /// </summary>
    /// <returns>The price of the product.</returns>
    public double GetPrice()
    {
        return _price;
    }

    /// <summary>
    /// Sets the price of the product.
    /// </summary>
    /// <param name="price">The price to set for the product.</param>
    public void SetPrice(double price) 
    {
        if (price > 0)
        {
            _price = price;
        }
        else 
        { 
            throw new ArgumentException("The price cannot be negative");
        }
    }

    /// <summary>
    /// Gets the description of the product.
    /// </summary>
    /// <returns>The description of the product.</returns>
    public string GetDescription() 
    { 
        return _description;
    }

    /// <summary>
    /// Sets the description of the product.
    /// </summary>
    /// <param name="description">The description to set for the product.</param>
    public void SetDescription(string description)
    { 
        if (description.Length > 0) 
        { 
            _description = description;
        }
        else 
        { 
            throw new ArgumentException("The description should be longer");
        }
    }

    /// <summary>
    /// Returns a string that represents the current product.
    /// </summary>
    /// <returns>A string that includes the product name, price, and description.</returns>
    public override string ToString() 
    { 
        return $"Product Name: {Name}, Price: {_price}, Description: {_description}";
    }
}