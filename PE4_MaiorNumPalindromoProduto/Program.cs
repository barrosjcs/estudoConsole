using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_MaiorNumPalindromoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maior número palindromo feito com o produto de numeros com 3 digitos

            int palindromo = 0;
            string produto = string.Empty;
            bool parar = false;

            for (int i = 999; i > 99; i--)
            {
                for (int j = i; j > i - 100; j--)
                {
                    palindromo = i * j;
                    produto = string.Format("{0} x {1}", i, j);
                    char[] result = new char[palindromo.ToString().Length];
                    char[] palindromoChar = palindromo.ToString().ToCharArray();

                    for (int x = 0, y = palindromo.ToString().Length - 1; x < palindromo.ToString().Length; x++, y--)
                        result[x] = palindromoChar[y];
                    
                    if(result.SequenceEqual(palindromoChar))
                    {
                        parar = true;
                        break;
                    }
                }

                if (parar)
                    break;
            }

            Console.WriteLine(string.Format("Maior número palindromo feito com o produto de números com 3 digitos: {0} = {1}", produto, palindromo));
            Console.ReadKey();
        }
    }
}
