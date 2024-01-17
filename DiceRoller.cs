using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two6dice
{
    internal class DiceRoller
    {
        // second class, DiceRoller, receives the numRolls from the first class
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
}
