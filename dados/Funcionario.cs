using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados
{
    public class Funcionario
    {
        private String nome;
        private String senha;
        private String username;
        private String salario;
        private string cpf;
        private String rg;
        private DateTime datanascimento;
        private String cargo;
        private String pais;
        private String estado;
        private String cidade;
        private String bairro;
        private String rua;
        private String cep;
        private String complemento;
        private String estadocivil;
        private String email;
        private String celular;
        private String telefone;
        private String contatoemergencia;
        private String numero;
        private String contatoemergencianome;

        public Funcionario()
        {
        }

        public Funcionario(string nome, string senha, string username, string salario, string rg, DateTime datanascimento, string cargo, string pais, string estado, string cidade, string bairro, string rua, string cep, string complemento, string estadocivil, string email, string celular, string telefone, string contatoemergencia, string cpf, string numero, string contatonome)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Username = username;
            this.Salario = salario;
            this.Rg = rg;
            this.Datanascimento = datanascimento;
            this.Cargo = cargo;
            this.Pais = pais;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Rua = rua;
            this.Cep = cep;
            this.Complemento = complemento;
            this.Estadocivil = estadocivil;
            this.Email = email;
            this.Celular = celular;
            this.Telefone = telefone;
            this.Contatoemergencia = contatoemergencia;
            this.Cpf = cpf;
            this.Numero = numero;
            this.contatoemergencianome = contatonome;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Username { get => username; set => username = value; }
        public string Salario { get => salario; set => salario = value; }
        public string Rg { get => rg; set => rg = value; }
        public DateTime Datanascimento { get => datanascimento; set => datanascimento = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Email { get => email; set => email = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Contatoemergencia { get => contatoemergencia; set => contatoemergencia = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Contatoemergencianome { get => contatoemergencianome; set => contatoemergencianome = value; }
    }
}
