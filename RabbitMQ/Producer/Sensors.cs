namespace RabbitMQ.Producer
{
    public abstract class Sensors
    {

        private int values { get; set; }
        private int value { get; set; }

        public int getValues()
        {
            return values;
        }

        public int getValue()
        {
            return value;
        }
       
    }
}
