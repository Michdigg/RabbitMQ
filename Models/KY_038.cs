
namespace Model
{
    public class KY_038 : Sensor
    {
        Random rnd = new Random();

        public KY_038() { }

        public override int getValue()
        {
            int volume = rnd.Next(0, 1023);
            Console.WriteLine($"Volume: {volume}");
            return volume;
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
