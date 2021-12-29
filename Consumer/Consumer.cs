using Consumer;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading;

namespace RabbitMQ.Consumer
{
    public class Consumer
    {
        private static String[] queues = new String[10]  
        {   "amq_brighthness",
            "amq_coordinateX",
            "amq_coordinateY",
            "amq_humidity",
            "amq_inclination",
            "amq_magneticfield",
            "amq_motion",
            "amq_speed",
            "amq_temperature",
            "amq_volume"
        };

        //Estabilishing connection with the broker
        private static ConnectionFactory connectionFactory = new ConnectionFactory { HostName = "localhost" };

        private static IConnection connection = connectionFactory.CreateConnection();

        private static IModel channel = connection.CreateModel();

        public static void Main()
        {
            
            while (true)
            {
                //Consuming messages printing the body
                //foreach(String queue in queues)
                //{
                //Console.WriteLine(" Consuming from " + queue + ": " + Encoding.UTF8.GetString(channel.BasicGet(queue, true).Body.ToArray()));                
                //}

                //Checking ATM status
                if (ATMLogic.checkATM())
                {
                    Console.WriteLine("Turning off...");
                    break;
                }

                Console.WriteLine("-----------------------------------------------------------------------");
                Thread.Sleep(2000);
            }
        }


        public static int consumeBrightness()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_brighthness", true).Body.ToArray()).ToString().Split()[1]);
        }

        public static int consumeCoordinateX()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_coordinateX", true).Body.ToArray()).ToString().Split()[1]);
        }

        public static int consumeCoordinateY()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_coordinateY", true).Body.ToArray()).ToString().Split()[1]);
        }

        public static int consumeHumidity()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_humidity", true).Body.ToArray()).ToString().Split()[1]);
        }

        public static int consumeInclination()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_inclination", true).Body.ToArray()).ToString().Split()[1]);
        }

        public static int consumeMagneticField()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_magneticfield", true).Body.ToArray()).ToString().Split()[1]);
        }

        public static bool consumeMotion()
        {
            if ((Encoding.UTF8.GetString(channel.BasicGet("amq_motion", true).Body.ToArray())).ToString() == "motion True")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static int consumeSpeed()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_speed", true).Body.ToArray()).ToString().Split()[1]);
        }

        public static int consumeTemperature()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_temperature", true).Body.ToArray()).ToString().Split()[1]);
        }

        public static int consumeVolume()
        {
            return int.Parse(Encoding.UTF8.GetString(channel.BasicGet("amq_volume", true).Body.ToArray()).ToString().Split()[1]);
        }
    }
}
