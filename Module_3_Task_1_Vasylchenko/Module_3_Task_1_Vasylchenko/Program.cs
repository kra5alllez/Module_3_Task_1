using System;

namespace Module_3_Task_1_Vasylchenko
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var l = new List<int>();
            l.Add(2);
            l.Add(4);
            l.Add(3);
            l.Add(7);
            l.Add(1);
            l.Add(3);
            var gg = new int[] { 2, 5, 9, 7, 3 };
            l.AddRange(gg);
            l.Remove(2);
            l.RemoveAt(2);
            l.Sort();
            foreach (var t in l)
            {
                Console.WriteLine(t);
            }
        }
    }
}
