namespace Task_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number (a):");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number (b):");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers with exactly two symbols 'A' in duodecimal numerical system:");
            for (int i = a; i <= b; i++)
            {
                string duodecimal = ConvertToDuodecimal(i);
                if (CountSymbolOccurrences(duodecimal, 'A') == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static string ConvertToDuodecimal(int number)
        {
            string result = "";
            while (number > 0)
            {
                int remainder = number % 12;
                if (remainder == 10)
                {
                    result = "A" + result;
                }
                else if (remainder == 11)
                {
                    result = "B" + result;
                }
                else
                {
                    result = remainder.ToString() + result;
                }
                number /= 12;
            }

            return result == "" ? "0" : result;
        }

        static int CountSymbolOccurrences(string s, char symbol)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (c == symbol)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
