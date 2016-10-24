using System;

namespace MatrizIdentidade
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva um número maior do que um. Para criar a Matriz Identidade:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 2)
                    throw new Exception();

                int[,] matriz = new int[num, num];

                Console.WriteLine(" ");

                for (int x = 0; x < num; x++)
                {                    
                    for (int y = 0; y < num; y++)
                    {
                        matriz[x, y] = x == y ? 1 : 0;

                        Console.Write(matriz[x, y] + " ");
                    }
                    Console.WriteLine(" ");
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caracter inválido." + (string.IsNullOrWhiteSpace(ex.Message) ? "" : "Mensagem: " + ex.Message));
            }
        }
    }
}
