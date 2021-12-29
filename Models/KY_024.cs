
using System;

namespace Model
{
    public class KY_024 : Sensor
    {
        private int magnetic_field { get; set; }

        Random rnd = new Random();
        public KY_024() { }

        public override int getValue()
        {
            return getMagneticField();
        }

        public int getMagneticField()
        {
            magnetic_field = rnd.Next(0, 1023);
            Console.WriteLine($"Magnetic field: {magnetic_field}");
            return magnetic_field;
        }

        public override int[] getValues()
        {
            throw new NotImplementedException();
        }

        public override bool getBoolValue()
        {
            throw new NotImplementedException();
        }
    }
}
