using System;
using DAO;
using DTO;
using System.Data;

namespace Model
{
    public class CadastrarPessoaFisica
    {
        AccessSqlServer accessSqlServer = new AccessSqlServer();

        public String InserirPessoaFisica(PessoaFisica pessoaFisica)
        {
            try
            {
                //LIMPAR PARAMETROS
                accessSqlServer.LimparParametros();
                //ADCIONAR PARAMETROS
                accessSqlServer.AdiconarParamentros("@Nome", pessoaFisica.Nome);
                accessSqlServer.AdiconarParamentros("@CPF", pessoaFisica.CPF);
                accessSqlServer.AdiconarParamentros("@Telefone", pessoaFisica.Telefone);
                accessSqlServer.AdiconarParamentros("@Endereco", pessoaFisica.Endereco);
                accessSqlServer.AdiconarParamentros("@NumEndereco", pessoaFisica.NumEndereco);
                accessSqlServer.AdiconarParamentros("@Complemento", pessoaFisica.Complemento);
                accessSqlServer.AdiconarParamentros("@Bairro", pessoaFisica.Bairro);
                accessSqlServer.AdiconarParamentros("@Cidade", pessoaFisica.Cidade);
                accessSqlServer.AdiconarParamentros("@Estado", pessoaFisica.Estado);
                
                String idPessoaFisica = accessSqlServer.Persistencia(CommandType.StoredProcedure, "uspPessoaFisicaInserir").ToString();
                return idPessoaFisica;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
             
    }
}
