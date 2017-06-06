using DAO;
using DTO;
using System;
using System.Data;

namespace Model
{
    public class InserirPedidos
    {
        AccessSqlServer accessSqlServer = new AccessSqlServer();

        //INSERIR PEDIDOS
        public String AddPedidos(Pedido pedido)
        {
            try
            {
                //LIMPAR PARAMETROS
                accessSqlServer.LimparParametros();
                //ADICIONAR PARAMETROS
                accessSqlServer.AdiconarParamentros("@IDOperacao", pedido.Operacao.IDOperacao);
                accessSqlServer.AdiconarParamentros("@IDSituacao", pedido.SituacaoPedido.IDSituacao);
                accessSqlServer.AdiconarParamentros("@IDPessoaEmitente", pedido.Emitente.IDPessoa);
                accessSqlServer.AdiconarParamentros("@IDPessoaDestinatario", pedido.Destinatario.IDPessoa);

                //EXECUTAR MANIPULACAO
                String idPedido = accessSqlServer.Persistencia(CommandType.StoredProcedure, "uspPedidoInserir").ToString();

                return idPedido;
            }

            catch (Exception exception)
            {
                return exception.Message;
            }
        }

       }

}

