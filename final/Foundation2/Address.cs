using System.Runtime.InteropServices;

public class Address
{
  private string _street;
  private string _city;
  private string _stateOrProvince;
  private string _country;

  public Address(string street, string city, string sto, string country)
  {
    _street = street;
    _city = city;
    _stateOrProvince = sto;
    _country = country;
  }

  public bool IsUsa()
  {
    return true;
  }

  public string GetFullAddress()
  {
    return _street + ", " + _city + ", " + _stateOrProvince + " - " + _country;
  }

  public string GetCountry()
  {
    return _country;
  }
}