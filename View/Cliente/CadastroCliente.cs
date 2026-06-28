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
            if (ttbNome.Text == " ")
                MessageBox.Show("Por favor, preencha o campo Nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (ttbCpf.Text == " ")
                MessageBox.Show("Por favor, preencha o campo CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (ttbSenha.Text == " ")
                MessageBox.Show("Por favor, preencha o campo Senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (ttbData.Text == " ")
                MessageBox.Show("Por favor, preencha o campo Data de Nascimento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                DialogResult result = MessageBox.Show("Deseja realmente cadastrar o cliente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes) // Se o usuário clicar em "Sim"
                {
                    MessageBox.Show($"Cliente {ttbNome.Text} cadastrado com sucesso!", // Corrigido para interpolação de string
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    new LoginForm().Show(); // Retorna a tela de login
                    this.Hide(); // Oculta a tela de cadastro cliente
                }
            }

            string senha = ttbSenha.Text.Trim();
            string nome = ttbNome.Text.Trim().ToUpper();
            string cpf = ttbCpf.Text.Trim().Replace(".", "").Replace("-", "");
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

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }



    }
}
