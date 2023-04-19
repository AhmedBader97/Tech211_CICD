using System.Xml.Linq;

namespace FourPillarsApp;

public abstract class Animal
{

    private string _name;

    public string Name { get; set; }
    public string kingdom { get; set; }

    public int Legs { get; set; } = 0;

    public DateTime Age { get; set; }
    public bool hasTail { get; set; }

    public Animal()
    {
        _name = "Bob";
    }


    public abstract string Speak();


    public virtual double Move()
    {
        return 0d;
    }

}

public class Cat : Animal
{
    public override string Speak()
    {
        return "Meow";
    }
}

public class Bird : Animal
{
    public override string Speak()
    {
        return "Cheep";
    }
}


public class Dog : Animal
{
    public double Speed { get; set; } = 10;
    public Dog() : base()
    {

    }
    public override string Speak()
    {
        return "Bark";
    }

    public override sealed double Move()  //cannot have sealed on its own, must have sealed and override, sealed is used to finalise a method that should not be overided or changed again
    {
        return Speed;
    }

}

