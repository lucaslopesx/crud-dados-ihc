﻿
namespace crud_dados_ihc
{
    partial class frmAlterar
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
            this.cbPerguntaId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdAlterar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // cbPerguntaId
            // 
            this.cbPerguntaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerguntaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerguntaId.FormattingEnabled = true;
            this.cbPerguntaId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbPerguntaId.Location = new System.Drawing.Point(655, 15);
            this.cbPerguntaId.Name = "cbPerguntaId";
            this.cbPerguntaId.Size = new System.Drawing.Size(56, 32);
            this.cbPerguntaId.TabIndex = 63;
            this.cbPerguntaId.SelectedIndexChanged += new System.EventHandler(this.cbPerguntaId_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "Id da pergunta:";
            // 
            // cmdAlterar
            // 
            this.cmdAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlterar.Location = new System.Drawing.Point(337, 451);
            this.cmdAlterar.Name = "cmdAlterar";
            this.cmdAlterar.Size = new System.Drawing.Size(179, 50);
            this.cmdAlterar.TabIndex = 61;
            this.cmdAlterar.Text = "Alterar";
            this.cmdAlterar.UseVisualStyleBackColor = true;
            this.cmdAlterar.Click += new System.EventHandler(this.cmdAlterar_Click);
            // 
            // cbResposta
            // 
            this.cbResposta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResposta.FormattingEnabled = true;
            this.cbResposta.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbResposta.Location = new System.Drawing.Point(175, 367);
            this.cbResposta.Name = "cbResposta";
            this.cbResposta.Size = new System.Drawing.Size(56, 32);
            this.cbResposta.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 59;
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
            this.cbCategoria.Location = new System.Drawing.Point(242, 12);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(190, 32);
            this.cbCategoria.TabIndex = 58;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // txtPerguntaD
            // 
            this.txtPerguntaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaD.Location = new System.Drawing.Point(175, 277);
            this.txtPerguntaD.Multiline = true;
            this.txtPerguntaD.Name = "txtPerguntaD";
            this.txtPerguntaD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerguntaD.Size = new System.Drawing.Size(578, 64);
            this.txtPerguntaD.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Pergunta D";
            // 
            // txtPerguntaC
            // 
            this.txtPerguntaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaC.Location = new System.Drawing.Point(175, 206);
            this.txtPerguntaC.Multiline = true;
            this.txtPerguntaC.Name = "txtPerguntaC";
            this.txtPerguntaC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerguntaC.Size = new System.Drawing.Size(578, 64);
            this.txtPerguntaC.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Pergunta C";
            // 
            // txtPerguntaB
            // 
            this.txtPerguntaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaB.Location = new System.Drawing.Point(175, 136);
            this.txtPerguntaB.Multiline = true;
            this.txtPerguntaB.Name = "txtPerguntaB";
            this.txtPerguntaB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerguntaB.Size = new System.Drawing.Size(578, 64);
            this.txtPerguntaB.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Pergunta B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Categoria:";
            // 
            // txtPerguntaA
            // 
            this.txtPerguntaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerguntaA.Location = new System.Drawing.Point(175, 66);
            this.txtPerguntaA.Multiline = true;
            this.txtPerguntaA.Name = "txtPerguntaA";
            this.txtPerguntaA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPerguntaA.Size = new System.Drawing.Size(578, 64);
            this.txtPerguntaA.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Pergunta A";
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.cbPerguntaId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdAlterar);
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
            this.Name = "frmAlterar";
            this.Text = "frmAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPerguntaId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdAlterar;
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
    }
}