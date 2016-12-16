using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EnumDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros = new[] { Carro.Ferrari, Carro.Jaguar };
            string texto = Carro.Ferrari.Descricao();
            // texto = "Carro Ferrari"
            if (carros.Any(c => c.Descricao() == texto))
                Console.WriteLine("Correto");
            else
                Console.WriteLine("Incorreto");

            // Resultado: Correto

            string valorPadrao = Carro.Ferrari.ValorPadrao();

            Carro generico = texto.ReceberEnumDeDescricao<Carro>();
            Carro generico2 = valorPadrao.ReceberEnumDeValorPadrao<Carro>();
            

            Console.WriteLine();
            Console.WriteLine(string.Format("Descricao: {0}, Valor Padrao: {1}", texto, valorPadrao));

            Console.ReadKey();
        }

        public enum Carro
        {
            [Description("Carro Mercedes"), DefaultValue("M")]
            Mercedes,
            [Description("Carro Ferrari"), DefaultValue("F")]
            Ferrari,
            [Description("Carro Jaguar"), DefaultValue("J")]
            Jaguar,
            Porche
        }        
    }

    public static class Util
    {
        public static string Descricao(this Enum itemEnum)
        {
            DescriptionAttribute descricao = (DescriptionAttribute)itemEnum.GetType().GetField(itemEnum.ToString()).
                GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

            string retorno = itemEnum.ToString();
            if (descricao != null)
                retorno = descricao.Description;
            return retorno;
        }

        public static string ValorPadrao(this Enum itemEnum)
        {
            DefaultValueAttribute valorPadrao = (DefaultValueAttribute)itemEnum.GetType().GetField(itemEnum.ToString()).
                GetCustomAttributes(typeof(DefaultValueAttribute), false).FirstOrDefault();
            string retorno = itemEnum.ToString();
            if (valorPadrao != null)
                retorno = valorPadrao.Value.ToString();
            return retorno;
        }

        public static T ReceberEnumDeDescricao<T>(this string descricao)
        {
            foreach (MemberInfo campo in (MemberInfo[])typeof(T).GetFields())
            {
                DescriptionAttribute[] atributoDescricao = (DescriptionAttribute[])campo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (atributoDescricao != null && atributoDescricao.Length > 0 && atributoDescricao[0].Description == descricao)
                    return (T)Enum.Parse(typeof(T), campo.Name);
            }

            throw new Exception("Não há Enum com esta descrição");
        }

        public static T ReceberEnumDeValorPadrao<T>(this string valorPadrao)
        {
            foreach (MemberInfo field in (MemberInfo[])typeof(T).GetFields())
            {
                DefaultValueAttribute[] atributoValorPadrao = (DefaultValueAttribute[])field.GetCustomAttributes(typeof(DefaultValueAttribute), false);
                if (atributoValorPadrao != null && atributoValorPadrao.Length > 0 && atributoValorPadrao[0].Value.ToString() == valorPadrao)
                    return (T)Enum.Parse(typeof(T), field.Name);
            }

            throw new Exception("Não há Enum com este valor padrão");
        }
    }
}
