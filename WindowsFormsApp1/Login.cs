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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://web-bankalt.vercel.app/assets/docs/Termo%20de%20Seguran%C3%A7a.pdf");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://web-bankalt.vercel.app/assets/docs/Termo%20de%20Privacidade.pdf");
        }

        private void frmloginvoltaentrada(object sender, EventArgs e)
        {
            Form1 formentrada = new Form1();
            this.Close();
            formentrada.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void btnentrarloginclick(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Username = textBox1.Text.ToString();
            funcionario.Senha = textBox2.Text.ToString();
            FuncionarioRepository fr = new FuncionarioRepository();
            try
            {
                var (username, senha) = fr.Selectfuncionariologin(funcionario);
                if(username == textBox1.Text.ToString() && senha == textBox2.Text.ToString())
                {
                    MessageBox.Show(username, senha);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nenhum Funcionário com esses dados encontrado tente novamente ou cadastre-se", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlogincadastrarclick(object sender, EventArgs e)
        {
            Formcadastro cadastro = new Formcadastro();
            this.Close();
            cadastro.Show(); 
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}