using System;

namespace PE5_MenorNumDivTodosNum1a20SResto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menor numero divisivel igualmente por todos os numeros de 1 a 20 sem resto
            DateTime timeIni = DateTime.Now;
            bool parar = false;
            int num = 1;            

            while (!parar)
            {
                num++;
                int controle = 0;
                for (int i = 1; i < 21; i++)
                {                    
                    if (num % i == 0)
                        controle++;
                    else
                        break;
                                        
                    parar = controle == 20;
                }
            }

            Console.Write(string.Format("Menor número divisível igualmente por todos os números de 1 a 20 sem resto: {0}", num));
            TimeSpan ts = DateTime.Now - timeIni;
            Console.WriteLine(string.Format("Tempo: {0} s", ts.Seconds));
            // Resultado: 232.792.560
            Console.ReadKey();            
        }
    }
}
