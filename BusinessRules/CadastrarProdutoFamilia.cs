using System;
using DAO;
using DTO;

namespace Model
{
    public class CadastrarProdutoFamilia
    {
        //CRIAR CONEXAO COM BANCO DE DADOS
        AccessSqlServer accessSqlServer = new AccessSqlServer();

        //CRIAR METODO
        public String ProdutoGrupoInserir(ProdutoFamilia produtoFamilia)
        {
            try
            {
                //LIMPAR PARAMENTROS
                accessSqlServer.LimparParametros();
                //ADICIONAR PARAMENTROS
                accessSqlServer.AdiconarParamentros("@Descricao", produtoFamilia.Descricao);
                //MANIPULACAO
                String IDProdFamilia = accessSqlServer.Persistencia(System.Data.CommandType.StoredProcedure, "uspProdutoFamiliaInserir").ToString();
                return IDProdFamilia;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
