using System;
using DTO;
using DAO;

namespace Model
{
    public class CadastrarProdutoFormato
    {
        //CRIAR CONEXAO BANCO DADOS
        AccessSqlServer accessSqlServer = new AccessSqlServer();

        //CRIAR METODO
        public String ProdutoFormatoInserir(ProdutoFormato produtoFormato)
        {
            try
            {
                //LIMPAR PARAMETROS
                accessSqlServer.LimparParametros();
                //ADICIONAR PARAMETROS
                accessSqlServer.AdiconarParamentros("@Descricao", produtoFormato.Descricao);
                //MANIPULACAO
                String IDProdFormato =  accessSqlServer.Persistencia(System.Data.CommandType.StoredProcedure, "uspProdutoFormatoInserir").ToString();
                return IDProdFormato;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
