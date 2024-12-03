namespace WindowsFormsApp1
{
    partial class Frm_TelaCadastro
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_RA = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(11, 9);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(244, 45);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Novo aluno:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(19, 139);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(237, 20);
            this.txt_Nome.TabIndex = 2;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(16, 226);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(237, 20);
            this.txt_Email.TabIndex = 3;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(336, 226);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(237, 20);
            this.txt_Senha.TabIndex = 4;
            this.txt_Senha.TextChanged += new System.EventHandler(this.txt_Senha_TextChanged);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(11, 112);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(84, 25);
            this.lbl_Nome.TabIndex = 5;
            this.lbl_Nome.Text = "Nome:";
            this.lbl_Nome.Click += new System.EventHandler(this.lbl_Nome_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(11, 199);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(80, 25);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(331, 199);
            this.lbl_Senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(88, 25);
            this.lbl_Senha.TabIndex = 7;
            this.lbl_Senha.Text = "Senha:";
            this.lbl_Senha.Click += new System.EventHandler(this.lbl_Senha_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.Btn_Voltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.Btn_Voltar.Location = new System.Drawing.Point(19, 305);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(177, 50);
            this.Btn_Voltar.TabIndex = 8;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.Btn_Cadastrar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(396, 305);
            this.Btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(177, 50);
            this.Btn_Cadastrar.TabIndex = 9;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // lbl_RA
            // 
            this.lbl_RA.AutoSize = true;
            this.lbl_RA.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RA.Location = new System.Drawing.Point(331, 112);
            this.lbl_RA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RA.Name = "lbl_RA";
            this.lbl_RA.Size = new System.Drawing.Size(51, 25);
            this.lbl_RA.TabIndex = 10;
            this.lbl_RA.Text = "RA:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(336, 139);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(237, 20);
            this.txt_Id.TabIndex = 11;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(398, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_RA);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Titulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_TelaCadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.Label lbl_RA;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}