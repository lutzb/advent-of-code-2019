namespace AdventOfCode2019.Day1
{
    using System;

    public static class Day1
    {
        static void Main(string[] args)
        {
            int totalFuel = 0;
            string line;

            var file = new System.IO.StreamReader(@"Day1/Day1-input.txt");
            while((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                var currentFuel = DoCalculation(Int32.Parse(line));
                totalFuel += currentFuel;

                var nextFuel = DoCalculation(currentFuel);
                while (nextFuel > 0)
                {
                    totalFuel += nextFuel;
                    nextFuel = DoCalculation(nextFuel);
                }
            }

            file.Close();
            System.Console.WriteLine(totalFuel);
            System.Console.ReadLine();
        }

        private static int DoCalculation(int i)
        {
            return Convert.ToInt32(Math.Floor((decimal) (i / 3))) - 2;
        }
    }
}