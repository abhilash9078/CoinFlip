﻿using System;

namespace CoinFlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Coin Flip Program");
            int heads = 0;
            int tails = 0;
           
            Console.WriteLine("Enter the Coin flipping operation range: ");
            int count=int.Parse(Console.ReadLine());
            while (count > 0)
            {
                Random rand = new Random();
                int randomCheck = rand.Next(2);
                if (randomCheck == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
                count--;
            }
            Console.WriteLine("Number of heads is: "+heads);
            Console.WriteLine("Number of Tails is: "+tails);
        }
    }
}
