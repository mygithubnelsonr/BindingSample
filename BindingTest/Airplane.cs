using System.Collections.Generic;

namespace BindingTest
{
    public class Airplane
    {
        private static int lastID = 0;

        private int _id;
        private int _fuelKg;
        private string _model;
        private List<Passenger> _passengers = new List<Passenger>();

        public int ID { get { return _id; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int FuelLeftKg { get { return _fuelKg; } set { _fuelKg = value; } }
        public List<Passenger> Passengers { get { return _passengers; } }

        public Airplane()
        {
            _id = ++lastID;
        }
        public Airplane(string model, int fuelKg)
        {
            _id = ++lastID; _model = model; _fuelKg = fuelKg;
        }
    }
}
