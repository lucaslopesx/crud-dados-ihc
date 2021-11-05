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
    public partial class frmListar : Form
    {
        Perguntas data = new Perguntas();


        public frmListar()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            data.Categoria = cbCategoria.SelectedItem.ToString();
            dataGridView1.DataSource = data.List().Tables[0];
        }
    }
}
