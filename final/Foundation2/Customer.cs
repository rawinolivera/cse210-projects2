using System.Reflection.Metadata;

public class Customer
{
  private string _customerName;
  private Address _fullAddress;

  public Customer(string name, Address address)
  {
    _customerName = name;
    _fullAddress = address;
  }

  public bool IsUsa()
  {
    string country = _fullAddress.GetCountry();
    if (country == "United States" || country == "USA" || country == "united states" || country == "usa" || country == "US" || country == "us")
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public string ShowName()
  {
    return _customerName;
  }

  public string ShowFullAddress()
  {
    string address = _fullAddress.GetFullAddress();
    return address;
  }
}