using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PrecoCompraVenda
    {
        public Produto Produto { get; set; }
        public Decimal PrecoCompra { get; set; }
        public Decimal PercentualLucroCompra { get; set; }
        public Decimal PrecoDeVenda { get; set; }
    }
}
