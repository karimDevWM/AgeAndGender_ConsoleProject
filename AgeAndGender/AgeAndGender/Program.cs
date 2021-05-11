using System;

namespace AgeAndGender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saisir h pour homme ou f pour femme : ");
            string genre = Console.ReadLine();
            Console.WriteLine("saisir age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(genre.Equals("h") && age>=10)
            {
                Console.WriteLine("homme");
            }
            else if(genre.Equals("f") && age>=18)
            {
                Console.WriteLine("femme");
            }
            else if(genre.Equals("h") && age<18)
            {
                Console.WriteLine("garçon");
            }
            else if(genre.Equals("f") && age<18)
            {
                Console.WriteLine("fille");
            }
            else
            {
                Console.WriteLine("pas compris");
            }
        }
    }
}