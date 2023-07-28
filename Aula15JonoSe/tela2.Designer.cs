namespace Aula15JonoSe
{
    partial class tela2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Tela2_Salvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.Txt_NomeC = new System.Windows.Forms.TextBox();
            this.txt_Tela2_Senha = new System.Windows.Forms.TextBox();
            this.txt_Tela2_Usuario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_Usuarios = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.txt_Busca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo ao gerenciador de clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.groupBox1.Controls.Add(this.btn_Tela2_Salvar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Data);
            this.groupBox1.Controls.Add(this.Txt_NomeC);
            this.groupBox1.Controls.Add(this.txt_Tela2_Senha);
            this.groupBox1.Controls.Add(this.txt_Tela2_Usuario);
            this.groupBox1.Location = new System.Drawing.Point(23, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btn_Tela2_Salvar
            // 
            this.btn_Tela2_Salvar.Location = new System.Drawing.Point(44, 252);
            this.btn_Tela2_Salvar.Name = "btn_Tela2_Salvar";
            this.btn_Tela2_Salvar.Size = new System.Drawing.Size(132, 26);
            this.btn_Tela2_Salvar.TabIndex = 8;
            this.btn_Tela2_Salvar.Text = "Salvar";
            this.btn_Tela2_Salvar.UseVisualStyleBackColor = true;
            this.btn_Tela2_Salvar.Click += new System.EventHandler(this.btn_Tela2_Salvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ano de nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome completo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite sua senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite seu usuario:";
            // 
            // txt_Data
            // 
            this.txt_Data.Location = new System.Drawing.Point(26, 213);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(244, 23);
            this.txt_Data.TabIndex = 3;
            // 
            // Txt_NomeC
            // 
            this.Txt_NomeC.Location = new System.Drawing.Point(27, 165);
            this.Txt_NomeC.Name = "Txt_NomeC";
            this.Txt_NomeC.Size = new System.Drawing.Size(243, 23);
            this.Txt_NomeC.TabIndex = 2;
            // 
            // txt_Tela2_Senha
            // 
            this.txt_Tela2_Senha.Location = new System.Drawing.Point(27, 116);
            this.txt_Tela2_Senha.Name = "txt_Tela2_Senha";
            this.txt_Tela2_Senha.PasswordChar = '*';
            this.txt_Tela2_Senha.Size = new System.Drawing.Size(243, 23);
            this.txt_Tela2_Senha.TabIndex = 1;
            // 
            // txt_Tela2_Usuario
            // 
            this.txt_Tela2_Usuario.Location = new System.Drawing.Point(27, 70);
            this.txt_Tela2_Usuario.Name = "txt_Tela2_Usuario";
            this.txt_Tela2_Usuario.Size = new System.Drawing.Size(243, 23);
            this.txt_Tela2_Usuario.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkOrchid;
            this.groupBox2.Controls.Add(this.listView_Usuarios);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_Procurar);
            this.groupBox2.Controls.Add(this.txt_Busca);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(447, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 287);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de clientes";
            // 
            // listView_Usuarios
            // 
            this.listView_Usuarios.Location = new System.Drawing.Point(25, 185);
            this.listView_Usuarios.Name = "listView_Usuarios";
            this.listView_Usuarios.Size = new System.Drawing.Size(278, 92);
            this.listView_Usuarios.TabIndex = 4;
            this.listView_Usuarios.UseCompatibleStateImageBehavior = false;
            this.listView_Usuarios.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Clientes Cadastrados";
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Location = new System.Drawing.Point(66, 107);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(215, 29);
            this.btn_Procurar.TabIndex = 2;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = true;
            // 
            // txt_Busca
            // 
            this.txt_Busca.Location = new System.Drawing.Point(14, 66);
            this.txt_Busca.Name = "txt_Busca";
            this.txt_Busca.Size = new System.Drawing.Size(295, 23);
            this.txt_Busca.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Buscar o cliente pelo nome";
            // 
            // tela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "tela2";
            this.Text = "tela2";
            this.Load += new System.EventHandler(this.tela2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_Data;
        private TextBox Txt_NomeC;
        private TextBox txt_Tela2_Senha;
        private TextBox txt_Tela2_Usuario;
        private GroupBox groupBox2;
        private ListView listView_Usuarios;
        private Label label7;
        private Button btn_Procurar;
        private TextBox txt_Busca;
        private Label label6;
        private Button btn_Tela2_Salvar;
    }
}