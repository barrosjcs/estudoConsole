using System;
using System.Linq;

namespace PE4_MaiorNumPalindromoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maior número palindromo feito com o produto de numeros com 3 digitos
            DateTime timeIni = DateTime.Now;

            int modo = 2;
            bool parar = false;
            string produto = string.Empty;
            int palindromo = 0;

            if (modo == 1)
            {
                // Modo de fazer 1
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

                        if (result.SequenceEqual(palindromoChar))
                        {
                            parar = true;
                            break;
                        }
                    }

                    if (parar)
                        break;
                }
            }
            else if (modo == 2)
            {
                int palinAux = 999;
                // Modo de fazer 2
                while (!parar)
                {
                    palinAux--;
                    char[] result = new char[palinAux.ToString().Length];
                    char[] palindromoChar = palinAux.ToString().ToCharArray();

                    for (int x = 0, y = palinAux.ToString().Length - 1; x < palinAux.ToString().Length; x++, y--)
                        result[x] = palindromoChar[y];

                    palindromo = Convert.ToInt32(palinAux + new string(result));
                    for (int i = 999; i > 99; i--)
                    {
                        if (palindromo / i > 999 || i * i < palindromo)
                            break;
                        if (palindromo % i == 0)
                        {
                            parar = true;
                            produto = string.Format("{0} x {1}", palindromo / i, i);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Format("Maior número palindromo feito com o produto de números com 3 digitos: {0} = {1}", produto, palindromo));
            Console.WriteLine();
            TimeSpan ts = DateTime.Now - timeIni;
            Console.WriteLine(string.Format("Tempo: {0} s", ts.Seconds));
            // Resultado: 906.609

            Console.ReadKey();
        }
    }
}
