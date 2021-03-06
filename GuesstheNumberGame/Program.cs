﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesstheNumberGame
{
    class Program
    {
        public static Random rand = new Random();
        public static int rightNum = rand.Next(1,1000);
        
        public static int userplay = 0;
        public static int startOver = 0;
        public static int counter = 0;

        public static void Guess(int guessedNum, int counter)
        {
          
            if (guessedNum > rightNum)
                Console.WriteLine("Too High, Try Again!");
            else if (guessedNum < rightNum)
                Console.WriteLine("Too Low, Try Again!");
            else
            {
                Console.WriteLine("Congratulations. You guessed the number!");

                userplay = 1;
                Console.WriteLine("Tries = " + counter);

                if (counter < 10)
                    Console.WriteLine("Either you know the secret or you got lucky!");
                else if (counter > 10)
                    Console.WriteLine("You should be able to do better!");
                else
                    Console.WriteLine("Aha! You know the secret!");

                Console.WriteLine("Do you want to play again ? Press 1 or Press any other number to quit");

                startOver = Convert.ToInt32(Console.ReadLine());
                if (startOver == 1)
                {
                    rightNum = rand.Next(1, 1000);
                    userplay = 0;
                    Console.WriteLine("Guess a number between 1 and 1000");
                    zeroCounter();
                }
            }
        }
        public static int zeroCounter()
        {
            return counter = 0;
        }
            
        
        static void Main(string[] args)
        {
            int num = 0;
            
            Console.WriteLine("Guess a number between 1 and 1000");
            
            while (userplay == 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                counter++;
                Guess(num, counter);
            }

            Console.ReadKey();
        }
    }
}
