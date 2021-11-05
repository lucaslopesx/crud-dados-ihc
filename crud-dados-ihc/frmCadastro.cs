using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_dados_ihc
{
    public partial class frmCadastro : Form
    {
        Perguntas data = new Perguntas();
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            data.PerguntaA = txtPerguntaA.Text;
            data.PerguntaB = txtPerguntaB.Text;
            data.PerguntaC = txtPerguntaC.Text;
            data.PerguntaD = txtPerguntaD.Text;
            data.Categoria = cbCategoria.Text;
            data.Resultado = int.Parse(cbResposta.Text);
            data.Insert();

            MessageBox.Show("Registro incluido com sucesso");

            txtPerguntaA.Clear();
            txtPerguntaB.Clear();
            txtPerguntaC.Clear();
            txtPerguntaD.Clear();
        }
    }
}
