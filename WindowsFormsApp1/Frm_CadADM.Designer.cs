namespace WindowsFormsApp1
{
    partial class Frm_CadADM
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nomeADM = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_nomeADM = new System.Windows.Forms.TextBox();
            this.txt_emailADM = new System.Windows.Forms.TextBox();
            this.txt_senhaADM = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_CadADM = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(554, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_cargo
            // 
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo.Location = new System.Drawing.Point(17, 177);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(342, 31);
            this.txt_cargo.TabIndex = 2;
            this.txt_cargo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 149);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(215, 25);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Informe seu cargo:";
            // 
            // lbl_nomeADM
            // 
            this.lbl_nomeADM.AutoSize = true;
            this.lbl_nomeADM.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeADM.Location = new System.Drawing.Point(12, 237);
            this.lbl_nomeADM.Name = "lbl_nomeADM";
            this.lbl_nomeADM.Size = new System.Drawing.Size(215, 25);
            this.lbl_nomeADM.TabIndex = 4;
            this.lbl_nomeADM.Text = "Informe seu nome:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(430, 149);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(214, 25);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Informe seu e-mail";
            // 
            // txt_nomeADM
            // 
            this.txt_nomeADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeADM.Location = new System.Drawing.Point(17, 265);
            this.txt_nomeADM.Name = "txt_nomeADM";
            this.txt_nomeADM.Size = new System.Drawing.Size(340, 31);
            this.txt_nomeADM.TabIndex = 6;
            // 
            // txt_emailADM
            // 
            this.txt_emailADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailADM.Location = new System.Drawing.Point(430, 177);
            this.txt_emailADM.Name = "txt_emailADM";
            this.txt_emailADM.Size = new System.Drawing.Size(340, 31);
            this.txt_emailADM.TabIndex = 7;
            // 
            // txt_senhaADM
            // 
            this.txt_senhaADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhaADM.Location = new System.Drawing.Point(430, 265);
            this.txt_senhaADM.Name = "txt_senhaADM";
            this.txt_senhaADM.Size = new System.Drawing.Size(340, 31);
            this.txt_senhaADM.TabIndex = 9;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(425, 237);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(219, 25);
            this.lbl_senha.TabIndex = 8;
            this.lbl_senha.Text = "Informe sua senha:";
            this.lbl_senha.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_CadADM
            // 
            this.btn_CadADM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_CadADM.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadADM.ForeColor = System.Drawing.Color.White;
            this.btn_CadADM.Location = new System.Drawing.Point(587, 391);
            this.btn_CadADM.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadADM.Name = "btn_CadADM";
            this.btn_CadADM.Size = new System.Drawing.Size(202, 48);
            this.btn_CadADM.TabIndex = 10;
            this.btn_CadADM.Text = "Cadastrar";
            this.btn_CadADM.UseVisualStyleBackColor = false;
            this.btn_CadADM.Click += new System.EventHandler(this.btn_CadADM_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar.Location = new System.Drawing.Point(11, 391);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(202, 48);
            this.btn_Voltar.TabIndex = 11;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cadastre-se";
            // 
            // Frm_CadADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_CadADM);
            this.Controls.Add(this.txt_senhaADM);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_emailADM);
            this.Controls.Add(this.txt_nomeADM);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nomeADM);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_CadADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CadADM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nomeADM;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_nomeADM;
        private System.Windows.Forms.TextBox txt_emailADM;
        private System.Windows.Forms.TextBox txt_senhaADM;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_CadADM;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label label5;
    }
}