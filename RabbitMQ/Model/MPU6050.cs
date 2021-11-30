using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Model
{
    public class MPU6050
    {
        private int inclination { get; set; }
        private int speed { get; set; }
        private Random rnd = new Random();

        public MPU6050()
        {

        }

        public int[] getValue()
        {
            int[] value = new int[2];
            inclination = rnd.Next(-35000,35000);
            speed = rnd.Next(-35000, 35000);
            value[0] = inclination;
            value[1] = speed;
            Console.WriteLine($"Inclination: {inclination} , velocity: {speed}");
            return value;
        }

    }
}
