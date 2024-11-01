using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados
{
    public class ClienteMF
    {
        private string nome;
        private string Sexo;
        private DateTime datanascimento;
        private string rg;
        private string cpf;
        private string estadocivil;
        private string pais;
        private string estado;
        private string cidade;
        private string bairro;
        private string rua;
        private string numero;
        private string cep;
        private string complemento;
        private string telefone;
        private string celular;
        private string email;
        private float rendamensal;
        private float saldodaconta;
        private string tiporendamensal;
        private float valortotalinvestimentos;
        private string tipocartao;
        private string tipoplano;
        private string tipoconta;
        private string numerocartao;
        private string validade;
        private string cvv;

        public ClienteMF(string nome, string sexo, DateTime datanascimento, string rg, string cpf, string estadocivil, string pais, string estado, string cidade, string bairro, string rua, string numero, string cep, string complemento, string telefone, string celular, string email, float rendamensal, float saldodaconta, string tiporendamensal, float valortotalinvestimentos, string tipocartao, string tipoplano, string tipoconta, string numerocartao, string validade, string cvv)
        {
            this.nome = nome;
            Sexo = sexo;
            this.datanascimento = datanascimento;
            this.rg = rg;
            this.cpf = cpf;
            this.estadocivil = estadocivil;
            this.pais = pais;
            this.estado = estado;
            this.cidade = cidade;
            this.bairro = bairro;
            this.rua = rua;
            this.numero = numero;
            this.cep = cep;
            this.complemento = complemento;
            this.telefone = telefone;
            this.celular = celular;
            this.email = email;
            this.rendamensal = rendamensal;
            this.saldodaconta = saldodaconta;
            this.tiporendamensal = tiporendamensal;
            this.valortotalinvestimentos = valortotalinvestimentos;
            this.tipocartao = tipocartao;
            this.tipoplano = tipoplano;
            this.tipoconta = tipoconta;
            this.numerocartao = numerocartao;
            this.validade = validade;
            this.cvv = cvv;
        }

        public ClienteMF()
        {

        }

        public string Nome { get => nome; set => nome = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public DateTime Datanascimento { get => datanascimento; set => datanascimento = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public float Rendamensal { get => rendamensal; set => rendamensal = value; }
        public float Saldodaconta { get => saldodaconta; set => saldodaconta = value; }
        public string Tiporendamensal { get => tiporendamensal; set => tiporendamensal = value; }
        public float Valortotalinvestimentos { get => valortotalinvestimentos; set => valortotalinvestimentos = value; }
        public string Tipocartao { get => tipocartao; set => tipocartao = value; }
        public string Tipoplano { get => tipoplano; set => tipoplano = value; }
        public string Tipoconta { get => tipoconta; set => tipoconta = value; }
        public string Numerocartao { get => numerocartao; set => numerocartao = value; }
        public string Validade { get => validade; set => validade = value; }
        public string Cvv { get => cvv; set => cvv = value; }
    }
}
