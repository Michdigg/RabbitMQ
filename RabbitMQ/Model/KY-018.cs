using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Model
{
    public class KY_018
    {
        private int brightness { get; set; }
        private Random rnd=new Random();

        public KY_018()
        {

        }

        public int getBrightness() 
        {
            brightness = rnd.Next(0,1023);
            Console.WriteLine($"Brightness: {brightness}");
            return brightness;
        }

    }
}
