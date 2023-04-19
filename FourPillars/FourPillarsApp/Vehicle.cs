namespace FourPillarsApp
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        private int _numPassengers=-50;
        private int _position;
        private int _speed;

        public int Capacity { get { return _capacity; } set { _capacity = value; } }



        public Vehicle()  
        {
            _position = 100;
        }

        public Vehicle(int capacity, int speed = 10, int position =100)
        {
            _position = speed;
            _capacity = capacity;
            _speed = speed;

        }

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if (_numPassengers <= _capacity && _numPassengers > 0) { _numPassengers = value; } else { _numPassengers = 0; } }
        }
        public int Position 
        {
            get { return _position; }
            private set { _position = value; }
        
        } //read only
        public int Speed {
            get { return _speed; }
            init { _speed =  value ; }
        }

        public string Move()
        {
            return "Moving along";
        }
        public  virtual string Move(int times)
        {
           
            _position = 10 * times;
            return $"Moving along {times} times";
        }


    }
}
