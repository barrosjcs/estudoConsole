using System;
using System.Text;

namespace PE3_MaiorFatorPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maior Fator primo de 600851475143
            DateTime timeIni = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            long num = 600851475143;
            long original = num;
            int maiorFator, aux;
            bool primo;
            maiorFator = 1;

            while (num > 1)
            {
                aux = maiorFator * 5;
                for (int i = maiorFator + 1; i < aux; i++)
                {
                    primo = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            primo = false;
                    }

                    if (primo)
                    {
                        maiorFator = i;
                        break;
                    }
                }

                while (num % maiorFator == 0)
                {
                    sb.AppendFormat("{0}, ", maiorFator);
                    num = num / maiorFator;
                }
            }

            Console.WriteLine(string.Format("Fatores primos de {0}: {1}", original, sb.ToString().Substring(0, sb.ToString().Length - 2)));
            Console.WriteLine();
            Console.WriteLine(string.Format("Maior fator primo de {0}: {1}", original, maiorFator));
            Console.WriteLine();
            TimeSpan ts = DateTime.Now - timeIni;
            Console.WriteLine(string.Format("Tempo: {0} s", ts.Seconds));
            // Resultado: 6857
            Console.ReadKey();
        }
    }
}
