using RabbitMQ.Client;
using RabbitMQ.Model;
using System.Text;

namespace RabbitMQ.Producer
{
    public class Producer
    {
        public static void Main(string[] args)
        {
            const String exchange_name = "amq.topic";
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: exchange_name,
                                        type: "topic", true);

            }
        }
    }
}
