using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Model
{
    public class KY_038
    {
        private int volume { get; set; }
        Random rnd=new Random();

        public KY_038()
        {

        }

        public int getVolume()
        {
            volume = rnd.Next(0,1023);
            Console.WriteLine($"Volume: {volume}");
            return volume;
        }

    }
}
