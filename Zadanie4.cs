using System;
using System.Collections;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList() { 1, 13, 3.3, "a", 0, 15, "X", "q", 27, 111, "t", "j", 33, 17, 4 };
            ArrayList objUpper = new ArrayList(100);

            for (int i = 0; i < obj.Count; i++)
            {
                Console.Write(obj[i] + " | ");
            }
            Console.WriteLine();

            for (int i = 0; i < obj.Count; i++)
            {
                if (obj[i] is string)
                {
                    obj.RemoveAt(i);
                    if (obj[i] is string) i--;
                }
            }

            for (int i = 0; i < obj.Count; i++)
            {
                Console.Write(obj[i] + " | ");
            }
        }
    }
}