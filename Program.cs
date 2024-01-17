// Christian Breshears
// IS 413 sec 4-2
// Description:
// This program simulates two dice being rolled X number of times, given by the user.
// It then prints out the % for each combination of rolls.


using System;

namespace two6dice;
class firstClass
{
    static void Main()
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.Write("How many dice rolls would you like to simulate? ");

        // Get user input for the number of rolls
        int numRolls = int.Parse(System.Console.ReadLine());

        // Create an instance of the DiceRoller class and simulate the rolls
        DiceRoller roller = new DiceRoller();
        int[] results = roller.SimulateRolls(numRolls);

        // Print the histogram
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numRolls + '.');


        // this loop initiates after the diceroller class is finished.
        // It does math and adds the correct number of asterisks for each roll
        for (int i = 2; i <= 12; i++)
        {
            // iterate through each position of the array and do math
            int percentage = results[i] * 100 / numRolls;

            // add the correct number of asterisks for each position in the array
            System.Console.WriteLine($"{i}: {new string('*', percentage)}");
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}


// second class, DiceRoller, receives the numRolls from the first class

/*
class DiceRoller
{
    private readonly Random random = new Random();

    public int[] SimulateRolls(int numRolls)
    {
        // create array
        int[] results = new int[13]; 

        // create a loop and simulate the number of dice rolls the user entered. 
        for (int i = 0; i < numRolls; i++)
        {
            // two dice. rng for each one then add them together
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            // whatever the sum of the dice, increment that combo by 1
            results[sum]++;
        }
        // return the entire array once its done iterating through numRolls
        return results;
    }
}

*/