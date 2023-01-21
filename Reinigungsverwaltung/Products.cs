namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Products
{
    public int id { get; private set; }
    public string Name { get; set; }
    public DateTime ExpirationDate { get; set; }

    public Products(int id, string name, DateTime expirationDate)
    {
        this.id = id;
        Name = name;
        ExpirationDate = expirationDate;
    }

    public void AddProduct()
    {
        
    }
}