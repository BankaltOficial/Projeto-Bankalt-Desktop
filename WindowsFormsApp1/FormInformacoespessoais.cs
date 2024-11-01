using dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInformacoespessoais : Form
    {
        public FormInformacoespessoais()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSelecao formselecao = new FormSelecao();
            formselecao.Show();
            this.Close();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClienteMFRepository clienteMFRepository = new ClienteMFRepository();
            ClienteMF cliente = new ClienteMF();
            try
            {
                cliente = clienteMFRepository.VoltaDadosPessoaisClienteMaiorDeIdade(textBox19.Text);
                textBox1.Text = cliente.Nome ?? string.Empty;
                textBox2.Text = cliente.Sexo1 ?? string.Empty;
                maskedTextBox1.Text = cliente.Datanascimento.ToString("dd/MM/yyyy") ?? "00000000";
                textBox3.Text = cliente.Cidade ?? string.Empty;
                textBox7.Text = cliente.Estado ?? string.Empty;
                textBox4.Text = cliente.Rg ?? string.Empty;
                textBox5.Text = cliente.Cpf ?? string.Empty;
                textBox6.Text = cliente.Estadocivil ?? string.Empty;
                textBox8.Text = cliente.Cep ?? string.Empty;
                textBox9.Text = cliente.Rua ?? string.Empty;
                textBox10.Text = cliente.Bairro ?? string.Empty;
                textBox11.Text = cliente.Numero ?? string.Empty;
                textBox12.Text = cliente.Complemento ?? string.Empty;
                textBox13.Text = cliente.Telefone ?? string.Empty;
                textBox14.Text = cliente.Celular ?? string.Empty;
                textBox15.Text = cliente.Email ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum cliente encontrado!");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string format = "dd/MM/yyyy";
            ClienteMF cliente = new ClienteMF();
            cliente.Nome = textBox1.Text;
            cliente.Sexo1 = textBox2.Text;
            cliente.Datanascimento = DateTime.ParseExact(maskedTextBox1.Text, format, null);
            cliente.Rg = textBox4.Text;
            cliente.Cpf = textBox5.Text;
            cliente.Estadocivil = textBox6.Text;
            cliente.Estado = textBox7.Text;
            cliente.Cidade = textBox3.Text;
            cliente.Cep = textBox8.Text;
            cliente.Rua = textBox9.Text;
            cliente.Bairro = textBox10.Text;
            cliente.Numero = textBox11.Text;
            cliente.Complemento = textBox12.Text;
            cliente.Telefone = textBox13.Text;
            cliente.Celular = textBox14.Text;
            cliente.Email = textBox15.Text;

            ClienteMFRepository clienteMFRepository = new ClienteMFRepository();
            clienteMFRepository.AtualizarCliente(cliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formextratato formextratato = new formextratato();
            formextratato.Show();
            this.Close();
        }
    }
}
