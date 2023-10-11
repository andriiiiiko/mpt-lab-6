namespace mpt_lab_6.Product;

public class OrganicProduct : Product
{
    public DateTime ProductionDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public Country CountryOfOrigin { get; set; }

    public OrganicProduct(string name, double price, string description, DateTime productionDate, DateTime expiryDate, 
        Country countryOfOrigin) : base(name, price, description)
    {
        ProductionDate = productionDate;
        ExpiryDate = expiryDate;
        CountryOfOrigin = countryOfOrigin;
    }

    public override string ToString()
    {
        return base.ToString() + $", Production Date: {{ProductionDate}}, Expiry Date: {{ExpiryDate}}, " +
               $"Country of Origin: {{CountryOfOrigin}}";
    }
}