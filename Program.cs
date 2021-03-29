using System;

namespace DiceRollingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRolling = true;
            int dieSides = 6;
            int numberofRoll = 0;

            Console.WriteLine("Welcome to the Grand Circus Casino");

            while (continueRolling)
            {
                numberofRoll = numberofRoll + 1;
                int die1 = Roll(dieSides);
                int die2 = Roll(dieSides);
                Console.WriteLine($"Roll {numberofRoll}:");
                Console.WriteLine($"You rolled a {die1} and a {die2} ({die1 + die2} total)");

                if (dieSides == 6)
                {
                    RollNumbers(die1, die2);
                }

                Console.WriteLine("Roll again? (y/n): ");
                string cont = Console.ReadLine();
                if (cont == "n" || cont == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    continueRolling = false;
                }
                else if (cont != "y" && cont != "Y")
                {
                    Console.WriteLine("Invalid selection. Please select y or n.");
                }

            }

            static int Roll(int dieSides)
            {
                dieSides = dieSides + 1;
                Random dieRoll = new Random();
                int die = dieRoll.Next(1, dieSides);
                return die;
            }

            static void RollNumbers(int die1, int die2)
            {
                if (die1 + die2 == 2)
                {
                    Console.WriteLine("Snake Eyes!");
                }
                if (die1 == 1 && die2 == 2 || die1 == 2 && die2 == 1)
                {
                    Console.WriteLine("Ace Deuce!");
                }
                if (die1 == 6 && die2 == 6)
                {
                    Console.WriteLine("Box Cars!");
                }
                if (die1 + die2 == 7 || die1 + die2 == 11)
                {
                    Console.WriteLine("Win!");
                }
                if (die1 + die2 == 2 || die1 + die2 == 3 || die1 + die2 == 12)
                {
                    Console.WriteLine("Craps!");
                }
            }
        }
    }
}
 



