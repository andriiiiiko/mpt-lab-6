namespace mpt_lab_6.Product;

public abstract class Product : IProduct
{
    public readonly string Name;
    private double _price;
    private string _description;

    public Product(string name, double price, string description)
    {
        Name = name;
        _price = price;
        _description = description;
    }
    
    public double GetPrice()
    {
        return _price;
    }

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
    
    public string GetDescription()
    {
        return _description;
    }

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

    public override string ToString()
    {
        return $"Product Name: {Name}, Price: {_price:C}, Description: {_description}";
    }
}