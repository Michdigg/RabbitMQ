
using System;

namespace Model
{
    public class HC_SR501_PIR : Sensor
    {
        public bool turning_on { get; set; }

        private Random rnd = new Random();

        public HC_SR501_PIR() { }
        public override bool getBoolValue()
        {
            return getMotion();
        }
        public bool getMotion()
        {
            turning_on = rnd.NextDouble() >= 0.5;
            Console.WriteLine($"Motion:  { turning_on }");
            return turning_on;

        }

        public override int[] getValues()
        {
            throw new NotImplementedException();
        }

        public override int getValue()
        {
            throw new NotImplementedException();
        }
    }
}
