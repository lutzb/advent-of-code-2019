namespace AdventOfCode2019.Day1
{
    public static class Day1
    {
        static void Main(string[] args)
        {
            int lineCount = 0;
            string line;

            var file = new System.IO.StreamReader(@"Day1/Day1-input.txt");
            while((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                lineCount++;
            }

            file.Close();
            System.Console.WriteLine($"There were {lineCount} lines.");
            System.Console.ReadLine();
        }
    }
}