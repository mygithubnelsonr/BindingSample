namespace BindingTest
{
    public class Passenger
    {
        private static int lastID = 0;
        private int _id;
        public string _name;

        public int ID { get { return _id; } }
        public string Name { get { return _name; } set { _name = value; } }
        public Passenger(string name)
        {
            _id = ++lastID; _name = name;
        }

    }
}
