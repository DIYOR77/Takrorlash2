using System.Data.SqlTypes;

namespace Takrorlash2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Enter string: ");
            string str=Console.ReadLine();
            Engkupketmaketkelgan(str);
        }
        public static void Engkupketmaketkelgan(string str)
        {
            int count = 1;
            int max = 0;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == 'y')
                {
                        if (str[i] == str[i + 1])
                        {
                            count++;
                        }
                        else
                        {
                            if (max < count)
                            {
                                max = count;
                            }
                            count = 1;
                        }
                }
            }
            Console.WriteLine(" Eng ko'p ishlatilingan y soni  "+max);
        }
    }
}