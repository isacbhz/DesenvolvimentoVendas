using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace Model
{
    public class CadastrarPessoaJuridica
    {
        AccessSqlServer accessSqlServer = new AccessSqlServer();

         public String InserirPessoaJuririca(PessoaJuridica pessoaJuridica)
        {
            try
            {

                //LIMPAR PARAMETROS
                accessSqlServer.LimparParametros();
                //ADICIONAR PARAMETROS
                accessSqlServer.AdiconarParamentros("@NomeFantasia", pessoaJuridica.NomeFantasia);
                accessSqlServer.AdiconarParamentros("@RazaoSocial", pessoaJuridica.RazaoSocial);
                accessSqlServer.AdiconarParamentros("@CNPJ", pessoaJuridica.CNPJ);
                accessSqlServer.AdiconarParamentros("@Endereco", pessoaJuridica.Endereco);
                accessSqlServer.AdiconarParamentros("@NumEndereco", pessoaJuridica.NumEndereco);
                accessSqlServer.AdiconarParamentros("@Bairro", pessoaJuridica.Bairro);
                accessSqlServer.AdiconarParamentros("@Cidade", pessoaJuridica.Cidade);
                accessSqlServer.AdiconarParamentros("@Estado", pessoaJuridica.Estado);
                accessSqlServer.AdiconarParamentros("@InscricaoEstadual", pessoaJuridica.InscricaoEstadual);
                accessSqlServer.AdiconarParamentros("@DataFundacao", pessoaJuridica.DataFundacao);

                String idCadastroPessoaJuridica = accessSqlServer.Persistencia(CommandType.StoredProcedure, "uspPessoaJuridicaInserir").ToString();

                return idCadastroPessoaJuridica;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
             
        }
    }
}
