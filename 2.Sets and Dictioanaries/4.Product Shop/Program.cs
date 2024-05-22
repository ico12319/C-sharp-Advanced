
var dictionary = new SortedDictionary<string, Shop>();

while (true)
{
    var tokens = Console.ReadLine().Split(", ");
    var shopName = tokens[0];

    if (shopName == "Revision")
        break;


    var productName = tokens[1];
    var price = double.Parse(tokens[2]);

    if (!dictionary.ContainsKey(shopName))
    {
        dictionary.Add(shopName, new Shop());
    }
    Product prod = new Product(productName, price);
    dictionary[shopName].addProduct(prod);
}

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key}->");
    item.Value.printShop();
}
Console.ReadKey();








public class Product
{
    public string shopName { get; private set; }
    public double Price { get; private set; }

    public Product() { }

    public Product(string shopName,double price)
    {
        this.shopName = shopName;
        this.Price = price;
    }

    public void printProduct()
    {
        Console.WriteLine($"Product: {shopName}, Price: {Price}");
    }
}

public class Shop
{
    List<Product> products;

    public Shop()
    {
        products = new List<Product>();
    }

    public Shop(List<Product> products)
    {
        products = new List<Product>();
        for (int i = 0; i < products.Count; i++)
        {
            this.products[i] = products[i];
        }
    }


    public void addProduct(Product product)
    {
        products.Add(product);
    }

    public void printShop()
    {
        for (int i = 0; i < products.Count; i++)
        {
            products[i].printProduct();
        }
    }




}
