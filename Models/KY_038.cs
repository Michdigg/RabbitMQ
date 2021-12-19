
namespace Model
{
    public class KY_038 : Sensors
    {
        private int volume { get; set; }

        Random rnd = new Random();

        public KY_038() {}

        public override int getValue()
        {
            return getVolume();
        }

        public int getVolume()
        {
            volume = rnd.Next(0, 1023);
            Console.WriteLine($"Volume: {volume}");
            return volume;
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
