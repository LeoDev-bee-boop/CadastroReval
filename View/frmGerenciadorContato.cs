using CadastroReval.Business;
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
        BusinessReval _business = new BusinessReval();


        public frmGerenciadorContato()
        {
            InitializeComponent();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            frmCadastraAtualizaCliente cadastra = new frmCadastraAtualizaCliente();
            cadastra.ShowDialog();
        }

        private void frmGerenciadorContato_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = _business.carregaGridCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int idCliente = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
                frmCadastraAtualizaCliente frmCadastraAtualizaCliente = new frmCadastraAtualizaCliente(idCliente);
                frmCadastraAtualizaCliente.ShowDialog();
                carregaGrid();
            }
        }
    }
}
