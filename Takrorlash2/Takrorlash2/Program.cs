using System.Data.SqlTypes;

namespace Takrorlash2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a number: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write(" Enter b number: ");
            int b=int.Parse(Console.ReadLine());
            for (; a < b; a++)
            {
               soon(a);  
            }
            Main(args);
        }
    
        public static void soon(int a)
        {

            int a2 = a; 
                int count = 0;
                while (a2 > 0)
                {
                    int saqla2 = 0;
                    saqla2 = a2 % 10;
                    if (saqla2 % 2 == 1)
                    {
                        a2 = a2 / 10;
                        count++;
                    }
                    else
                    {
                        a2 = a2 / 10;
                    }

                }
            if (count == a.ToString().Length)
            {
                Console.WriteLine(a);
            }
           

        }
        
       
    }
}