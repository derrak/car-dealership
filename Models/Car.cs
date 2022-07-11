
using System;

namespace Dealership.Models
{
  public class Car
  {
    //3 fields
    // private string _makeModel;
    // private int _price;
    // private int _miles;

    // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public string MakeModel //public property
    {
        get // a property accessor used to return the property value
        {
            return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!";
        }
        set // a property accessor used to assign a new value
        {
            _makeModel = value;
        }
    }

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    //     public void SetPrice(int newPrice)
    // {
    //   _price = newPrice;
    // }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }



  }
}