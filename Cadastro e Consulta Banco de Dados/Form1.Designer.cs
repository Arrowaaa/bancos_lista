namespace Cadastro_e_Consulta_Banco_de_Dados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar_Click = new System.Windows.Forms.Button();
            this.btnConsultar_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 40);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 32);
            this.txtNome.TabIndex = 0;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(22, 137);
            this.txtTipo.Multiline = true;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(199, 34);
            this.txtTipo.TabIndex = 1;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(22, 225);
            this.txtTemperatura.Multiline = true;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(199, 32);
            this.txtTemperatura.TabIndex = 2;
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(384, 24);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.Size = new System.Drawing.Size(382, 306);
            this.dgvPessoas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TIPO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TEMPERATURA";
            // 
            // btnCadastrar_Click
            // 
            this.btnCadastrar_Click.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar_Click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar_Click.Location = new System.Drawing.Point(25, 287);
            this.btnCadastrar_Click.Name = "btnCadastrar_Click";
            this.btnCadastrar_Click.Size = new System.Drawing.Size(119, 61);
            this.btnCadastrar_Click.TabIndex = 7;
            this.btnCadastrar_Click.Text = "CADASTRAR";
            this.btnCadastrar_Click.UseVisualStyleBackColor = false;
            this.btnCadastrar_Click.Click += new System.EventHandler(this.btnCadastrar_Click_Click);
            // 
            // btnConsultar_Click
            // 
            this.btnConsultar_Click.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar_Click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar_Click.Location = new System.Drawing.Point(179, 287);
            this.btnConsultar_Click.Name = "btnConsultar_Click";
            this.btnConsultar_Click.Size = new System.Drawing.Size(119, 61);
            this.btnConsultar_Click.TabIndex = 8;
            this.btnConsultar_Click.Text = "CONSULTAR";
            this.btnConsultar_Click.UseVisualStyleBackColor = false;
            this.btnConsultar_Click.Click += new System.EventHandler(this.btnConsultar_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar_Click);
            this.Controls.Add(this.btnCadastrar_Click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar_Click;
        private System.Windows.Forms.Button btnConsultar_Click;
    }
}

