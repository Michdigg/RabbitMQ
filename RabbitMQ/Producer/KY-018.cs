using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Producer
{
    public class KY_018: Sensors
    {
        private int brightness { get; set; }
        private Random rnd=new Random();

        public KY_018()
        {

        }
        public int getValues()
        {
            return getBrightness();
        }

        public int getBrightness() 
        {
            brightness = rnd.Next(0,1023);
            Console.WriteLine($"Brightness: {brightness}");
            return brightness;
        }

    }
}
