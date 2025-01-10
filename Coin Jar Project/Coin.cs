using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Coin_Jar_Project
{
    internal abstract class Coin
    {
        public decimal Value { get; set; }
        public int Count { get; set; }
        public abstract decimal GetValue();
    }
    class Penny : Coin
    {
        public Penny(int amount)
        {
            Value = .01m;
            Count = amount;
        }
        public override decimal GetValue()
        {
            return Value * Count;
        }
    }
    class Nickel : Coin
    {
        public Nickel(int amount)
        {
            Value = .05m;
            Count = amount;
        }
        public override decimal GetValue()
        {
            return Value * Count;
        }
    }
    class Dime : Coin
    {
        public Dime(int amount)
        {
            Value = .1m;
            Count = amount;
        }
        public override decimal GetValue()
        {
            return Value * Count;
        }
    }
    class Quarter : Coin
    {
        public Quarter(int amount)
        {
            Value = .25m;
            Count = amount;
        }
        public override decimal GetValue()
        {
            return Value * Count;
        }
    }
    class CoinJar
    {
        List<Coin> coins = new List<Coin>();
        public static void AddCoin(Coin coin)
        {
            for (int i = 0; i < coin.Count; i++)
            {
                coins.Add(coin);
            }
        }
        public static decimal Total(Coin[] coins)
        {
            decimal total = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                total += coins[i].GetValue();
            }
            return total;
        }
    }
}
