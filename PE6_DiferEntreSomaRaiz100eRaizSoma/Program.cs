using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_DiferEntreSomaQuadrado100eQuadradoSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ache a diferença entre a soma do quadrado dos 100 primeiros números naturais e do quadrado desta soma.
            DateTime timeIni = DateTime.Now;

            int somaQuadrado = 0;
            int soma = 0;

            for (int i = 1; i < 101; i++)
            {
                somaQuadrado += i * i;
                soma += i;
            }

            Console.WriteLine(string.Format("Soma do quadrado dos 100 primeiros números naturais: {0}", somaQuadrado));
            Console.WriteLine();
            Console.WriteLine(string.Format("Quadrado da soma dos 100 primeiros números naturais: {0}", soma * soma));
            Console.WriteLine();
            Console.WriteLine(string.Format("Diferença entre a soma do quadrado dos 100 primeiros números naturais e do quadrado desta soma: {0}", soma * soma - somaQuadrado));
            Console.WriteLine();
            TimeSpan ts = DateTime.Now - timeIni;
            Console.WriteLine(string.Format("Tempo: {0} s", ts.Seconds));
            // Resultado: 25.164.150
            Console.ReadKey();
        }
    }
}
