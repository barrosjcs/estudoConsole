using System;
using System.Text;

namespace SomaFibonParAbaixo4milhoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma de valores fibonacci pares abaixo de 4000000
            DateTime timeIni = DateTime.Now;

            int ant, post, aux, soma;
            StringBuilder sb = new StringBuilder();

            ant = 1;
            post = 1;
            soma = 0;

            while(post <= 4000000)
            {
                aux = ant + post;
                ant = post;
                post = aux;

                if (post % 2 == 0)
                {
                    soma += post;
                    sb.AppendFormat("{0}, ", post.ToString());
                }
            }

            Console.WriteLine(string.Format("Fibonacci pares abaixo de 4000000: {0}", sb.ToString().Substring(0, sb.ToString().Length - 2)));
            Console.WriteLine();
            Console.WriteLine(string.Format("Soma destes números: {0}", soma));
            Console.WriteLine();
            TimeSpan ts = DateTime.Now - timeIni;
            Console.WriteLine(string.Format("Tempo: {0} s", ts.Seconds));
            // Resultado: 4.613.732
            Console.ReadKey();
        }
    }
}
