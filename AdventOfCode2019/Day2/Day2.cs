namespace AdventOfCode2019.Day2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Day2
    {
        public static void Execute()
        {
            var allOperations = GetAllOperations();

            for (int i = 0; i < allOperations.Count; i += 4)
            {
                if (allOperations[i] == 99)
                {
                    break;
                }

                if (allOperations[i] == 1)
                {
                    // Add
                    var value1 = allOperations[i + 1];
                    var value2 = allOperations[i + 2];
                    var destination = allOperations[i + 3];
                    allOperations[destination] = allOperations[value1] + allOperations[value2];

                } else if (allOperations[i] == 2)
                {
                    // Multiply
                    var value1 = allOperations[i + 1];
                    var value2 = allOperations[i + 2];
                    var destination = allOperations[i + 3];
                    allOperations[destination] = allOperations[value1] * allOperations[value2];
                }

                Console.WriteLine();
                foreach (var op in allOperations)
                {
                    Console.Write($"{op},");
                }
                Console.WriteLine();
            }


            Console.Write("Done");
        }

        private static List<int> GetAllOperations()
        {
            var allOperations = new List<int>();
            string line;

            var file = new System.IO.StreamReader(@"Day2/Day2-input.txt");
            line = file.ReadLine();
            Console.WriteLine(line);
            file.Close();

            var listOfStrings = line.Split(',');

            return listOfStrings.Select(s => int.Parse(s)).ToList();
        }
    }
}