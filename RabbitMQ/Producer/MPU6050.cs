using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Producer
{
    public class MPU6050 : Sensors
    {
        private int inclination { get; set; }
        private int speed { get; set; }
        private Random rnd = new Random();

        public MPU6050()
        {

        }
        public int getValue()
        {
            return getSpeed();
        }
        public int getValues()
        {
            return getInclination();
        }
        public int getInclination()
        {
            
            inclination = rnd.Next(-35000,35000);
            Console.WriteLine($"Inclination: {inclination}");
            return inclination;
        }

        public int getSpeed()
        {
            speed = rnd.Next(-35000, 35000);
            Console.WriteLine($"Speed: {speed}");
            return speed;
        }

    }
}
