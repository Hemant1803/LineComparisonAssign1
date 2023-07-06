namespace LineComparisonAssign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the first line (x1, y1, x2, y2):");
            double[] line1Cordinates = ReadCoordinates();

            double line1Length = CalculateLineLength(line1Cordinates);
            Console.WriteLine(line1Length);
        }

        static double[] ReadCoordinates()
        {
            string input = Console.ReadLine();
            string[] coordinateStrings = input.Split(',');

            double[] coordinates = new double[4];
            for (int i = 0; i < 4; i++)
            {
                coordinates[i] = double.Parse(coordinateStrings[i]);
            }

            return coordinates;
        }

        static double CalculateLineLength(double[] cordinates)
        {
            double x1 = cordinates[0];
            double y1 = cordinates[1];
            double x2 = cordinates[2];
            double y2 = cordinates[3];

            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            return length;
        }


    }
}