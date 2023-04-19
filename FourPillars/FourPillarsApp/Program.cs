using static FourPillarsApp.Animal;

namespace FourPillarsApp
{
    public class Program
    {
        static void Main()
        {
            var laserGun = new LaserGun("laser gun 2023");
            var waterPistol = new WaterPistol("Water Pistol 2022");
            var slingShot = new SlingShot("Sling Sling 2021");
            var hunterAhmed = new Hunter("Ahmed", "Bader", waterPistol);
            var hunterPeter = new Hunter("Peter", "Belaby",slingShot);

            var cameraSamsung = new Camera("Samsung");
            var cameraPanasonic = new Camera("Panasonic");


            List<IShootable> weapons = new List<IShootable>() { laserGun, waterPistol, slingShot, cameraSamsung, cameraPanasonic, hunterAhmed, hunterPeter };


            foreach (var item in weapons)
            {
                Console.WriteLine(item.Shoot());
            }








            #region intro stuff
            //var andrew = new Person("Andrew", "Ma"); //instanation of person object called andrew
            //andrew.Age = 22;

            //Console.WriteLine(andrew.GetFullName());

            //var Ahmed = new Person("Ahmed", "Bader", 26);

            ////object initialiser

            //var patrick = new Person("Patrick", "Ardagh") { Age = 24, Height = 300 };
            //Park park = new Park() { RoundAbouts = 1, Swings = 10, ParkManager = new Person("Dave", "Davidson") };
            #endregion

            //Hunter test = new Hunter("ahmed", "bader", "kodak");
            //Console.WriteLine(test.ToString());

            //Airplane a = new Airplane(200, 100, "JetsRUs")

            //{ NumPassengers = 150 };

            //a.Ascend(500);

            //Console.WriteLine(a.Move(3));

            //Console.WriteLine(a);

            //a.Descend(200);

            //Console.WriteLine(a.Move());

            //a.Move();

            //Console.WriteLine(a);

            #region polyMorphism Demo
            //var myDog = new Dog();

            //var myCat = new Cat();

            //var myBird = new Bird();

            //Console.WriteLine(myDog.Speak());
            //Console.WriteLine(myCat.Speak());
            //Console.WriteLine(myBird.Speak());

            //Console.WriteLine("\nPolymorphism demo: \n");
            //List<Animal> animals = new List<Animal>() { myDog, myCat, myBird };


            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Speak());
            //}



            //Animal myAnimal;

            //string input = Console.ReadLine();

            //switch (input.ToLower())
            //{
            //    case "dog":
            //        myAnimal = new Dog();
            //        break;

            //    case "cat":
            //        myAnimal = new Cat();
            //        break;

            //    case "bird":
            //        myAnimal = new Bird();
            //        break;

            //    default:
            //        Console.WriteLine("Not an animal :(");
            //        myAnimal = null;
            //        break;
            //}

            //if (myAnimal is not null) Console.WriteLine(myAnimal.Speak());






            //Point3D point;
            //Point3D thereAlwaysABlankConstructor = new Point3D();
            //Point3D empty;

            //Hunter daniel = new Hunter("Daniel", "Manu","kodak");
            //Console.WriteLine(daniel.Shoot());

            //Hunter idris = new Hunter("Ahmed", "Idris", "Cannon");

            //    Console.WriteLine();

            //    List<Object> gameObjects = new List<object>()
            //    {
            //        //new AirPlane(15), not working as have not completed constucotr
            //        new Dog(),
            //        new Cat(),
            //        new Park(),

            //        new Vehicle()
            //    };

            //    foreach (var obj in gameObjects)
            //    {
            //        Console.WriteLine($"{obj}'s hashcode is {obj.GetHashCode()}");
            //        if (obj is Animal) //Console.WriteLine(obj.Speak()); wont work msut do the below

            //           //SpartaWrite(a);
            //        if (obj is Animal)
            //        {
            //            Animal a = (Animal)obj;
            //            Console.WriteLine(a.Speak());
            //        }
            //    }


            //    List<IMoveable> moveables = new()
            //        {
            //            new Person("Jacob", "Banyard"),
            //            new Hunter("Majid", "Laklouk", "Nikon"),
            //            new Vehicle(),
            //            new Airplane(25)
            //        };

            //    foreach (var m in moveables)
            //    {
            //        SpartaWrite(m.Move(2));
            //    }
            //}

            //public static void SpartaWrite(object obj)
            //{
            //    Console.WriteLine($"Sparta says:  {obj}");
            //}

            #endregion

        }
    }
}