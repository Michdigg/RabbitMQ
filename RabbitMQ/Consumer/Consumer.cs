using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace RabbitMQ.Consumer
{
    public class Consumer
    {
        public static void Main(string[] args)
        {
            const String exchange_name = "amq.topic";
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: exchange_name, type: "topic", true);
                var queueName = channel.QueueDeclare().QueueName;
                foreach (var bindingKey in args)
                {
                    channel.QueueBind(queue: "amq_speed",
                                     exchange: exchange_name,
                                     routingKey: "amq.speed");
                    channel.QueueBind(queue: "amq_inclination",
                                      exchange: exchange_name,
                                      routingKey: "amq.inclination");
                    channel.QueueBind(queue: "amq_humidity",
                                     exchange: exchange_name,
                                     routingKey: "amq.humidity");
                    channel.QueueBind(queue: "amq_temperature",
                                     exchange: exchange_name,
                                     routingKey: "amq.temperature");
                    channel.QueueBind(queue: "amq_coordinates",
                                     exchange: exchange_name,
                                     routingKey: "amq.coordinates");
                    channel.QueueBind(queue: "amq_brightness",
                                     exchange: exchange_name,
                                     routingKey: "amq.brightness");
                    channel.QueueBind(queue: "amq_magneticfield",
                                     exchange: exchange_name,
                                     routingKey: "amq.magneticfield");
                    channel.QueueBind(queue: "amq_volume",
                                     exchange: exchange_name,
                                     routingKey: "amq.volume");
                    channel.QueueBind(queue: "amq_motion",
                                     exchange: exchange_name,
                                     routingKey: "amq.motion");
                }
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    var routingKey = ea.RoutingKey;

                };
                channel.BasicConsume(queue: "amq_speed",
                                 autoAck: true,
                                 consumer: consumer);
                channel.BasicConsume(queue: "amq_inclination",
                                autoAck: true,
                                consumer: consumer);
                channel.BasicConsume(queue: "amq_humidity",
                                autoAck: true,
                                consumer: consumer);
                channel.BasicConsume(queue: "amq_temperature",
                                autoAck: true,
                                consumer: consumer);
                channel.BasicConsume(queue: "amq_coordinates",
                                autoAck: true,
                                consumer: consumer);
                channel.BasicConsume(queue: "amq_brighthness",
                                autoAck: true,
                                consumer: consumer);
                channel.BasicConsume(queue: "amq_magneticfield",
                                autoAck: true,
                                consumer: consumer);
                channel.BasicConsume(queue: "amq_volume",
                                autoAck: true,
                                consumer: consumer);
                channel.BasicConsume(queue: "amq_motion",
                                autoAck: true,
                                consumer: consumer);
                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }

        }
    }
}
