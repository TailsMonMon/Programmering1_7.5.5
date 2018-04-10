using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._5._5 {
    class Program {
        static void Main(string[] args) {
            //  Menu
            Console.WriteLine("=== Welcome to Yatzy! ===");
            Console.WriteLine("[R]oll the dices!");
            Console.WriteLine("[E]nd game");
            Console.WriteLine();

            //  Variables
            char input = Convert.ToChar(Console.ReadLine());
            Random dice = new Random();
            int diceRoll = 5;

            if(input==82||input==114) {
                Console.WriteLine("ARRRRR");
            }

            Console.ReadLine();
        }
    }
}

            /*
             * Menu
             * [R]oll the dices
             * [E]nd
             * 
             * Variabels
             * input = menu choice
             * dice = random number generator
             * diceRoll = 5, how many rolls.
             * 
             * 
             * IF input is R
             *      then 
             *      diceroll--
             *      DO 
             *          dice random numbers 1-6
             *          write dice
             *      WHILE diceRoll is bigger than 0.
             * ELSE IF input is E
             *      close program
             * ELSE 
             *      show menu again
             */
