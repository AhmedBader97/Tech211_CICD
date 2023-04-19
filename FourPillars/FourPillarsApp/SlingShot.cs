
namespace FourPillarsApp;

public class SlingShot : Weapon
{
   public SlingShot(string brand) :base(brand) 
    {

    }


    public override string Shoot()
    {
        return $"Thump!! {base.Shoot()}";

    }

   
}

