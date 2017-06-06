using System;
using DAO;
using DTO;

namespace Model
{
    public class CadastrarProdutoTipo
    {
        //CRIAR CONEXAO COM BANCO DE DADOS
        AccessSqlServer accessSqlServer = new AccessSqlServer();

        //CRIAR O METODO
        public String ProdutoTipoInserir(ProdutoTipo produtoTipo)
        {
            try
            {
                //LIMPAR PARAMETROS
                accessSqlServer.LimparParametros();

                //ADICIONAR PARAMETROS
                accessSqlServer.AdiconarParamentros("@Descricao", produtoTipo.DescricaoProdutoTipo);
                //EXECUTAR A MANIPULACAO
                String IDCadastroProdTipo = accessSqlServer.Persistencia(System.Data.CommandType.StoredProcedure, "uspProdutoTipoInserir").ToString();

                return IDCadastroProdTipo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
    }
}
