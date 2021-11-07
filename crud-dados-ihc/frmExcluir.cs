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
    public partial class frmExcluir : Form
    {
        Perguntas data = new Perguntas();

        public frmExcluir()
        {
            InitializeComponent();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            data.IdPergunta = int.Parse(cbPerguntaId.SelectedValue.ToString());
            data.Delete();
            MessageBox.Show("Registro excluido com sucesso");
            cbCategoria_SelectedIndexChanged(sender, e);
        }

        private void frmExcluir_Load(object sender, EventArgs e)
        {
            
        }

        private void cbPerguntaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.IdPergunta = int.Parse(cbPerguntaId.SelectedValue.ToString());
            data.Consult();

            txtPerguntaA.Text = data.PerguntaA;
            txtPerguntaB.Text = data.PerguntaB;
            txtPerguntaC.Text = data.PerguntaC;
            txtPerguntaD.Text = data.PerguntaD;
            cbCategoria.Text = data.Categoria;
            cbResposta.Text = data.Resultado.ToString();
        }
       

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Categoria = cbCategoria.SelectedItem.ToString();
            cbPerguntaId.DisplayMember = "idPergunta";
            cbPerguntaId.ValueMember = "idPergunta";
            cbPerguntaId.DataSource = data.List().Tables[0];
            txtPerguntaA.Clear();
            txtPerguntaB.Clear();
            txtPerguntaC.Clear();
            txtPerguntaD.Clear();
        }
    }
}
