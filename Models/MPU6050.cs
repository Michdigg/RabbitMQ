
namespace Model
{
    public class MPU6050 : Sensor
    {
        private Random rnd = new Random();

        public MPU6050() { }

        public override int[] getValues()
        {
            int[] inclinationAndSpeed = new int[2];
            inclinationAndSpeed[0] = rnd.Next(-35000, 35000); ;
            inclinationAndSpeed[1] = rnd.Next(-35000, 35000);
            Console.WriteLine($"Inclination: {inclinationAndSpeed[0]}");
            Console.WriteLine($"Speed: {inclinationAndSpeed[1]}");
            return inclinationAndSpeed;
        }

        public override int getValue()
        {
            throw new NotImplementedException();
        }

        public override bool getValueBool()
        {
            throw new NotImplementedException();
        }
    }
}
