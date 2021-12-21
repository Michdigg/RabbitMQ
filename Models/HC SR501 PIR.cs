
namespace Model
{
    public class HC_SR501_PIR : Sensor
    {
        private Random rnd = new Random();

        public HC_SR501_PIR() { }
        public override bool getValueBool()
        {
            bool motion = rnd.NextDouble() >= 0.5;
            Console.WriteLine($"Motion:  { motion} ");
            return motion;
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
