
namespace Model
{
    public class MPU6050 : Sensors
    {
        private int inclination { get; set; }
        private int speed { get; set; }

        private Random rnd = new Random();

        public MPU6050() { }

        public override int[] getValues()
        {
            int[] values = new int[2];
            values[0] = getInclination();
            values[1] = getSpeed();
            return values;
        }
        public int getInclination()
        {
            inclination = rnd.Next(-35000, 35000);
            Console.WriteLine($"Inclination: {inclination}");
            return inclination;
        }

        public int getSpeed()
        {
            speed = rnd.Next(-35000, 35000);
            Console.WriteLine($"Speed: {speed}");
            return speed;
        }

        public override int getValue()
        {
            throw new NotImplementedException();
        }

        public override bool get_Value()
        {
            throw new NotImplementedException();
        }
    }
}
