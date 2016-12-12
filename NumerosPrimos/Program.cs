using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                Console.WriteLine("Preencha um número maior do que 0:");
                long num = Convert.ToInt64(Console.ReadLine());
                bool primo;
                if (num < 1)
                    throw new Exception();

                List<long> numeros = new List<long>();

                for (long i = 2; i <= num; i++)
                {
                    primo = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            primo = false;
                    }
                    if (primo)
                    {
                        sb.AppendFormat("{0}, ", i);
                        numeros.Add(i);
                    }
                }

                Console.WriteLine();
                Console.WriteLine(string.Format("Números primos obtidos: {0}, ", sb.ToString().Substring(0, sb.ToString().Length - 2)));

                long soma = numeros.Sum();

                Console.WriteLine();
                Console.WriteLine("Soma dos números primos: " + soma);

                Console.WriteLine();
                foreach (long item in numeros)
                {
                    Console.WriteLine("Potência do número " + item + " por " + item + ": " + Math.Pow(item,item));
                }

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Caracter inválido." + (string.IsNullOrWhiteSpace(ex.Message) ? "" : "Mensagem: " + ex.Message));
                Console.ReadKey();
            }
        }
    }
}