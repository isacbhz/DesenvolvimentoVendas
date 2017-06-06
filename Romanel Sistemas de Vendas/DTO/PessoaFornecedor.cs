using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PessoaFornecedor
    {
        public Pessoa Pessoa { get; set; }
        public int IDPessoaTipo { get; set; }
        public String NomeFantasia { get; set; }
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Endereco { get; set; }
        public int? NumEndereco { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String InscricaoEstadual { get; set; }
        public DateTime? DataFundacao { get; set; }
    }
}
