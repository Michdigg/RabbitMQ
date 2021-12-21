
namespace Model
{
    public class _6MV2 : Sensor
    {
        private Random rnd = new Random();

        public _6MV2() { }

        /// <summary>
        /// Method that return x and y coordinates
        /// </summary>
        /// <returns>int[] values</returns>
        public override int[] getValues()
        {
            int[] coordinates = new int[2];
            coordinates[0] = rnd.Next(0, 100); 
            coordinates[1] = rnd.Next(0, 100); 
            Console.WriteLine($"X:  { coordinates[0] }");
            Console.WriteLine($"Y:  { coordinates[1] } ");
            return coordinates;
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
