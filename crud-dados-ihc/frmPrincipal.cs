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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro fc = new frmCadastro();
            fc.ShowDialog();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            frmAlterar fa = new frmAlterar();
            fa.ShowDialog();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            frmExcluir fe = new frmExcluir();
            fe.ShowDialog();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            frmListar fl = new frmListar();
            fl.ShowDialog();
        }
    }
}
