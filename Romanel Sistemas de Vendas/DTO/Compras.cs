using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Compras
    {
        public Produto Produto { get; set; }
        public PessoaVendedor Comprador { get; set; }
        public PessoaComprador PessoaComprador { get; set; }
        public  CompraTipo CompraTipo { get; set; }
        public SituacaoCompra SituacaoCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public Decimal ValorParcelaCompra { get; set; }
        public Decimal ValorCompraAVista { get; set; }
        public Decimal ValorTotalCompra { get; set; }
        
    }
}
