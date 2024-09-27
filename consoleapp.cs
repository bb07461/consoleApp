namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXPLORING Variables
            string heroFirstName = "Blessing";
            string heroLastName = "Okogeri";
            string heroFullName;
            string villianTitle = "Darko Darkness";
            string minionTitle = "peewee";
            string villianName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;


            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the legendary hero of fashion programming, whose name is: " + heroFullName);

            villianName = "Trixie";
            minion1Name = "Joan";
            minion2Name = "Shoe";

            Console.WriteLine(heroFullName + "'s arch rivial is " + villianName + " the " + villianTitle);

           
            Console.WriteLine(villianName + " the " + villianTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);

            //fight prep!?
            Console.WriteLine("The fighters enter the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            //Time to fight!

            //Baddies attack our hero! Oh no!
            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Minions attack
            Console.WriteLine("The evil minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            //Take the current health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStrength + " damage!");
            //do math
            // Take the current health, subtract the damage then store the new value back into health
            // but this time lets use the combination assignment and arithmetic operator
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //Display results in the console
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //The minions have been defeated!
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //End of round buff!
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats an apple to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //final round of fight
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
            //Take the cuurent health, subtract the damage then store the new value back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks " + villianName + " the " + villianTitle + " for " + heroStrength + " damage!");
            //do math
            bossHealth = bossHealth - heroStrength;
            //Display results in the console
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");

            //Results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A+'s to the winner inded !");
        }
    }
}