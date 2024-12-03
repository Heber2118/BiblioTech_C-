namespace WindowsFormsApp1
{
    partial class Frm_GrnLivro
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_AtualizarCadastro = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Result);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainer1.Panel2.Controls.Add(this.btn_AtualizarCadastro);
            this.splitContainer1.Panel2.Controls.Add(this.button_voltar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Deletar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Pesquisar);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txt_pesquisar);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados do Livro:";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.ForeColor = System.Drawing.Color.Black;
            this.lbl_Result.Location = new System.Drawing.Point(9, 88);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(324, 25);
            this.lbl_Result.TabIndex = 0;
            this.lbl_Result.Text = "________________________";
            // 
            // btn_AtualizarCadastro
            // 
            this.btn_AtualizarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_AtualizarCadastro.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtualizarCadastro.ForeColor = System.Drawing.Color.White;
            this.btn_AtualizarCadastro.Location = new System.Drawing.Point(70, 202);
            this.btn_AtualizarCadastro.Name = "btn_AtualizarCadastro";
            this.btn_AtualizarCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_AtualizarCadastro.Size = new System.Drawing.Size(243, 46);
            this.btn_AtualizarCadastro.TabIndex = 11;
            this.btn_AtualizarCadastro.Text = "Atualizar Cadastro";
            this.btn_AtualizarCadastro.UseVisualStyleBackColor = false;
            this.btn_AtualizarCadastro.Click += new System.EventHandler(this.btn_AtualizarCadastro_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.button_voltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_voltar.ForeColor = System.Drawing.Color.White;
            this.button_voltar.Location = new System.Drawing.Point(224, 392);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_voltar.Size = new System.Drawing.Size(147, 46);
            this.button_voltar.TabIndex = 9;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_Deletar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.ForeColor = System.Drawing.Color.White;
            this.btn_Deletar.Location = new System.Drawing.Point(195, 137);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Deletar.Size = new System.Drawing.Size(176, 46);
            this.btn_Deletar.TabIndex = 8;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_Pesquisar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_Pesquisar.Location = new System.Drawing.Point(23, 137);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Pesquisar.Size = new System.Drawing.Size(166, 46);
            this.btn_Pesquisar.TabIndex = 7;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pesquisar:";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.Location = new System.Drawing.Point(23, 88);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(348, 43);
            this.txt_pesquisar.TabIndex = 0;
            // 
            // Frm_GrnLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_GrnLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frn_GrnLivro";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Button btn_AtualizarCadastro;
    }
}