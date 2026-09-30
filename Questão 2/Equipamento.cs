using System;
using System.Collections.Generic;
using System.Text;

namespace Questão2
{
    internal class Equipamento
    {
        public int Id { get; set; }
        
        [Exibir]
        public string Nome { get; set; }
        [Exibir]
        public string Fabricante { get; set; }
        
        public string NumeroSerie { get; set; }
        [Exibir]
        public decimal Valor { get; set; }
        [Exibir]
        public string Localizacao { get; set; }
    }
}
