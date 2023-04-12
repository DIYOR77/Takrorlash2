using System.Net;
using System.Security.AccessControl;

namespace Takrorlash2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter massive N: ");
            int N=int.Parse(Console.ReadLine());
            Console.Write(" Enter massive M: ");
            int M=int.Parse(Console.ReadLine());
            int[,]arr=new int[N,M];
            Fillmassiveand(arr,N,M);
        }
        public static void Fillmassiveand(int[,] arr,int N,int M)
        {
            Random random= new Random();
            for(int i = 0; i < N; i++)
            {
                for(int  j = 0; j < M; j++)
                {
                    arr[i,j]=random.Next(2,9);
                    Console.Write(" "+arr[i,j]);
                }
                Console.WriteLine();
            }
            int dioganalyigindi = 0;
            int oxirgiustun = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i == j) dioganalyigindi += arr[i, j];
                    if (j == M-1) oxirgiustun += arr[i, j];
                }
            }
            Console.WriteLine(" Dioganal yig'indisi: " + dioganalyigindi);
            Console.WriteLine(" Oxirgi ustun yig'indisi: " + oxirgiustun);
            if( dioganalyigindi > oxirgiustun)
            {
                Console.WriteLine (" True");
            }
            else
            {
                Console.WriteLine (" False");
            }

        }
    }
}