namespace WindowsFormsApp1
{
    partial class Frm_CadAluno
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
            this.txt_Ra = new System.Windows.Forms.TextBox();
            this.lbl_Ra = new System.Windows.Forms.Label();
            this.lbl_NomeAluno = new System.Windows.Forms.Label();
            this.txt_NomeAluno = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.txt_Curso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_CadAluno = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Ra
            // 
            this.txt_Ra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ra.Location = new System.Drawing.Point(17, 153);
            this.txt_Ra.Name = "txt_Ra";
            this.txt_Ra.Size = new System.Drawing.Size(360, 31);
            this.txt_Ra.TabIndex = 0;
            this.txt_Ra.TextChanged += new System.EventHandler(this.txt_Ra_TextChanged);
            // 
            // lbl_Ra
            // 
            this.lbl_Ra.AutoSize = true;
            this.lbl_Ra.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ra.Location = new System.Drawing.Point(12, 125);
            this.lbl_Ra.Name = "lbl_Ra";
            this.lbl_Ra.Size = new System.Drawing.Size(51, 25);
            this.lbl_Ra.TabIndex = 1;
            this.lbl_Ra.Text = "RA:";
            this.lbl_Ra.Click += new System.EventHandler(this.lbl_Ra_Click);
            // 
            // lbl_NomeAluno
            // 
            this.lbl_NomeAluno.AutoSize = true;
            this.lbl_NomeAluno.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeAluno.Location = new System.Drawing.Point(9, 187);
            this.lbl_NomeAluno.Name = "lbl_NomeAluno";
            this.lbl_NomeAluno.Size = new System.Drawing.Size(84, 25);
            this.lbl_NomeAluno.TabIndex = 2;
            this.lbl_NomeAluno.Text = "Nome:";
            // 
            // txt_NomeAluno
            // 
            this.txt_NomeAluno.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeAluno.Location = new System.Drawing.Point(17, 215);
            this.txt_NomeAluno.Name = "txt_NomeAluno";
            this.txt_NomeAluno.Size = new System.Drawing.Size(360, 33);
            this.txt_NomeAluno.TabIndex = 3;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(9, 251);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(80, 25);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(17, 279);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(360, 33);
            this.txt_Email.TabIndex = 5;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(423, 251);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(88, 25);
            this.lbl_Senha.TabIndex = 6;
            this.lbl_Senha.Text = "Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(428, 279);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(360, 33);
            this.txt_Senha.TabIndex = 7;
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Curso.Location = new System.Drawing.Point(423, 123);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(83, 25);
            this.lbl_Curso.TabIndex = 8;
            this.lbl_Curso.Text = "Curso:";
            // 
            // txt_Curso
            // 
            this.txt_Curso.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Curso.Location = new System.Drawing.Point(428, 151);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Size = new System.Drawing.Size(360, 33);
            this.txt_Curso.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 42);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cadastrar Aluno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_CadAluno
            // 
            this.btn_CadAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_CadAluno.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadAluno.ForeColor = System.Drawing.Color.White;
            this.btn_CadAluno.Location = new System.Drawing.Point(586, 371);
            this.btn_CadAluno.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadAluno.Name = "btn_CadAluno";
            this.btn_CadAluno.Size = new System.Drawing.Size(202, 48);
            this.btn_CadAluno.TabIndex = 15;
            this.btn_CadAluno.Text = "Cadastrar";
            this.btn_CadAluno.UseVisualStyleBackColor = false;
            this.btn_CadAluno.Click += new System.EventHandler(this.btn_CadAluno_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar.Location = new System.Drawing.Point(11, 371);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(202, 48);
            this.btn_Voltar.TabIndex = 16;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // Frm_CadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_CadAluno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Curso);
            this.Controls.Add(this.lbl_Curso);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_NomeAluno);
            this.Controls.Add(this.lbl_NomeAluno);
            this.Controls.Add(this.lbl_Ra);
            this.Controls.Add(this.txt_Ra);
            this.Name = "Frm_CadAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ra;
        private System.Windows.Forms.Label lbl_Ra;
        private System.Windows.Forms.Label lbl_NomeAluno;
        private System.Windows.Forms.TextBox txt_NomeAluno;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.TextBox txt_Curso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CadAluno;
        private System.Windows.Forms.Button btn_Voltar;
    }
}