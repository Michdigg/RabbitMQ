using Model;
using Producer;
using RabbitMQ.Client;
using System;
using System.Threading;

namespace RabbitMQ.Producer
{

    public class Producer
    {
        
        public static void Main(string[] args)
        {
            DHT11 dht11 = new DHT11();
            KY_018 kY_018 = new KY_018();
            KY_038 kY_038 = new KY_038();
            KY_024 kY_024 = new KY_024();
            HC_SR501_PIR hC_SR501_PIR = new HC_SR501_PIR();
            _6MV2 _6MV2 = new _6MV2();
            MPU6050 mPU6050 = new MPU6050();

            const string exchange_name = "amq.topic";                    
            ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost" };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            {
                channel.ExchangeDeclare(exchange: exchange_name,
                                        type: "topic", true);
                while (true)
                {
                    Publisher.publish(channel, exchange_name, dht11, kY_018, kY_024, kY_038, hC_SR501_PIR, _6MV2, mPU6050);
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Thread.Sleep(500);
                }

            }
        }

        
    }
}
