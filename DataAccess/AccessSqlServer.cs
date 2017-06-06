using System;
using System.Data;
using System.Data.SqlClient;
using DAO.Properties;

namespace DAO
{
    public class AccessSqlServer
    {
        //METODO CRIAR A CONEXAO
        private SqlConnection ConexaoSql()
        {
            return new SqlConnection(Settings.Default.ConnString);
        }

        //PARAMETROS QUE VÃO PARA O BANCO
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        //METODO PARA LIMPAR A COLECAO DE PARAMETROS
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        //METODO ADICIONAR PARAMETROS
        public void AdiconarParamentros(string nomeParametro, object valorParametros)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametros));
        }

        //METODO PERSISTENCIA INSERIR,ALTERAR, EXCLUIR
        public object Persistencia(CommandType commandType, string procedureOuComando)
        {
            try
            {
                //CRIAR CONEXAO
                SqlConnection sqlConnection = ConexaoSql();

                //ABRIR A CONEXAO
                sqlConnection.Open();

                //CRIAR COMANDO QUE IRA LEVAR INFORMACOES PARA O BANCO
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //COLOCAR CONTEUDO DENTRO DO COMANDO
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = procedureOuComando;

                //TEMPO PARA FECHAR A CONEXÃO
                sqlCommand.CommandTimeout = 3000; //EM SEGUNDOS

                //ADICIONAR OS PARAMETROS DO COMANDO
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //MANDAR O COMANDO ATE O BANCO E RETORNAR UM VALOR
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        //METODO CONSULTAR REGISTROS DO BANCO
        public DataTable dataConsulta(CommandType commandType, string procedureOuComando)
        {
            try
            {
                //CRIAR CONEXAO
                SqlConnection sqlConnection = ConexaoSql();

                //ABRIR A CONEXAO
                sqlConnection.Open();

                //CRIAR COMANDO QUE IRA LEVAR INFORMACOES PARA O BANCO
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //COLOCAR CONTEUDO DENTRO DO COMANDO
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = procedureOuComando;

                //TEMPO PARA FECHAR A CONEXÃO
                sqlCommand.CommandTimeout = 3000; //EM SEGUNDOS

                //ADICIONAR OS PARAMETROS DO COMANDO
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
               
                //CRIAR UM ADAPTADOR(INTERPRETADOR)
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //CRIAR UM DATATABLE VAZIO ONDE VÃO SER COLOCADOS OS DADOS FORNECIDOS PELO BANCO DE DADOS
                DataTable dataTable = new DataTable();

                //POPULAR O DATATABLE COM OS DADOS DO BANCO DE DADOS INTERPRETADOS PELO ADAPTADOR
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
