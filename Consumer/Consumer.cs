
using RabbitMQ.Client;
using System.Text;

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

        public static void Main()
        {
            
            while (true)
            {
                //Estabilishing connection with the broker
                ConnectionFactory connectionFactory = new ConnectionFactory { HostName = "localhost" };

                var connection = connectionFactory.CreateConnection();

                var channel = connection.CreateModel();

                //Consuming messages printing the body
                foreach(String queue in queues)
                {
                Console.WriteLine(" Consuming from " + queue + ": " + Encoding.UTF8.GetString(channel.BasicGet(queue, true).Body.ToArray()));                
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                Thread.Sleep(2000);
            }

        }
    }
}
