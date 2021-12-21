
namespace Model
{
    public class KY_024 : Sensor
    {
        Random rnd = new Random();
        public KY_024() { }

        public override int getValue()
        {
            int magnetic_field = rnd.Next(0, 1023);
            Console.WriteLine($"Magnetic field: {magnetic_field}");
            return magnetic_field;
        }

        public override int[] getValues()
        {
            throw new NotImplementedException();
        }

        public override bool getValueBool()
        {
            throw new NotImplementedException();
        }
    }
}
