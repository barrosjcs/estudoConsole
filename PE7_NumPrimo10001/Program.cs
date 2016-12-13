using System;
using System.Collections.Generic;
using System.Linq;

namespace PE7_NumPrimo10001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Número Primo n° 10001
            DateTime timeIni = DateTime.Now;

            List<long> numeros = new List<long>();
            int contPrimos = 1;
            int i = 3;
            numeros.Add(2);

            while (contPrimos < 10001)
            {                
                bool primo = true;
                for (long j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo && !numeros.Contains(i))
                {
                    numeros.Add(i);
                    contPrimos++;
                }

                i++;
            }

            TimeSpan ts = DateTime.Now - timeIni;

            Console.WriteLine(string.Format("Número Primo n° 10001: {0}", numeros.LastOrDefault()));
            Console.WriteLine(string.Format("Tempo: {0} s", ts.Seconds));
            // Resultado: 104.743
            Console.ReadKey();
        }
    }
}
