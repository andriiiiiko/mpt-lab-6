namespace mpt_lab_6.Product;

public class Product : IProduct
{
    public readonly string Name;
    private int _price;
    private string _description;

    public Product(string name, int price, string description)
    {
        Name = name;
        _price = price;
        _description = description;
    }
    
    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(int price)
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
}