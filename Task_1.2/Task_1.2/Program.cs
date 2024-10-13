namespace Task_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first 9 digits of the ISBN:");
            string input = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse(input[i].ToString());
                sum += (10 - i) * digit;
            }

            int checkDigit = 11 - (sum % 11);
            if (checkDigit == 10)
            {
                Console.WriteLine($"The full ISBN is: {input}X");
            }
            else if (checkDigit == 11)
            {
                Console.WriteLine($"The full ISBN is: {input}0");
            }
            else
            {
                Console.WriteLine($"The full ISBN is: {input}{checkDigit}");
            }
        }
    }
}
