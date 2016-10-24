using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Preencha um número maior do que 0:");
                int num = Convert.ToInt32(Console.ReadLine());
                bool primo;
                if (num < 1)
                    throw new Exception();

                List<int> numeros = new List<int>();

                for (int i = 2; i <= num; i++)
                {
                    primo = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            primo = false;
                    }
                    if (primo)
                        numeros.Add(i);                    
                }

                Console.WriteLine(" ");
                Console.WriteLine("Números primos obtidos:");

                for (int i = 0; i < numeros.Count; i++)
                {
                    Console.WriteLine(numeros[i]);
                }

                int soma = numeros.Sum();

                Console.WriteLine(" ");
                Console.WriteLine("Soma dos números primos: " + soma);

                Console.WriteLine(" ");
                foreach (int item in numeros)
                {
                    Console.WriteLine("Potência do número " + item + " por " + item + ": " + Math.Pow(item,item));
                }

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Caracter inválido." + (string.IsNullOrWhiteSpace(ex.Message) ? "" : "Mensagem: " + ex.Message));
            }
        }
    }
}