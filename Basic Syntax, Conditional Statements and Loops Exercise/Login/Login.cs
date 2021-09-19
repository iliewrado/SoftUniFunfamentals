using System;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            int counter = 1;
            int input = username.Length;
            string password = "";
            
            for (int i = input; i > 0; i--)
            {
                char count = username[i-1];
                password += count;
            }
            string correctPass = "";
            
            while (correctPass != password)
            {
                correctPass = Console.ReadLine();
                
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                if (correctPass != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                
                counter++;
            }
        }
    }
}
