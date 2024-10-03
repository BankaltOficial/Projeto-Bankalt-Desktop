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
    public partial class FormCadastro3 : Form
    {
        Funcionario frt1 = new Funcionario();
        public FormCadastro3(Funcionario fr1)
        {
            InitializeComponent();
            frt1.Nome = fr1.Nome;
            frt1.Cpf = fr1.Cpf;
            frt1.Username = fr1.Username;
            frt1.Senha = fr1.Senha;
            frt1.Rg = fr1.Rg;
            frt1.Datanascimento = fr1.Datanascimento;
            frt1.Cargo = fr1.Cargo;
            frt1.Estadocivil = fr1.Estadocivil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            this.Close();
            login1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 entrada = new Form1();
            this.Close();
            entrada.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frt1.Pais = textBox1.Text;
            frt1.Estado = textBox4.Text;
            frt1.Cidade = textBox3.Text;
            frt1.Bairro = textBox2.Text;
            frt1.Rua = textBox5.Text;
            frt1.Cep = maskedTextBox1.Text;
            frt1.Numero = textBox8.Text;
            frt1.Complemento = textBox7.Text;

            string nomePattern = @"^[A-Za-zÀ-ú\s]+$";  // Permite letras, acentos e espaços
            if (!Regex.IsMatch(frt1.Pais, nomePattern))
            {
                MessageBox.Show("O país deve conter apenas letras e espaços.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomePattern1 = @"^[A-Za-zÀ-ú\s]+$";  // Permite letras, acentos e espaços
            if (!Regex.IsMatch(frt1.Estado, nomePattern))
            {
                MessageBox.Show("O estado deve conter apenas letras e espaços.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomePattern2 = @"^[A-Za-zÀ-ú\s]+$";  // Permite letras, acentos e espaços
            if (!Regex.IsMatch(frt1.Cidade, nomePattern))
            {
                MessageBox.Show("A cidade deve conter apenas letras e espaços.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomePattern3 = @"^\d+$";  // Permite letras, acentos e espaços
            if (!Regex.IsMatch(frt1.Numero, nomePattern3))
            {
                MessageBox.Show("O numero deve conter apenas valores numericos.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (frt1 != null)
            {
                FuncionarioValidation3 validator = new FuncionarioValidation3();
                ValidationResult results = validator.Validate(frt1);
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

            FormCadastro4 cadstro4 = new FormCadastro4(frt1);
            this.Close();
            cadstro4.Show();
        }
    }
}
