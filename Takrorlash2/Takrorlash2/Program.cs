using System;

namespace Takrorlash2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter string: ");
            string str=Console.ReadLine();
            Xarflarnisanash(str);
            
        }
        public static void Xarflarnisanash(string str)
        {
            char[]arr = str.ToCharArray();
            Array.Sort(arr);
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (i == arr.Length-1  )
                {
                   Console.WriteLine($"{arr[i - 1]}: {count+1}");
                }
                if (arr[i] == arr[i - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{arr[i-1]}: {count}");
                    count = 1;
                }
            }
            


        }
    }
}