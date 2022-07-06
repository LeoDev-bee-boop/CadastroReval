using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroReval.View
{
    public partial class frmGerenciadorContato : Form
    {
        public frmGerenciadorContato()
        {
            InitializeComponent();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            frmCadastraAtualizaCliente cadastra = new frmCadastraAtualizaCliente();
            cadastra.ShowDialog();
        }
    }
}
