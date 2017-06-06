using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ComprasParcelas
    {
        public Compras Compras { get; set; }
        public SituacaoCompra SituacaoCompra { get; set; }
        public DateTime DataVencimento { get; set; }
        public Decimal Valor { get; set; }
    }
}
