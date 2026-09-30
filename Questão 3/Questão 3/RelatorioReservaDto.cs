using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_3
{
    public record RelatorioReservaDto(string NomeHospede, int NumeroQuarto, int QuantidadeDiarias, decimal ValorTotal, string Situacao);
}