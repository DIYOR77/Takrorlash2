using System.Data.SqlTypes;

namespace Takrorlash2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[]arr=new int[rnd.Next(3,10)];
            Fillmassive(arr);

        }
        public static void  Fillmassive(int[] arr )
        {
            Random random = new Random();
            int indexmanfiy=0;
            Console.WriteLine(" <-> Massive <-> ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-5,10);
                Console.Write(" "+arr[i]);
            }
            Array.Sort(arr);
            Console.WriteLine();
            Console.WriteLine(" <-> Massive Sort <-> ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) 
                {
                indexmanfiy = i; 
                }
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine(" <-> Mavfiy elementlari <-> ");
           
            for (int i=0;i<=indexmanfiy; i++)
            {
                Console.Write(" " + arr[i]);    
            }

            Console.WriteLine();
            Console.WriteLine(" <-> Musbat elementlari <->");
            for (int i=indexmanfiy+1;i<arr.Length  ;i++) 
            {
                Console.Write(" " + arr[i]);
            }

        }

            
        
    }
}