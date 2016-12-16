using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiandoListaEmOutraLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroA = new Carro
            {
                Codigo = 1,
                Marca = "Ferrari",
                Preco = 300000,
                AirBag = false
            };

            Carro carroB = new Carro
            {
                Codigo = 2,
                Marca = "Porche",
                Preco = 450000,
                AirBag = true
            };

            List<Carro> listaCarros = new List<Carro>();
            List<Carro> listaCarrosCopia = new List<Carro>();

            listaCarros.Add(carroA);
            listaCarros.Add(carroB);

            
            foreach (Carro item in listaCarros)
                listaCarrosCopia.Add((Carro)ClonarObjeto(item));

            //listaCarrosCopia = listaCarros;

            listaCarrosCopia[0].Codigo = 3;

            Console.WriteLine("listaCarrosCopia");
            foreach (var item in listaCarrosCopia)
            {
                Console.WriteLine(string.Format("Código: {0}", item.Codigo));
            }

            Console.WriteLine();
            Console.WriteLine("listaCarros");
            foreach (var item in listaCarros)
            {
                Console.WriteLine(string.Format("Código: {0}", item.Codigo));
            }

            Console.ReadKey();
        }
        public static object ClonarObjeto(object objRecebido)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                var bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bf.Serialize(ms, objRecebido);
                ms.Position = 0;

                object obj = bf.Deserialize(ms);
                ms.Close();

                return obj;
            }
        }

        [Serializable]
        public class Carro
        {
            public int Codigo { get; set; }
            public string Marca { get; set; }
            public decimal Preco { get; set; }
            public bool AirBag { get; set; }
        }
    }
}
