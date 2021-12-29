
using Model;
using RabbitMQ.Client;
using System.Text;
using System;

namespace Producer
{
    public static class Publisher
    {
        public static void publish(IModel channel, String exchange_name, DHT11 dht11, KY_018 kY_018, KY_024 kY_024, KY_038 kY_038, HC_SR501_PIR hC_SR501_PIR, _6MV2 _6MV2, MPU6050 mPU6050)
        {
            int[] humidityAndTemperature = dht11.getValues();
            int[] inclinationAndSpeed = mPU6050.getValues();
            int[] coordinatesXandY = _6MV2.getValues();

            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.humidity", 
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("humidity " + humidityAndTemperature[1].ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.temperature",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("temperature " + humidityAndTemperature[0].ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.coordinateX",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("coordinateX " + coordinatesXandY[0].ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.coordinateY",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("coordinateY " + coordinatesXandY[1].ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.brightness",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("brightness " + kY_018.getValue().ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.magneticfield",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("magneticField " + kY_024.getValue().ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.volume",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("volume " + kY_038.getValue().ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.speed",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("speed " + inclinationAndSpeed[1].ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.inclination",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("inclination " + inclinationAndSpeed[0].ToString()));
            channel.BasicPublish(exchange: exchange_name,
                            routingKey: "amq.motion",
                            basicProperties: null,
                            mandatory: false,
                            body: Encoding.UTF8.GetBytes("motion " + hC_SR501_PIR.getBoolValue().ToString()));
        }
    }
}
