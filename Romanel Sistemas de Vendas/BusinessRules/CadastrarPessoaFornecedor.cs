using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace Model
{
    public class CadastrarPessoaFornecedor
    {
        AccessSqlServer accessSqlServer = new AccessSqlServer();

        public String InserirFornecedor(PessoaFornecedor fornecedor)
        {
            try
            {
                //LIMPAR OS PARAMETROS
                accessSqlServer.LimparParametros();
                //ADCIONAR PARAMETROS
                accessSqlServer.AdiconarParamentros("@IDPessoaTipo", fornecedor.IDPessoaTipo);
                accessSqlServer.AdiconarParamentros("@NomeFantasia", fornecedor.NomeFantasia);
                accessSqlServer.AdiconarParamentros("@RazaoSocial", fornecedor.RazaoSocial);
                accessSqlServer.AdiconarParamentros("@CNPJ", fornecedor.Cnpj);
                accessSqlServer.AdiconarParamentros("@Nome", fornecedor.Nome);
                accessSqlServer.AdiconarParamentros("@CPF", fornecedor.Cpf);
                accessSqlServer.AdiconarParamentros("@Endereco", fornecedor.Endereco);
                accessSqlServer.AdiconarParamentros("@NumEndereco", fornecedor.NumEndereco);
                accessSqlServer.AdiconarParamentros("@Complemento", fornecedor.Complemento);
                accessSqlServer.AdiconarParamentros("@Bairro", fornecedor.Bairro);
                accessSqlServer.AdiconarParamentros("@Cidade", fornecedor.Cidade);
                accessSqlServer.AdiconarParamentros("@Estado", fornecedor.Estado);
                accessSqlServer.AdiconarParamentros("@InscricaoEstadual", fornecedor.InscricaoEstadual);
                accessSqlServer.AdiconarParamentros("@DataFundacao", fornecedor.DataFundacao);

                String IdPessoaFornecedor = accessSqlServer.Persistencia(System.Data.CommandType.StoredProcedure, "uspPessoaFornecedorInserir").ToString();
                return IdPessoaFornecedor;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
