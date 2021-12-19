
namespace Model
{
    public class _6MV2 : Sensor
    {
        private int x { get; set; }
        private int y { get; set; }

        private Random rnd = new Random();

        public _6MV2() { }

        public override int[] getValues()
        {
            int[] values = new int[2];
            values[0] = getCoordinatex();
            values[1] = getCoordinatey();
            Console.WriteLine($"X:  { x }");
            Console.WriteLine($"Y:  { y } ");
            return values;
        }

        public int getCoordinatex()
        {
            x = rnd.Next(0, 100);
            return x;
        }

        public int getCoordinatey()
        {
            y = rnd.Next(0, 100);
            return y;
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
