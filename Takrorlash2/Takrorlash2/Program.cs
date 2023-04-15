using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Takrorlash2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter string: ");
            string str = Console.ReadLine();
            
            KattaXarf(str);
        }
        public static void KattaXarf(string str)
        {
            string[] strings = str.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Substring(0, 1).ToUpper() +
                     strings[i].Substring(1);

                Console.Write($"{strings[i]} ");
            }
        }
    }
}