using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Caixa_Eletronico.View.Cadastro
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Confirmação para cadastrar o cliente
            if(ttbNome.Text == "" || ttbCpf.Text == "" || ttbSenha.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Confirmação para Fechar a tela de cadastro cliente e voltar para a tela de login
               DialogResult result = MessageBox.Show("Gostaria de cancelar seu cadastro?", 
                "Atenção", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes) // Se o usuário clicar em "Sim"
            {
                MessageBox.Show("Cadastro cancelado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new LoginForm().Show(); // Retorna a tela de login
                this.Hide(); // Oculta a tela de cadastro cliente
            }    
                

        }
    }
}
