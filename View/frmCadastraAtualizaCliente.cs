using CadastroReval.Business;
using CadastroReval.Class;
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
    public partial class frmCadastraAtualizaCliente : Form
    {
        Cliente _cliente = new Cliente();
        BusinessReval _business = new BusinessReval();
        
        public frmCadastraAtualizaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmCadastraAtualizaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            gravarCliente();
        }

        private void gravarCliente()
        {
            if (validaDadosCliente() == false)
                return;

            atribuiDadosCliente();

            _business.cadastraCliente(_cliente);
        }

        private void atribuiDadosCliente()
        {
            _cliente.NomeCliente = txtNomeCliente.Text;
            _cliente.CPF = mtbCPF.Text;
            _cliente.RG = mtbRG.Text;
            _cliente.EstadoCivil = cbEstadoCivil.Text;
            _cliente.Email = txtEmail.Text;
            _cliente.DataNascimento = dtpNascimento.MinDate;
            _cliente.CEP = mtbCEP.Text;
            _cliente.Telefone = mtbTelefone.Text;
            _cliente.Bairro = txtBairro.Text;
            _cliente.Cidade = txtCidade.Text;
            _cliente.Estado = cbEstado.Text;
            _cliente.Observacao = txtObs.Text;
        }

        private bool validaDadosCliente()
        {
            if (string.IsNullOrEmpty(txtNomeCliente.Text))
            {
                MessageBox.Show("Insira o nome do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(mtbCPF.Text))
            {
                MessageBox.Show("Insira o CPF do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Insira o email do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(mtbCEP.Text))
            {
                MessageBox.Show("Insira o CEP do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(mtbTelefone.Text))
            {
                MessageBox.Show("Insira o telefone do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Insira o bairro do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Insira a cidade do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbEstado.SelectedIndex == 0)
            {
                MessageBox.Show("Insira o estado do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbEstadoCivil.SelectedIndex == 0)
            {
                MessageBox.Show("Insira o estado civil do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
