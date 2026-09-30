namespace Questão_3
{
    internal class Program
    {

        public static RelatorioReservaDto Mapear(Reserva reserva)
        {
            decimal valorTotal = reserva.QuantidadeDiarias * reserva.ValorDiaria;
            return new RelatorioReservaDto(reserva.NomeHospede, reserva.NumeroQuarto, reserva.QuantidadeDiarias, valorTotal, "Reserva Confirmada");
        }
        
        public static void ExibirRelatorio(RelatorioReservaDto dto)
        {
            Console.WriteLine($"Hospede: {dto.NomeHospede}");
            Console.WriteLine($"Numero do Quarto: {dto.NumeroQuarto}");
            Console.WriteLine($"Quantidade de Diarias: {dto.QuantidadeDiarias}");
            Console.WriteLine($"Valor Total: {dto.ValorTotal}");
            Console.WriteLine($"Situacao: {dto.Situacao}");
        }
        static void Main(string[] args)
        {
            Reserva reserva = new Reserva
            {
                Id = 1,
                NomeHospede = "Carlos",
                NumeroQuarto = 101,
                QuantidadeDiarias = 3,
                ValorDiaria = 150.00m,
            };

            RelatorioReservaDto dto = Mapear(reserva);
            ExibirRelatorio(dto);
        }
    }
}
