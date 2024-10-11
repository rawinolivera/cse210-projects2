public class Product
{
  private string _productName;
  private string _productID;
  private double _productPrice;
  private int _quantity;

  public Product(string name, string id, double price, int qtt)
  {
    _productName = name;
    _productID = id;
    _productPrice = price;
    _quantity = qtt;
  }

  public double GetTotalPrice()
  {
    return _quantity * _productPrice;
  }

  public string ShowProduct()
  {
    return _productID + " : " + _productName + " : (" + _quantity + ")";
  }
}