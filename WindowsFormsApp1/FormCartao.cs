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
    public partial class FormCartao : Form
    {
        public FormCartao()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormSistemaDesenvolvedor formSistemaDesenvolvedor = new FormSistemaDesenvolvedor();
            formSistemaDesenvolvedor.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteMFRepository clienteMFRepository = new ClienteMFRepository();
            ClienteMF cliente = new ClienteMF();
            try
            {
                cliente = clienteMFRepository.VoltaDadosPessoaisCartaoMaiorDeIdade(textBox1.Text);
                textBox6.Text = cliente.Nome;
                textBox7.Text = cliente.Tipocartao;
                textBox2.Text = cliente.Tipoplano;
                textBox3.Text = cliente.Numerocartao;
                textBox4.Text = cliente.Validade;
                textBox5.Text = cliente.Cvv;
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formextratato formextratato = new formextratato();
            formextratato.Show();
            this.Close();
        }
    }
}
