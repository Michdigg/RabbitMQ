
namespace Model
{
    public class DHT11 : Sensors
    {
        private int temperature { get; set; }
        private int humidity { get; set; }

        private Random rnd = new Random();

        public DHT11() {}
        public override int[] getValues()
        {
            int[] values = new int[2];
            values[0] = getHumidity();
            values[1] = getTemperature();
            Console.WriteLine($"Temperature:  { temperature }°C");
            Console.WriteLine($"Humidity:  { humidity }%");
            return values;
        }
        

        public int getTemperature()
        {
            temperature = rnd.Next(25, 68);
            return temperature;
        }

        public int getHumidity()
        {
            humidity = rnd.Next(20, 90);
            return humidity;
        }

        public override int getValue()
        {
            throw new NotImplementedException();
        }

        public override bool get_Value()
        {
            throw new NotImplementedException();
        }
    }
}
