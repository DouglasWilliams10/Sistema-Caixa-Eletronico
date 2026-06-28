namespace Sistema_Caixa_Eletronico.View.Cadastro
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ttbCpf = new MaskedTextBox();
            ttbNome = new TextBox();
            ttbSenha = new TextBox();
            ttbConfirmarSenha = new TextBox();
            ttbData = new MaskedTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(86, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 268);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 2;
            label1.Text = "Preencha todos os campos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 28);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 72);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 117);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 164);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 6;
            label5.Text = "Confirmar Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 209);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 7;
            label6.Text = "Data de Nascimento";
            // 
            // ttbCpf
            // 
            ttbCpf.Location = new Point(67, 87);
            ttbCpf.Mask = "   ,   ,   -";
            ttbCpf.Name = "ttbCpf";
            ttbCpf.Size = new Size(329, 23);
            ttbCpf.TabIndex = 8;
            // 
            // ttbNome
            // 
            ttbNome.Location = new Point(67, 43);
            ttbNome.Name = "ttbNome";
            ttbNome.Size = new Size(329, 23);
            ttbNome.TabIndex = 9;
            // 
            // ttbSenha
            // 
            ttbSenha.Location = new Point(67, 131);
            ttbSenha.Name = "ttbSenha";
            ttbSenha.Size = new Size(329, 23);
            ttbSenha.TabIndex = 10;
            // 
            // ttbConfirmarSenha
            // 
            ttbConfirmarSenha.Location = new Point(67, 179);
            ttbConfirmarSenha.Name = "ttbConfirmarSenha";
            ttbConfirmarSenha.Size = new Size(329, 23);
            ttbConfirmarSenha.TabIndex = 11;
            // 
            // ttbData
            // 
            ttbData.Location = new Point(67, 223);
            ttbData.Mask = "  /  /  ";
            ttbData.Name = "ttbData";
            ttbData.Size = new Size(329, 23);
            ttbData.TabIndex = 13;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 303);
            Controls.Add(ttbData);
            Controls.Add(ttbConfirmarSenha);
            Controls.Add(ttbSenha);
            Controls.Add(ttbNome);
            Controls.Add(ttbCpf);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CadastroCliente";
            Text = "Cadastro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox ttbCpf;
        private TextBox ttbNome;
        private TextBox ttbSenha;
        private TextBox ttbConfirmarSenha;
        private MaskedTextBox ttbData;
    }
}