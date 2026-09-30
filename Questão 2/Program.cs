using System.Reflection;

namespace Questão2
{
    internal class Program
    {

        public static void ExibirDadosAberto(object objeto)
        {
            Type tipo = objeto.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                object valor = propriedade.GetValue(objeto);
                Console.WriteLine($"{propriedade.Name}: {valor}");
            }
        }
        public static void ExibirDadosControlado(object objeto)
        {
            Type tipo = objeto.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                ExibirAttribute etiqueta = propriedade.GetCustomAttribute<ExibirAttribute>();

                if (etiqueta != null)
                {
                    object valor = propriedade.GetValue(objeto);
                    Console.WriteLine($"{propriedade.Name}: {valor}");
                }
            }
        }

        static void Main(string[] args)
        {
            Equipamento equipamento = new Equipamento
            {
                Id = 1,
                Nome = "Computador",
                Fabricante = "Dell",
                NumeroSerie = "EX123Z456",
                Valor = 2500.00m,
                Localizacao = "Sala 101"
            };

            ExibirDadosAberto(equipamento);
            Console.WriteLine();
            ExibirDadosControlado(equipamento);
        }
    }
}
