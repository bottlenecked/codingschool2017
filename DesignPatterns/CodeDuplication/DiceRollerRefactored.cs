using System;

namespace CodingSchool2017
{
    public class DiceRollerRefactored
    {
        public void RollDice()
        {
            var roll = Roll();
            Print($"You rolled a {roll}");
        }

        private int Roll() {
            return 4; //https://xkcd.com/221/
        }
        
        private void Print(string text) {
            Console.WriteLine(text);
        }
    }
}
