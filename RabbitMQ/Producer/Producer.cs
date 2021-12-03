//using RabbitMQ.Client;
//using System.Text;
//namespace RabbitMQ.Producer
//{
    
//    public class Producer
//    {
//        public static void Main(string[] args)
//        {
//            const String exchange_name = "amq.topic";
//            var factory = new ConnectionFactory() { HostName = "localhost" };
//            using (var connection = factory.CreateConnection())
//            using (var channel = connection.CreateModel())

//            {
//                channel.ExchangeDeclare(exchange: exchange_name,
//                                        type: "topic", true);
//               ;                               
//                while (true)
//                {

//                    DHT11 dht11 = new();
//                    KY_018 kY_018 = new();
//                    KY_038 kY_038 = new();
//                    KY_024 kY_024 = new();
//                    HC_SR501_PIR hC_SR501_PIR = new();
//                    _6MV2 _6MV2 = new();
//                    MPU6050 mPU6050 = new();


//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.humidity",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(dht11.getValues().ToString()));
//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.temperature",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(dht11.getValue().ToString()));
//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.coordinates",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(_6MV2.getValues().ToString()));
//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.brightness",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(kY_018.getValues().ToString()));
//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.magneticfield",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(kY_024.getValues().ToString()));
//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.volume",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(kY_038.getValues().ToString()));
//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.speed",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(mPU6050.getValue().ToString()));
//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.inclination",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(mPU6050.getValues().ToString()));
//                    channel.BasicPublish(exchange: exchange_name,
//                                    routingKey: "amq.motion",
//                                    basicProperties: null,
//                                    mandatory: false,
//                                    body: Encoding.UTF8.GetBytes(hC_SR501_PIR.getValues().ToString()));
//                    Console.WriteLine("-----------------------------------------------------------------------");
//                    Thread.Sleep(2000);
//                }

//            }
//        }
//    }
//}
