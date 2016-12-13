using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomaMultiplosTresCincoAbaixoMil
{
    class Program
    {
        static void Main(string[] args)
        {
            // Números multiplos de 3 ou 5 abaixo de 1000
            DateTime timeIni = DateTime.Now;

            List<int> multiplosTresCinco = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiplosTresCinco.Add(i);
                    sb.AppendFormat("{0}, ", i);
                }
            }

            Console.WriteLine(string.Format("Números multiplos de 3 ou 5 abaixo de 1000: {0}", sb.ToString().Substring(0, sb.ToString().Length - 2)));
            Console.WriteLine();
            Console.WriteLine(string.Format("Soma destes números: {0}", multiplosTresCinco.Sum()));
            Console.WriteLine();
            TimeSpan ts = DateTime.Now - timeIni;
            Console.WriteLine(string.Format("Tempo: {0} s", ts.Seconds));
            // Resultado: 233.168
            Console.ReadKey();
        }
    }
}
