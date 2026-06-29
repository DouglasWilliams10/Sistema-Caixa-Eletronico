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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ttbCpf = new MaskedTextBox();
            ttbNome = new TextBox();
            ttbSenha = new TextBox();
            ttbConfirmarSenha = new TextBox();
            ttbData = new MaskedTextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // ttbCpf
            // 
            resources.ApplyResources(ttbCpf, "ttbCpf");
            ttbCpf.Name = "ttbCpf";
            // 
            // ttbNome
            // 
            resources.ApplyResources(ttbNome, "ttbNome");
            ttbNome.Name = "ttbNome";
            // 
            // ttbSenha
            // 
            resources.ApplyResources(ttbSenha, "ttbSenha");
            ttbSenha.Name = "ttbSenha";
            ttbSenha.TextChanged += ttbSenha_TextChanged;
            // 
            // ttbConfirmarSenha
            // 
            resources.ApplyResources(ttbConfirmarSenha, "ttbConfirmarSenha");
            ttbConfirmarSenha.Name = "ttbConfirmarSenha";
            // 
            // ttbData
            // 
            resources.ApplyResources(ttbData, "ttbData");
            ttbData.Name = "ttbData";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // CadastroCliente
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(ttbData);
            Controls.Add(ttbConfirmarSenha);
            Controls.Add(ttbSenha);
            Controls.Add(ttbNome);
            Controls.Add(ttbCpf);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox ttbCpf;
        private TextBox ttbNome;
        private TextBox ttbSenha;
        private TextBox ttbConfirmarSenha;
        private MaskedTextBox ttbData;
        private Label label7;
        private TextBox textBox1;
        private Label label8;
    }
}