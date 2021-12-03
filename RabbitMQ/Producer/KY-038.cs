using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Producer
{
    public class KY_038: Sensors
    {
        private int volume { get; set; }
        Random rnd=new Random();

        public KY_038()
        {

        }

        public int getValues()
        {
            return getVolume();
        }

            public int getVolume()
        {
            volume = rnd.Next(0,1023);
            Console.WriteLine($"Volume: {volume}");
            return volume;
        }

    }
}
