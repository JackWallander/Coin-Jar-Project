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
            int choice; bool breaker = true;
            //Coin coin1 = new Penny(4);
            //Coin coin2 = new Nickel(5);
            //Coin coin3 = new Dime(6);
            //Coin coin4 = new Quarter(7);
            //Coin[] coins = {coin1, coin2, coin3, coin4};
            //Console.WriteLine(CoinJar.Total(coins));
            while(breaker)
            Console.WriteLine("What type of coin would you like to add to the jar?");
            GUI.printGUI(types, 0, out choice);
            switch (choice)
            {
                case 0:
                    Coin penny = new Penny(0);
                    Console.WriteLine("How many pennies would you like to add?");
                    if (int.TryParse(Console.ReadLine(), out int coinNum))
                    {
                        penny.Count = coinNum;
                    }
                    CoinJar.AddCoin(penny);
                    break;
                case 1:

                case 2:

                case 3:
                    break;
                case 4:
                    breaker = false;
                    break;
            }


        }
    }
}
