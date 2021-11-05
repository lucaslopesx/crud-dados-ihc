
namespace crud_dados_ihc
{
    partial class frmPrincipal
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
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdAlterar = new System.Windows.Forms.Button();
            this.cmdCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.Location = new System.Drawing.Point(369, 129);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(152, 66);
            this.cmdExcluir.TabIndex = 9;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastrar perguntas";
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(527, 129);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(152, 66);
            this.cmdListar.TabIndex = 7;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlterar.Location = new System.Drawing.Point(211, 129);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(152, 66);
            this.cmdAlterar.TabIndex = 6;
            this.cmdAlterar.Text = "Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cmdCadastrar
            // 
            this.cmdCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCadastrar.Location = new System.Drawing.Point(53, 129);
            this.cmdCadastrar.Name = "cmdCadastrar";
            this.cmdCadastrar.Size = new System.Drawing.Size(152, 66);
            this.cmdCadastrar.TabIndex = 5;
            this.cmdCadastrar.Text = "Cadastrar";
            this.cmdCadastrar.UseVisualStyleBackColor = true;
            this.cmdCadastrar.Click += new System.EventHandler(this.cmdCadastrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 276);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cmdAlterar);
            this.Controls.Add(this.cmdCadastrar);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdAlterar;
        private System.Windows.Forms.Button cmdCadastrar;
    }
}

