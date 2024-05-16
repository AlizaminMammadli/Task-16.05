using System.Runtime.InteropServices;

namespace odd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10; 
            int number2 = 20;
            int oddCount = 0;

            if (number1 > number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }

            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 != 0)
                {
                    oddCount++;
                }
            }
            Console.WriteLine($"Count of odd numbers between {number1} and {number2}: {oddCount}");
        }
    }
}
