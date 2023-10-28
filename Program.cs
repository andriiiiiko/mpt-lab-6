using mpt_lab_6.Product;

namespace mpt_lab_6;

public class Program
{
    static void Main(string[] args)
    {
        // Creating instances of OrganicProduct
        OrganicProduct[] organicProducts = new OrganicProduct[5];

        // Let's assume today's date for demonstration purposes
        DateTime currentDate = DateTime.Now;

        // Creating instances of OrganicProduct and adding them to the array
        organicProducts[0] = new OrganicProduct("Organic Item 1", 10.99, "Description 1",
            currentDate, currentDate.AddYears(1), Country.Ukraine);
        organicProducts[1] = new OrganicProduct("Organic Item 2", 15.49, "Description 2",
            currentDate, currentDate.AddYears(2), Country.UnitedStates);
        organicProducts[2] = new OrganicProduct("Organic Item 3", 8.75, "Description 3",
            currentDate, currentDate.AddYears(1), Country.Canada);
        organicProducts[3] = new OrganicProduct("Organic Item 4", 12.25, "Description 4",
            currentDate, currentDate.AddYears(3), Country.Germany);
        organicProducts[4] = new OrganicProduct("Organic Item 5", 9.99, "Description 5",
            currentDate, currentDate.AddYears(2), Country.France);

        // Displaying the information of each OrganicProduct in the array
        foreach (OrganicProduct product in organicProducts)
        {
            Console.WriteLine(product);
        }
    }
}