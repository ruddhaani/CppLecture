using System;

namespace OperatorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Status statusObj = new Status();

            Console.WriteLine("Enter your name to see if you are really him");
            string name = Console.ReadLine();

            Console.WriteLine("Let's see if you know his age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (name.ToLower().Trim() == statusObj.GetName().ToLower().Trim() && age == statusObj.GetAge())
            {
                Console.WriteLine("Okay you know him, let's move forward.");
            }
            else
            {
                Console.WriteLine("HAHAHA, YOU FAIL!");
                return;
            }

            Console.WriteLine("Let's see if you know his email id: ");
            string email = Console.ReadLine();

            Console.WriteLine("Let's see if you know his password: ");
            string password = Console.ReadLine();

            if (email.ToLower().Trim() != statusObj.GetEmailID().ToLower().Trim())
            {
                Console.WriteLine("Ahhh wrong email!!!!! You FAIL!");
            }
            else if (password != statusObj.GetPassword())
            {
                Console.WriteLine("Ahhh wrong password!!!!! You FAIL!");
            }
            else
            {
                Console.WriteLine("Ahhh right again!!!!! You PASS!");
            }

            Console.WriteLine("What's his Hobby?");
            string hobby = Console.ReadLine();

            Console.WriteLine("Who's his girlfriend?");
            string girlfriend = Console.ReadLine();

            if(hobby.ToLower().Trim() == statusObj.GetHobby().ToLower().Trim() || girlfriend.ToLower().Trim() == statusObj.GetGirlfriend().ToLower().Trim())
            {
                Console.WriteLine("Okay , you know him , you WINNNNN!!!");
            }
        }
    }
}
