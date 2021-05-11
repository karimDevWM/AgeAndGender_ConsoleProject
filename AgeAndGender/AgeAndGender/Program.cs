using System;

namespace AgeAndGender
{
    class Program
    {
        static void Main(string[] args)
        {
            const int majorityAgeFR = 18;

            Console.WriteLine("input 'M' for men and 'W' for women");
            string gender = Console.ReadLine();
            while(gender != "M" && gender != "W")
            {
                gender = Console.ReadLine();
            }
            
            Console.WriteLine("input age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            while(age < 0)
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            
            if(gender.Equals("M") && age>=majorityAgeFR)
            {
                Console.WriteLine("Men");
            }
            else if(gender.Equals("W") && age>=majorityAgeFR)
            {
                Console.WriteLine("Women");
            }
            else if(gender.Equals("M") && age<majorityAgeFR)
            {
                Console.WriteLine("Boy");
            }
            else if(gender.Equals("f") && age<majorityAgeFR)
            {
                Console.WriteLine("Girl");
            }
        }
    }
}