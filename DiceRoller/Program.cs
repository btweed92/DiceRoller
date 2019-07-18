using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello, would you like to roll the dice? (y/n)");
            string userAnswer = Console.ReadLine();

            bool rollAgain = true;
            while(rollAgain){

                if (userAnswer == "y")
                {
                    Console.WriteLine("How many sides are on your dice?");
                    int userSides = int.Parse(Console.ReadLine());

                    if ((userSides >= 1))
                    {


                        int roll1 = RollDice(userSides);

                        Console.WriteLine("Would you like to roll again?");
                        Console.ReadLine();
                        
                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                    }
                } else
                {
                    Console.WriteLine("Goodbye");
                }rollAgain = false;

            }
        }


        public static int RollDice(int userSides)
        {
            Random random = new Random();
            int roll1 = random.Next(1, userSides);
            int roll2 = random.Next(1, userSides);

            Console.WriteLine(roll1);
            Console.WriteLine(roll2);

            return roll1;

            
            

            
        }
        
    }
}
