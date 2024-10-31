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
    }
}
