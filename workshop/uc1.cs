using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    class uc1
    { 
        //making array//
        public static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        // create board method//
        public static void BoardMethod()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("     |     |      ");
        }
        public void Choose()
        {
            int player = 1;
            Console.WriteLine("Player 1 : X ");
            Console.WriteLine("Player 2 : O ");
            if (player % 2 == 0)  
            {
                Console.WriteLine("option press for player 1");
                Console.WriteLine("Player 1");
            }
            else
            {
                Console.WriteLine("option press for player 2");
                Console.WriteLine("Player 2");
            }
        }

    }
}
