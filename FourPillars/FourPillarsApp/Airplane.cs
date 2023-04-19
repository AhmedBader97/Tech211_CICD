namespace FourPillarsApp
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;

        public int Altitude {
        get { return _altitude; } 
        private set { _altitude = value; } 
        
        }

        public Airplane() : base ()
        {
           
        }

        

        public Airplane(int capacity, int altitude) 
            : base(capacity)
        {
            _altitude = altitude;

        }

        

        public  Airplane(int capacity, int passengers, int speed, int position, int altitude) 
       
        {
            Speed = speed;
            
        }


        public string Ascend(int times,int altitude )
        {
            _altitude = altitude;
            return $"Moving along {times} times at an altitude of {altitude} meters.";


        }

        public void Descend(int distance)
        {

        }

        public string Move()
        {
            return "";
        }

        public override string Move(int times)
        {
            return times.ToString();
        }

        public override string ToString()
        {
            return ToString();
        }


    }
}
