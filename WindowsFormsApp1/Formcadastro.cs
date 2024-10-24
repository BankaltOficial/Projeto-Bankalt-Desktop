using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dados;
using FluentValidation.Results;
using Org.BouncyCastle.Bcpg.Sig;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Formcadastro : Form
    {
        public Formcadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 entrada = new Form1();
            this.Close();
            entrada.Show();
        }

        private void Formcadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnsalvarcadastro1click(object sender, EventArgs e)
        { 
            try
            {
                FuncionarioRepository fr = new FuncionarioRepository();
                Funcionario fr1 = new Funcionario();
                fr1.Username= textBox3.Text;
                fr1.Senha = textBox4.Text;
                fr1.Nome = textBox1.Text;
                fr1.Cpf = maskedTextBox1.Text;

                string nomePattern = @"^[A-Za-zÀ-ú\s]+$";  // Permite letras, acentos e espaços
                if (!Regex.IsMatch(fr1.Nome, nomePattern))
                {
                    MessageBox.Show("O nome deve conter apenas letras e espaços.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (fr1 != null)
                {
                    FuncionarioValidation validator = new FuncionarioValidation();
                    ValidationResult results = validator.Validate(fr1);
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


                bool c = CpfCnpjUtils.IsCpf(maskedTextBox1.Text);
                if (c == false)
                {
                    MessageBox.Show("Informe um cpf valido");
                    maskedTextBox1.Focus();
                }
                if (c == true)
                {
                    FormCadastro2 cadastro2 = new FormCadastro2(fr1);
                    cadastro2.Show();
                    this.Hide();
                }
                throw new Exception();
            }
            catch(Exception ex)
            { 
            }
        }

        private void btnclickcancelarclick(object sender, EventArgs e)
        {
            Login login1 = new Login();
            this.Close();
            login1.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
