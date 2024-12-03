namespace WindowsFormsApp1
{
    partial class Frm_CadLivro
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
            this.lbl_NovoLivro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_Título = new System.Windows.Forms.TextBox();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.txt_Genero = new System.Windows.Forms.TextBox();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.btn_CadLivro = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.nmr_Quantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NovoLivro
            // 
            this.lbl_NovoLivro.AutoSize = true;
            this.lbl_NovoLivro.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NovoLivro.Location = new System.Drawing.Point(12, 9);
            this.lbl_NovoLivro.Name = "lbl_NovoLivro";
            this.lbl_NovoLivro.Size = new System.Drawing.Size(204, 42);
            this.lbl_NovoLivro.TabIndex = 13;
            this.lbl_NovoLivro.Text = "Novo Livro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(553, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(14, 97);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(81, 25);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "Título:";
            // 
            // txt_Título
            // 
            this.txt_Título.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Título.Location = new System.Drawing.Point(19, 125);
            this.txt_Título.Name = "txt_Título";
            this.txt_Título.Size = new System.Drawing.Size(342, 31);
            this.txt_Título.TabIndex = 16;
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Autor.Location = new System.Drawing.Point(14, 178);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(79, 25);
            this.lbl_Autor.TabIndex = 17;
            this.lbl_Autor.Text = "Autor:";
            // 
            // txt_Autor
            // 
            this.txt_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Autor.Location = new System.Drawing.Point(19, 206);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(342, 31);
            this.txt_Autor.TabIndex = 18;
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genero.Location = new System.Drawing.Point(406, 97);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(99, 25);
            this.lbl_Genero.TabIndex = 19;
            this.lbl_Genero.Text = "Genero:";
            // 
            // txt_Genero
            // 
            this.txt_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Genero.Location = new System.Drawing.Point(411, 125);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.Size = new System.Drawing.Size(340, 31);
            this.txt_Genero.TabIndex = 20;
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantidade.Location = new System.Drawing.Point(406, 178);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(144, 25);
            this.lbl_Quantidade.TabIndex = 21;
            this.lbl_Quantidade.Text = "Quantidade:";
            // 
            // btn_CadLivro
            // 
            this.btn_CadLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_CadLivro.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadLivro.ForeColor = System.Drawing.Color.White;
            this.btn_CadLivro.Location = new System.Drawing.Point(587, 391);
            this.btn_CadLivro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadLivro.Name = "btn_CadLivro";
            this.btn_CadLivro.Size = new System.Drawing.Size(202, 48);
            this.btn_CadLivro.TabIndex = 23;
            this.btn_CadLivro.Text = "OK";
            this.btn_CadLivro.UseVisualStyleBackColor = false;
            this.btn_CadLivro.Click += new System.EventHandler(this.btn_CadLivro_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar.Location = new System.Drawing.Point(19, 391);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(202, 48);
            this.btn_Voltar.TabIndex = 24;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // nmr_Quantidade
            // 
            this.nmr_Quantidade.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmr_Quantidade.Location = new System.Drawing.Point(411, 206);
            this.nmr_Quantidade.Name = "nmr_Quantidade";
            this.nmr_Quantidade.Size = new System.Drawing.Size(340, 33);
            this.nmr_Quantidade.TabIndex = 25;
            // 
            // Frm_CadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nmr_Quantidade);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_CadLivro);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.txt_Genero);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.txt_Autor);
            this.Controls.Add(this.lbl_Autor);
            this.Controls.Add(this.txt_Título);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_NovoLivro);
            this.Name = "Frm_CadLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Livro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NovoLivro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_Título;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.TextBox txt_Genero;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.Button btn_CadLivro;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.NumericUpDown nmr_Quantidade;
    }
}