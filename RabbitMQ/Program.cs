using RabbitMQ.Client;
using RabbitMQ.Model;
using System.Text;

class TestClass
{
    public static void Main(string[] args)
    {
        const String exchange_name = "amq.topic";
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.ExchangeDeclare(exchange: "amq.topic",
                                    type: "topic", true);

            DHT11 dht11 = new DHT11();
            KY_018 kY_018 = new KY_018();
            KY_038 kY_038 = new KY_038();
            KY_024 kY_024 = new KY_024();
            HC_SR501_PIR hC_SR501_PIR = new HC_SR501_PIR();
            _6MV2 _6MV2 = new _6MV2();
            MPU6050 mPU6050 = new MPU6050();
            while (true)
            {
                channel.BasicPublish(exchange: exchange_name,
                                routingKey: "amq.humidity",
                                basicProperties: null,
                                mandatory:true,
                                body: Encoding.UTF8.GetBytes(dht11.getHumidity().ToString()));
                dht11.getTemperature();
                dht11.getHumidity();
                kY_018.getBrightness();
                kY_038.getVolume();
                kY_024.getMagneticField();
                hC_SR501_PIR.getMotion();
                _6MV2.getCoordinates();
                mPU6050.getValue();
                Console.WriteLine("-----------------------------------------------------------------------");
                Thread.Sleep(2000);

            }

        }
    }
}