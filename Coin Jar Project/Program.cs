using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Jar_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coin coin1 = new Penny(4);
            Coin coin2 = new Nickel(5);
            Coin coin3 = new Dime(6);
            Coin coin4 = new Quarter(7);
            Coin[] coins = {coin1, coin2, coin3, coin4};
            Console.WriteLine(CoinJar.Total(coins));

            Console.WriteLine();
        }
    }
}
