using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaMultiplosTresCincoAbaixoMil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find sum of all multiples of 3 or 5 below 1000
            List<int> multiplosTresCinco = new List<int>();
            int soma = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    multiplosTresCinco.Add(i);
            }

            for (int i = 0; i < multiplosTresCinco.Count; i++)
            {
                if (i == multiplosTresCinco.Count - 1)
                    sb.AppendFormat("{0}", multiplosTresCinco[i]);
                else
                    sb.AppendFormat("{0}, ", multiplosTresCinco[i]);

                soma += multiplosTresCinco[i];
            }

            Console.WriteLine(string.Format("Números multiplos de 3 ou 5 abaixo de 1000: {0}", sb));
            Console.WriteLine();
            Console.WriteLine(string.Format("Soma destes números: {0}", soma));

            Console.ReadKey();
        }
    }
}
