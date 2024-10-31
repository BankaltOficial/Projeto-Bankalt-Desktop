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
                textBox1.Text = cliente.Nome.ToString();
                textBox2.Text = cliente.Sexo1.ToString();
                maskedTextBox1.Text = cliente.Datanascimento.ToString();
                textBox3.Text = cliente.Cidade.ToString();
                textBox7.Text = cliente.Estado.ToString();
                textBox4.Text = cliente.Rg.ToString();
                textBox5.Text = cliente.Cpf.ToString();
                textBox6.Text = cliente.Estadocivil.ToString();
                textBox8.Text = cliente.Cep.ToString();
                textBox9.Text = cliente.Rua.ToString();
                textBox10.Text = cliente.Bairro.ToString();
                textBox11.Text = cliente.Numero.ToString();
                textBox12.Text = cliente.Complemento.ToString();
                textBox13.Text = cliente.Telefone.ToString();
                textBox14.Text = cliente.Celular.ToString();
                textBox15.Text = cliente.Email.ToString();
            }
            catch (Exception ex)
            {

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
