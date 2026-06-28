using Sistema_Caixa_Eletronico.View.Cadastro;
using System.Security.Cryptography.X509Certificates;

namespace Sistema_Caixa_Eletronico
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abrir uma tela de cadastro cliente
            new CadastroCliente().ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
