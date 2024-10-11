public class Order
{
  private Customer _customer;
  private List<Product> _products;

  public Order(Customer customer)
  {
    _customer = customer;
    _products = new List<Product>();
  }

  public void GetTotalPrice()
  {
    double totalPrice = 0.00;
    if (_customer.IsUsa() == false)
    {
      totalPrice += 35; //shipping cost out of usa
    }
    else
    {
      totalPrice += 5; //shipping cost in usa
    }
    foreach (Product product in _products)
    {
      totalPrice += product.GetTotalPrice();
    }
    Console.WriteLine($"Total:   ${totalPrice}");
  }

  public void GetPackingLabel()
  {
    int index = 1;
    foreach (Product product in _products)
    {
      Console.WriteLine($"{index}- {product.ShowProduct()}");
      index++;
    }
  }

  public void GetShippingLabel()
  {
    Console.WriteLine($"Name:    {_customer.ShowName()}");
    Console.WriteLine($"Address: {_customer.ShowFullAddress()}");
  }

  public void AddProduct(string name, string id, double price, int qtt)
  {
    Product product = new Product(name, id, price, qtt);
    _products.Add(product);
  }
}