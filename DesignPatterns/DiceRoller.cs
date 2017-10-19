using System;

namespace CodingSchool2017
{
    public class DiceRoller
    {
        public void RollDice()
        {
            var roll = Roll();
            if (roll == 1)
                Print("You rolled a 1");
            else if (roll == 2)
                Print("You rolled a 2");
            else if (roll == 3)
                Print("You rolled a 3");
            else if (roll == 4)
                Print("You rolled a 4");
            else if (roll == 5)
                Print("You rolled a 5");
            else if (roll == 6)
                Print("You rolled a 6");
        }

        private int Roll() {
            return 4; //https://xkcd.com/221/
        }
        
        private void Print(string text) {
            Console.WriteLine(text);
        }
    }
}
