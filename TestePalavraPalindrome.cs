using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePalindrome
{
    class Program
    {
        public static bool palindrome(string palavra)
        {
            char[] a = new char[palavra.Length];
            char[] b = new char[palavra.Length];
            int cont = 0;
            bool result = false;

            for (int x = 0; x < palavra.Length; x++)
            {
                a[x] = palavra[x];
            }

            for (int x = (palavra.Length-1); x >= 0; x--)
            {
                b[cont] = palavra[x];
                cont++;
            }

            for (int x = 0; x < palavra.Length; x++)
            {
                if(a[x]==b[x])
                {
                    result = true;
                }
                else
                {
                    result = result && false;
                }
            }
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra:");
            string palavra = Console.ReadLine();
            if(palindrome(palavra) == true)
            {
                Console.WriteLine("É palindrome");
            }
            else
            {
                Console.WriteLine("Não é palindrome");
            }
            Console.WriteLine("Aperte ENTER para sair");
            Console.ReadKey();
        }
    }
}
