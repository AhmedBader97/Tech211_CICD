
namespace FourPillarsApp;

public abstract class Weapon : IShootable
{

    private string _brand;

    public string Brand { get { return _brand; } set { _brand = value; } }

   public Weapon(string brand)
    {
        _brand = brand;
    }


    public virtual string Shoot() 
    {

        return $"goes the {_brand}";
    
    }

    public string ToString()
    {
        return base.ToString();
    }


  
}


