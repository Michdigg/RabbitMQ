
namespace Model
{
    public class KY_018 : Sensor
    {
        private Random rnd = new Random();

        public KY_018() { }

        public override int getValue()
        {
            int brightness = rnd.Next(0, 1023);
            Console.WriteLine($"Brightness: {brightness}");
            return brightness;
        }

        public override int[] getValues()
        {
            throw new NotImplementedException();
        }

        public override bool getValueBool()
        {
            throw new NotImplementedException();
        }
    }
}
