namespace Takrorlash2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter massive N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write(" Enter massive M: ");
            int M = int.Parse(Console.ReadLine());
            int[,] arr = new int[N, M];
            Fillmassive(arr, N, M);
        }
        public static void Fillmassive(int[,] arr, int N, int M)
        {
            Random random = new Random();
            int massiveyigindisi = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = random.Next(-10, 10);
                    Console.Write("  " + arr[i, j]);
                    massiveyigindisi += arr[i, j];
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{" Masive elementlari yig'indisi: "}{massiveyigindisi}");
            Console.WriteLine($"{" Masive elementlari soni: "}{M * N}");
            if (massiveyigindisi > M * N)
            {
                Console.WriteLine(" True");
            }
            else
            {
                Console.WriteLine(" False");
            }

        }
    }
}