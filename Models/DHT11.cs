
namespace Model
{
    public class DHT11 : Sensor
    {
        private Random rnd = new Random();

        public DHT11() { }
        public override int[] getValues()
        {
            int[] temperatureAndHumidity = new int[2];
            temperatureAndHumidity[0] = rnd.Next(25, 68);
            temperatureAndHumidity[1] = rnd.Next(20, 90);
            Console.WriteLine($"Temperature:  { temperatureAndHumidity[0] }°C");
            Console.WriteLine($"Humidity:  { temperatureAndHumidity[1] }%");
            return temperatureAndHumidity;
        }

        public override int getValue()
        {
            throw new NotImplementedException();
        }

        public override bool getValueBool()
        {
            throw new NotImplementedException();
        }
    }
}
