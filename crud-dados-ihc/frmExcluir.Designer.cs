
namespace crud_dados_ihc
{
    partial class frmExcluir
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
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cbResposta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPerguntaD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerguntaC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerguntaB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPerguntaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPerguntaId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.Location = new System.Drawing.Point(307, 440);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(179, 50);
            this.cmdExcluir.TabIndex = 46;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cbResposta
            // 
            this.cbResposta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbResposta.Enabled = false;
            this.cbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResposta.FormattingEnabled = true;
            this.cbResposta.Location = new System.Drawing.Point(173, 361);
            this.cbResposta.Name = "cbResposta";
            this.cbResposta.Size = new System.Drawing.Size(56, 32);
            this.cbResposta.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Resposta:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "astronomia",
            "botanica",
            "fisica",
            "geografia",
            "quimica",
            "zoologia"});
            this.cbCategoria.Location = new System.Drawing.Point(246, 12);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(190, 32);
            this.cbCategoria.TabIndex = 43;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // txtPerguntaD
            // 
            this.txtPerguntaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaD.Location = new System.Drawing.Point(173, 277);
            this.txtPerguntaD.Multiline = true;
            this.txtPerguntaD.Name = "txtPerguntaD";
            this.txtPerguntaD.ReadOnly = true;
            this.txtPerguntaD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerguntaD.Size = new System.Drawing.Size(578, 64);
            this.txtPerguntaD.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Pergunta D";
            // 
            // txtPerguntaC
            // 
            this.txtPerguntaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaC.Location = new System.Drawing.Point(173, 206);
            this.txtPerguntaC.Multiline = true;
            this.txtPerguntaC.Name = "txtPerguntaC";
            this.txtPerguntaC.ReadOnly = true;
            this.txtPerguntaC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerguntaC.Size = new System.Drawing.Size(578, 64);
            this.txtPerguntaC.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pergunta C";
            // 
            // txtPerguntaB
            // 
            this.txtPerguntaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaB.Location = new System.Drawing.Point(173, 136);
            this.txtPerguntaB.Multiline = true;
            this.txtPerguntaB.Name = "txtPerguntaB";
            this.txtPerguntaB.ReadOnly = true;
            this.txtPerguntaB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerguntaB.Size = new System.Drawing.Size(578, 64);
            this.txtPerguntaB.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Pergunta B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Categoria:";
            // 
            // txtPerguntaA
            // 
            this.txtPerguntaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaA.Location = new System.Drawing.Point(173, 66);
            this.txtPerguntaA.Multiline = true;
            this.txtPerguntaA.Name = "txtPerguntaA";
            this.txtPerguntaA.ReadOnly = true;
            this.txtPerguntaA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerguntaA.Size = new System.Drawing.Size(578, 64);
            this.txtPerguntaA.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pergunta A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Id da pergunta:";
            // 
            // cbPerguntaId
            // 
            this.cbPerguntaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerguntaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerguntaId.FormattingEnabled = true;
            this.cbPerguntaId.Location = new System.Drawing.Point(642, 12);
            this.cbPerguntaId.Name = "cbPerguntaId";
            this.cbPerguntaId.Size = new System.Drawing.Size(56, 32);
            this.cbPerguntaId.TabIndex = 48;
            this.cbPerguntaId.SelectedIndexChanged += new System.EventHandler(this.cbPerguntaId_SelectedIndexChanged);
            // 
            // frmExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.cbPerguntaId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cbResposta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtPerguntaD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPerguntaC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerguntaB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPerguntaA);
            this.Controls.Add(this.label1);
            this.Name = "frmExcluir";
            this.Text = "frmExcluir";
            this.Load += new System.EventHandler(this.frmExcluir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.ComboBox cbResposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtPerguntaD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerguntaC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerguntaB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPerguntaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPerguntaId;
    }
}