
namespace Model
{
    public class KY_018 : Sensor
    {
        private int brightness { get; set; }

        private Random rnd = new Random();

        public KY_018() { }

        public override int getValue()
        {
            return getBrightness();
        }

        public int getBrightness()
        {
            brightness = rnd.Next(0, 1023);
            Console.WriteLine($"Brightness: {brightness}");
            return brightness;
        }

        public override int[] getValues()
        {
            throw new NotImplementedException();
        }

        public override bool get_Value()
        {
            throw new NotImplementedException();
        }
    }
}
