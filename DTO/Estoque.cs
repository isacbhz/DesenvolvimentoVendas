using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Estoque
    {
        public PessoaVendedor PessoaVendedor { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
