using RabbitMQ.Client;
using System.Text;
using Model;
namespace RabbitMQ.Producer
{

    public class Producer
    {
        public static void Main(string[] args)
        {
            const String exchange_name = "amq.topic";
            ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())

            {
                channel.ExchangeDeclare(exchange: exchange_name,
                                        type: "topic", true);
                while (true)
                {

                    DHT11 dht11 = new DHT11();
                    KY_018 kY_018 = new KY_018();
                    KY_038 kY_038 = new KY_038();
                    KY_024 kY_024 = new KY_024();
                    HC_SR501_PIR hC_SR501_PIR = new HC_SR501_PIR();
                    _6MV2 _6MV2 = new _6MV2();
                    MPU6050 mPU6050 = new MPU6050();

                    int[] humidityAndTemperature =  dht11.getValues();
                    int[] inclinationAndSpeed = mPU6050.getValues();

                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.humidity",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(humidityAndTemperature[1].ToString()));
                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.temperature",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(humidityAndTemperature[0].ToString()));
                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.coordinates",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(_6MV2.getValues().ToString()));
                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.brightness",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(kY_018.getValue().ToString()));
                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.magneticfield",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(kY_024.getValue().ToString()));
                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.volume",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(kY_038.getValue().ToString()));
                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.speed",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(inclinationAndSpeed[1].ToString()));
                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.inclination",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(inclinationAndSpeed[0].ToString()));
                    channel.BasicPublish(exchange: exchange_name,
                                    routingKey: "amq.motion",
                                    basicProperties: null,
                                    mandatory: false,
                                    body: Encoding.UTF8.GetBytes(hC_SR501_PIR.get_Value().ToString()));
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Thread.Sleep(10000);
                }

            }
        }
    }
}
