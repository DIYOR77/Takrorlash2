using System.Data.SqlTypes;

namespace Takrorlash2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter massive size: ");
            int n=int .Parse(Console.ReadLine());
            int[]arr = new int[n];
            Fillmasiveand(arr);

        }
        public static void Fillmasiveand(int[]arr)
        {
            Random random= new Random();    
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=random.Next(10,99);
                Console.WriteLine(" "+i+" -> "+arr[i]);
            }
            Console.WriteLine();
            for (int i=0;i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (arr[i] % 2 == 1)
                    {
                        Console.WriteLine(" Juft indexda joylangan toq  element: " + arr[i] +" index: "+i);
                    }
                }
                else  if(i % 2 == 1)
                {
                    if (arr[i] %2 == 0)
                    {
                        Console.WriteLine(" Toq indexda joylangan juft  element: " + arr[i] + " index: " + i);
                    }
                } 
            }
            Console.WriteLine();
            for (int i=0;i<arr.Length;i++)
            {
                if (i % 2 == 0 && arr[i]%2==1)
                {
                        Console.Write($"{" "}{arr[i] = 0}");
                }
                else if (i % 2 == 1 && arr[i]%2==0)
                {
                        Console.Write($"{" "} {arr[i] = -1}");
                }
                else
                {
                    Console.Write(" "+arr[i]);
                }




            }
        }
    }

}
