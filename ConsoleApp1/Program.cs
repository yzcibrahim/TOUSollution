using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class CharValCount
    {
        public char CharVal { get; set; }
        public int CharCount { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BirinciYol();

        }

        
        private static void BirinciYol()
        {
            string deger = Console.ReadLine();
            Dictionary<char, int> degerlerCount = new Dictionary<char, int>();
            foreach(var item in deger)
            {
                if (degerlerCount.ContainsKey(item))
                {
                    degerlerCount[item]++;
                }
                else
                {
                    degerlerCount.Add(item, 1);
                }
            }

            foreach (var item in degerlerCount.Where(c => c.Value % 2 == 1))
            {
                Console.Write(item.Key.ToString());
            }


        }

        private static void IkinciYol()
        {
            string deger = Console.ReadLine();
            List<CharValCount> degerlerCount = new List<CharValCount>();

            foreach (var item in deger)
            {
                var existing = degerlerCount.FirstOrDefault(c => c.CharVal == item);
                if (existing!=null)
                {
                    degerlerCount.Add(new CharValCount() { CharVal = item, CharCount = 1 });
                }
                else
                {
                    existing.CharCount++;
                }
            }

            foreach (var item in degerlerCount.Where(c => c.CharCount % 2 == 1))
            {
                Console.Write(item.CharVal.ToString());
            }


        }
    }
}
