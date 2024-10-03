using dados;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCadastro2 : Form
    {
        Funcionario frt = new Funcionario();
        public FormCadastro2(Funcionario fr1)
        {
            InitializeComponent();
            frt.Nome = fr1.Nome;
            frt.Senha = fr1.Senha;
            frt.Cpf = fr1.Cpf;
            frt.Username = fr1.Username;
        }

        private void FormCadastro2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            this.Close();
            login1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string format = "dd/MM/yyyy";
            try
            {
                frt.Rg = maskedTextBox1.Text;
                frt.Datanascimento = DateTime.ParseExact(maskedTextBox2.Text,format,null);
                frt.Cargo = textBox1.Text;
                frt.Estadocivil = textBox2.Text;

                if (frt != null)
                {
                    FuncionarioValidation2 validator = new FuncionarioValidation2();
                    ValidationResult results = validator.Validate(frt);
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
                FormCadastro3 cadastro3 = new FormCadastro3(frt);
                cadastro3.Show();
                this.Close();
                throw new Exception();
            }
            catch 
            { 
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 entrada = new Form1();
            this.Close();
            entrada.Show();
        }
    }
}
