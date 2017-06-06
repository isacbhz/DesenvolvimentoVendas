using System;
using DAO;
using DTO;

namespace Model
{
    public class CadastrarProduto
    {
        //CRIAR CONEXAO
        AccessSqlServer accessSqlServer = new AccessSqlServer();

        //CRIAR METODO
        public String ProdutoInserir(Produto Produto)
        {
            try
            {
                //LIMPAR PARAMETROS
                accessSqlServer.LimparParametros();
                //ADICONAR PARAMETROS
                accessSqlServer.AdiconarParamentros("@IDProdutoFamilia", Produto.ProdFamila.IdProdutoFamilia);
                accessSqlServer.AdiconarParamentros("@IDProdutoTipo", Produto.ProdTipo.IDProdutoTipo);
                accessSqlServer.AdiconarParamentros("@IDProdutoGrupo", Produto.ProdGrupo.IdProdutoGrupo);
                accessSqlServer.AdiconarParamentros("@IDProdutoFormato", Produto.ProdFormato.IdProdutoFormato);
                accessSqlServer.AdiconarParamentros("@CodRomanel", Produto.CodRomanel);
                accessSqlServer.AdiconarParamentros("@DescricaoDetalhada", Produto.DescricaoDetalhada);
                accessSqlServer.AdiconarParamentros("@DataCadastro", Produto.DataCadastro);
                accessSqlServer.AdiconarParamentros("@PrecoCompra", Produto.PrecocomrpaVenda.PrecoCompra);
                accessSqlServer.AdiconarParamentros("@PercentualLucro", Produto.PrecocomrpaVenda.PercentualLucroCompra);
                accessSqlServer.AdiconarParamentros("@PrecoVenda", Produto.PrecocomrpaVenda.PrecoDeVenda);

                //MANIPULACAO
                String IDProduto = accessSqlServer.Persistencia(System.Data.CommandType.StoredProcedure, "uspProdutoInserir").ToString();
                return IDProduto;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
