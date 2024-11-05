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
    public partial class FormSistemaDesenvolvedor : Form
    {
        public FormSistemaDesenvolvedor()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void btninformacoes_Click(object sender, EventArgs e)
        {
            FormSelecao formSelecao = new FormSelecao();
            formSelecao.Show();
            this.Close();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            string text1, text2;
            text1 = textBox1.Text;
            text2 = textBox2.Text;

            ClienteMFRepository clienteMFRepository = new ClienteMFRepository();
            var (nome, cpf) =  clienteMFRepository.SelectClientesistemadesenvolvedor(text1, text2);
            if(nome == text1 && cpf == text2)
            {
                label8.Text = "Cliente encontrado";
                label8.ForeColor = Color.Green;
            }
            else
            {
                label8.Text = "Cliente não encontrado";
                label8.ForeColor = Color.Red;
            }
        }
    }
}
