using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntradayAPI
{
    public class Operacao
    {
        public int Id { get; set; }

        public DateTime DataDeRegistro { get; set; }

        [Column(TypeName = "decimal(32,2)")]
        public decimal Preco { get; set; }
    }
}