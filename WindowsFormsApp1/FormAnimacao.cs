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
    public partial class FormAnimacao : Form
    {
        private Timer timer;
        public FormAnimacao()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 2000; // Intervalo em milissegundos (10 segundos)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Para o Timer para evitar que seja executado novamente
            timer.Stop();

            // Fecha o Form1 e abre o Form2
            FormSistemaDesenvolvedor formSistemaDesenvolvedor = new FormSistemaDesenvolvedor();
            formSistemaDesenvolvedor.Show();

            this.Close();
        }
    }
}
