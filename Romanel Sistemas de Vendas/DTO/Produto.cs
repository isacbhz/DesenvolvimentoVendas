using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Produto
    {
        public int IDProduto { get; set; }
        public ProdutoFamilia ProdFamila { get; set; }
        public ProdutoTipo ProdTipo { get; set; }
        public ProdutoGrupo ProdGrupo { get; set; }
        public ProdutoFormato ProdFormato { get; set; }
        public int CodRomanel { get; set; }
        public string DescricaoDetalhada { get; set; }
        public DateTime DataCadastro { get; set; }
        public PrecoCompraVenda PrecocomrpaVenda { get; set; }
    }
}
