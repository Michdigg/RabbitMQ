using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Producer
{
    public class DHT11: Sensors
    {
        private int temperature { get; set; }
        private int humidity { get; set; }
        private Random rnd = new Random();

        public DHT11()
        {

        }
        public int getValue()
        {
            return getTemperature();
        }
        public int getValues()
        {
            return getHumidity();
        }

        public int getTemperature()
        {
            temperature= rnd.Next(25,68);
            Console.WriteLine($"Temperature:  { temperature }°C");
            return temperature;
        }

        public int getHumidity()
        {
            humidity = rnd.Next(20, 90);
            Console.WriteLine($"Humidity:  { humidity }%");
            return humidity;
        }
       
        
    }
}
