namespace WindowsFormsApp1
{
    partial class Frm_TelaLogin
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
            this.txt_RA = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_RA
            // 
            this.txt_RA.Location = new System.Drawing.Point(144, 157);
            this.txt_RA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_RA.Name = "txt_RA";
            this.txt_RA.Size = new System.Drawing.Size(307, 20);
            this.txt_RA.TabIndex = 1;
            this.txt_RA.TextChanged += new System.EventHandler(this.txt_RA_TextChanged);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(139, 130);
            this.lbl_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Id.Size = new System.Drawing.Size(46, 25);
            this.lbl_Id.TabIndex = 2;
            this.lbl_Id.Text = "ID:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(139, 179);
            this.lbl_Senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(88, 25);
            this.lbl_Senha.TabIndex = 3;
            this.lbl_Senha.Text = "Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(144, 206);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(307, 20);
            this.txt_Senha.TabIndex = 4;
            this.txt_Senha.TextChanged += new System.EventHandler(this.txt_Senha_TextChanged);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.Btn_Voltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.Btn_Voltar.Location = new System.Drawing.Point(144, 250);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(134, 48);
            this.Btn_Voltar.TabIndex = 5;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.button1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(317, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(144, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_RA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_TelaLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_RA;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}