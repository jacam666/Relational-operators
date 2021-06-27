using System;

namespace Relational_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 19)
            {
                Console.WriteLine("You qualify, Please take your kindle");
            }
            else
            {
                Console.WriteLine("Damn so unlucky, you are way to old. YOU GET NOTHING!!!!!");
            }
        }
    }
}
