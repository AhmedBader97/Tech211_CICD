
namespace FourPillarsApp
{
    public class Park
    {
        public int Swings { get; set; }
        public int RoundAbouts { get; set; }

        public string Name { get; set; }

        public string Location { get; set; } = "";

        public int Trees { get; set; }



        public Person ParkManager = new Person();
        public List<Person> people { get; set; }
    }
}
