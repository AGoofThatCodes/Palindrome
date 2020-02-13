using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A number to check Palindrome");
            int number = int.Parse(Console.ReadLine());
            int reminder, sum = 0;
            int temp = number;

            while (number > 0)
            {
                //get the reminder by dividing number by 10
                reminder = number % 10;

                //multiplu the sum with 10 and them add the reminder
                sum = (sum * 10) + reminder;
                //get quotient by dividing the number with 10
                number = number / 10;
            }

            if(temp == sum)
            {
                Console.WriteLine($"Number  {temp} is Palindrom.");
            }
            else
            {
                Console.WriteLine($"number {temp} is not Palindrom");
            }
            Console.ReadKey();
        }
    }
}
