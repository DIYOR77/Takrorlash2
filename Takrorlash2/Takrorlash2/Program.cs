using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Takrorlash2
{
    internal class Program
    {
           static string DectoHex(int decimalNumber)
            {
                string hexNumber;
                hexNumber = decimalNumber.ToString("X");
                return hexNumber;

            }

            static void Main(string[] args)
            {
                int decimalNumber;
                Console.Write("Enter the your number:");
                int.TryParse(Console.ReadLine(), out decimalNumber);
                Console.WriteLine(DectoHex(decimalNumber));
               
            }
    }

}

    
