using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace Model
{
    public class CadastrarProdutoGrupo
    {
        //CRIAR CONEXAO
        AccessSqlServer accessSqlServer = new AccessSqlServer();

        //CRIAR METODO
        public String ProdutoGrupoInserir(ProdutoGrupo produtoGrupo)
        {
            try
            {
                //LIMPARA PARAMETROS
                accessSqlServer.LimparParametros();
                //ADICIONAR PARAMETROS
                accessSqlServer.AdiconarParamentros("@Descricao", produtoGrupo.Descricao);
                //MANIPULACAO
                String IDProdGrupo = accessSqlServer.Persistencia(System.Data.CommandType.StoredProcedure, "uspProdutoGrupoInserir").ToString();
                return IDProdGrupo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
