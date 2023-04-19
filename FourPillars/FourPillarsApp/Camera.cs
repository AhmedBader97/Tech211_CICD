namespace FourPillarsApp;

public class Camera : IShootable
{
    private string _brand;

    public string Brand { get { return _brand; } set { _brand = value; } }  

    public Camera(string brand)
    {
        _brand = brand;
    }

    public string Shoot()
    {
        return $"Shoots with {_brand} camera";
    }

    public string ToString()
    {
        return base.ToString();
    }
}
