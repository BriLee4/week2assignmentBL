using System;

namespace week2assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 7;
            int ans1 = -1 + 4 * myVar;
            Console.WriteLine(ans1);
            int ans2 = (35 + 5) % myVar;
            Console.WriteLine(ans2);
            int ans3 = 14 + -4 * 6 / 12;
            Console.WriteLine(ans3);
            int ans4 = 2 + 12 / 6 * 1 - myVar % 2;
            Console.WriteLine(ans4);
            if (myVar * myVar > 10)
            {
                Console.WriteLine("myVar is less than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4");
            }    
        }
    }
}
