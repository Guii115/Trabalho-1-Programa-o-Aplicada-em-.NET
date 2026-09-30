using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_3
{
    internal class Reserva
    {
        public int Id { get; set; }

        public string NomeHospede { get; set; }

        public int NumeroQuarto { get; set; }

        public int QuantidadeDiarias { get; set; }

        public decimal ValorDiaria { get; set; }

        public string StatusInterno { get; set; }

        public string ObservacaoInterna { get; set; }

        public string Situacao { get; set; }
    }
}
