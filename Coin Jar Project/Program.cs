using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unit_5_Project;

namespace Coin_Jar_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] types = {"Penny", "Nickel", "Dime", "Quarter", "Exit"};
            int choice; bool breaker = true, breaker2 = true;
            //Coin coin1 = new Penny(4);
            //Coin coin2 = new Nickel(5);
            //Coin coin3 = new Dime(6);
            //Coin coin4 = new Quarter(7);
            //Coin[] coins = {coin1, coin2, coin3, coin4};
            //Console.WriteLine(CoinJar.Total(coins));
            while (breaker)
            {
                Console.WriteLine("What type of coin would you like to add to the jar?");
                GUI.printGUI(types, 0, out choice);
                Console.CursorVisible = true;
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("How many pennies would you like to add?");
                        while (breaker2)
                        {
                            if (int.TryParse(Console.ReadLine(), out int coinNum) && coinNum > 0)
                            {
                                Coin penny = new Penny(coinNum);
                                CoinJar.AddCoin(penny);
                                breaker2 = false;
                            }
                            else { Console.WriteLine("Invalid input please try again."); }
                        }
                        Console.WriteLine("Your current total is: " + CoinJar.Total());
                        breaker2 = true;
                        break;

                    case 1:
                        Console.WriteLine("How many nickels would you like to add?");
                        while (breaker2)
                        {
                            if (int.TryParse(Console.ReadLine(), out int coinNum) && coinNum > 0)
                            {
                                Coin nickel = new Nickel(coinNum);
                                CoinJar.AddCoin(nickel);
                                breaker2 = false;
                            }
                            else { Console.WriteLine("Invalid input please try again."); }
                        }
                        Console.WriteLine("Your current total is: " + CoinJar.Total());
                        breaker2 = true;
                        break;

                    case 2:
                        Console.WriteLine("How many dimes would you like to add?");
                        while (breaker2)
                        {
                            if (int.TryParse(Console.ReadLine(), out int coinNum) && coinNum > 0)
                            {
                                Coin dime = new Dime(coinNum);
                                CoinJar.AddCoin(dime);
                                breaker2 = false;
                            }
                            else { Console.WriteLine("Invalid input please try again."); }
                        }
                        Console.WriteLine("Your current total is: " + CoinJar.Total());
                        breaker2 = true;
                        break;

                    case 3:
                        Console.WriteLine("How many quarters would you like to add?");
                        while (breaker2)
                        {
                            if (int.TryParse(Console.ReadLine(), out int coinNum) && coinNum > 0)
                            {
                                Coin quarter = new Quarter(coinNum);
                                CoinJar.AddCoin(quarter);
                                breaker2 = false;
                            }
                            else { Console.WriteLine("Invalid input please try again."); }
                        }
                        Console.WriteLine("Your current total is: " + CoinJar.Total());
                        breaker2 = true;
                        break;

                    case 4:
                        breaker = false;
                        break;
                }

            }
        }
    }
}
