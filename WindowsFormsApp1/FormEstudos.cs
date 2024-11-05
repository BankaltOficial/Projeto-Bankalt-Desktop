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
    public partial class FormEstudos : Form
    {
        public FormEstudos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormSistemaDesenvolvedor form = new FormSistemaDesenvolvedor();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCartao form = new FormCartao();
            form.Show();
            this.Close();
        }
    }
}
