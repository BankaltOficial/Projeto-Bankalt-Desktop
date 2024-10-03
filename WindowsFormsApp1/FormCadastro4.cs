using dados;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class FormCadastro4 : Form
    {
        Funcionario frt2 = new Funcionario();
        public FormCadastro4(Funcionario f1)
        {
            InitializeComponent();
            frt2.Rg = f1.Rg;
            frt2.Datanascimento = f1.Datanascimento;
            frt2.Cargo = f1.Cargo;
            frt2.Estado = f1.Estado;
            frt2.Cidade = f1.Cidade;
            frt2.Bairro = f1.Bairro;
            frt2.Rua = f1.Rua;
            frt2.Cep = f1.Cep;
            frt2.Complemento = f1.Complemento;
            frt2.Estadocivil = f1.Estadocivil;
            frt2.Nome = f1.Nome;
            frt2.Cpf = f1.Cpf;
            frt2.Username = f1.Username;
            frt2.Senha = f1.Senha;
            frt2.Numero = f1.Numero;
            frt2.Pais = f1.Pais;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frt2.Celular = maskedTextBox1.Text;
            frt2.Telefone = maskedTextBox2.Text;
            frt2.Contatoemergencia = maskedTextBox3.Text;
            frt2.Email = textBox5.Text;
            float salario = 0;
            if(float.TryParse(textBox1.Text, out salario))
            {
                frt2.Salario = salario;
            }

            string nomePattern = @"^\d+$";  // Permite letras, acentos e espaços
            if (!Regex.IsMatch(frt2.Salario.ToString(), nomePattern)) 
            {
                MessageBox.Show("O Salario deve conter apenas letras e espaços.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (frt2 != null)
            {
                FuncionarioValidation4 validator = new FuncionarioValidation4();
                ValidationResult results = validator.Validate(frt2);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Aviso do sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            try
            {
                FuncionarioRepository fr = new FuncionarioRepository();
                fr.InsertFuncionario(frt2);
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.ToString());
             } 
        }
    }   
}

