using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Model
{
    public class HC_SR501_PIR
    {
        public bool turning_on { get; set; }
        private Random rnd = new Random();

        public HC_SR501_PIR()
        {

        }

        public bool getMotion()
        {
            turning_on = rnd.NextDouble() >= 0.5;
            Console.WriteLine($"Motion:  { turning_on }");
            return turning_on;
            
        }
    }
}
