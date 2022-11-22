using System;

namespace Practice_In_C_sharp
{
    internal class RandomDice
    {
        public static void RD()
        {
            //Random dice = new Random();
            //int roll = dice.Next(1000, 9999);
            //Console.WriteLine(roll);
            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);
        }
        public static void RD1()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
        }
        public static void RD2()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
        }
    }
}
