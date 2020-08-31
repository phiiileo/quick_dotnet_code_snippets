using System;
using System.Collections.Generic;

namespace quick_code_run
{
    public class FibonacciSequence
    {
        public FibonacciSequence()
        {
            var series = new List<int> { 1, 1 };
            for (int i = 0; series.Count < 20; i++)
            {
                var last_num = series[series.Count - 1];
                var last_num2 = series[series.Count - 2];
                series.Add(last_num + last_num2);
            }

            string l = null;
            foreach (var num in series)
            {
                l += $"{num} ";
            }
            Console.WriteLine(l);
        }
    }
}