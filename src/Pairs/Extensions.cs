using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pairs
{
    public static class Extensions
    {
        static readonly Random _random = new Random();

        public static void Shuffle<T>(this List<T> list)
        {
            int count = list.Count;
            
            while (count > 1)
            {
                count--;

                var i = _random.Next(count + 1);
                T value = list[i];
                list[i] = list[count];
                list[count] = value;
            }
        }
    }
}