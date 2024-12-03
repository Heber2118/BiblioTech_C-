namespace WindowsFormsApp1
{
    partial class Frm_EditarLivro
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_EditCad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Estoque = new System.Windows.Forms.Label();
            this.txt_Gênero = new System.Windows.Forms.TextBox();
            this.lbl_Gênero = new System.Windows.Forms.Label();
            this.txt_NovoAutor = new System.Windows.Forms.TextBox();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.txt_NovoTitulo = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nmr_Quantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar.Location = new System.Drawing.Point(441, 197);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(202, 48);
            this.btn_Voltar.TabIndex = 30;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            // 
            // btn_EditCad
            // 
            this.btn_EditCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_EditCad.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCad.ForeColor = System.Drawing.Color.White;
            this.btn_EditCad.Location = new System.Drawing.Point(441, 133);
            this.btn_EditCad.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditCad.Name = "btn_EditCad";
            this.btn_EditCad.Size = new System.Drawing.Size(202, 48);
            this.btn_EditCad.TabIndex = 29;
            this.btn_EditCad.Text = "Editar";
            this.btn_EditCad.UseVisualStyleBackColor = false;
            this.btn_EditCad.Click += new System.EventHandler(this.btn_EditCad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 42);
            this.label5.TabIndex = 28;
            this.label5.Text = "Editar Cadastro";
            // 
            // lbl_Estoque
            // 
            this.lbl_Estoque.AutoSize = true;
            this.lbl_Estoque.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estoque.Location = new System.Drawing.Point(15, 273);
            this.lbl_Estoque.Name = "lbl_Estoque";
            this.lbl_Estoque.Size = new System.Drawing.Size(167, 25);
            this.lbl_Estoque.TabIndex = 25;
            this.lbl_Estoque.Text = "Novo Estoque:";
            // 
            // txt_Gênero
            // 
            this.txt_Gênero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gênero.Location = new System.Drawing.Point(15, 237);
            this.txt_Gênero.Name = "txt_Gênero";
            this.txt_Gênero.Size = new System.Drawing.Size(360, 33);
            this.txt_Gênero.TabIndex = 24;
            // 
            // lbl_Gênero
            // 
            this.lbl_Gênero.AutoSize = true;
            this.lbl_Gênero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gênero.Location = new System.Drawing.Point(15, 209);
            this.lbl_Gênero.Name = "lbl_Gênero";
            this.lbl_Gênero.Size = new System.Drawing.Size(160, 25);
            this.lbl_Gênero.TabIndex = 23;
            this.lbl_Gênero.Text = "Novo Gênero:";
            // 
            // txt_NovoAutor
            // 
            this.txt_NovoAutor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NovoAutor.Location = new System.Drawing.Point(15, 173);
            this.txt_NovoAutor.Name = "txt_NovoAutor";
            this.txt_NovoAutor.Size = new System.Drawing.Size(360, 33);
            this.txt_NovoAutor.TabIndex = 22;
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Autor.Location = new System.Drawing.Point(15, 145);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(140, 25);
            this.lbl_Autor.TabIndex = 21;
            this.lbl_Autor.Text = "Novo Autor:";
            // 
            // txt_NovoTitulo
            // 
            this.txt_NovoTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NovoTitulo.Location = new System.Drawing.Point(15, 109);
            this.txt_NovoTitulo.Name = "txt_NovoTitulo";
            this.txt_NovoTitulo.Size = new System.Drawing.Size(360, 33);
            this.txt_NovoTitulo.TabIndex = 20;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(15, 81);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(142, 25);
            this.lbl_Titulo.TabIndex = 19;
            this.lbl_Titulo.Text = "Novo Titulo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(420, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // nmr_Quantidade
            // 
            this.nmr_Quantidade.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmr_Quantidade.Location = new System.Drawing.Point(15, 301);
            this.nmr_Quantidade.Name = "nmr_Quantidade";
            this.nmr_Quantidade.Size = new System.Drawing.Size(360, 33);
            this.nmr_Quantidade.TabIndex = 31;
            // 
            // Frm_EditarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 357);
            this.Controls.Add(this.nmr_Quantidade);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_EditCad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Estoque);
            this.Controls.Add(this.txt_Gênero);
            this.Controls.Add(this.lbl_Gênero);
            this.Controls.Add(this.txt_NovoAutor);
            this.Controls.Add(this.lbl_Autor);
            this.Controls.Add(this.txt_NovoTitulo);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_EditarLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EditarLivro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_EditCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Estoque;
        private System.Windows.Forms.TextBox txt_Gênero;
        private System.Windows.Forms.Label lbl_Gênero;
        private System.Windows.Forms.TextBox txt_NovoAutor;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.TextBox txt_NovoTitulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.NumericUpDown nmr_Quantidade;
    }
}