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
        int _idCliente;
        Cliente _cliente = new Cliente();
        BusinessReval _business = new BusinessReval();
        
        public frmCadastraAtualizaCliente(int idCliente = 0)
        {
            InitializeComponent();
            
            _idCliente = idCliente;
        }
        
        private void frmCadastraAtualizaCliente_Load(object sender, EventArgs e)
        {
            if(_idCliente != 0)
            {
                prepararAtualizarForm();
                atribuiDadosClienteComponente();
                btnExcluir.Visible = true;
            }
        }

        private void prepararAtualizarForm()
        {
            _cliente = _business.buscaCliente(_idCliente);

            btnGravar.Text = "Atualizar";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(_idCliente == 0)
            {
                gravarCliente();
            }
            else
            {
                atualizaCliente();
            }
                
        }

        private void gravarCliente()
        {
            if (validaDadosCliente() == false)
                return;

            atribuiDadosCliente();

            _business.cadastraCliente(_cliente);

            MessageBox.Show("Cliente salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void atualizaCliente()
        {
            if (validaDadosCliente() == false)
                return;

            atribuiDadosCliente();

            _business.atualizaCliente(_cliente);

            MessageBox.Show("Cliente atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void atribuiDadosCliente()
        {
            _cliente.NomeCliente    = txtNomeCliente.Text;
            _cliente.CPF            = mtbCPF.Text;
            _cliente.RG             = mtbRG.Text;            
            _cliente.Email          = txtEmail.Text;
            _cliente.DataNascimento = dtpNascimento.MinDate;
            _cliente.CEP            = mtbCEP.Text;
            _cliente.Telefone       = mtbTelefone.Text;
            _cliente.Bairro         = txtBairro.Text;
            _cliente.Cidade         = txtCidade.Text;
            _cliente.Estado         = txtEstado.Text;
            _cliente.Observacao     = txtObs.Text;
        }

        private void atribuiDadosClienteComponente()
        {
            txtNomeCliente.Text     = _cliente.NomeCliente;
            mtbCPF.Text             = _cliente.CPF;
            mtbRG.Text              = _cliente.RG;
            txtEmail.Text           = _cliente.Email;
            dtpNascimento.MinDate   = _cliente.DataNascimento;
            mtbCEP.Text             = _cliente.CEP;
            mtbTelefone.Text        = _cliente.Telefone;
            txtBairro.Text          = _cliente.Bairro;
            txtCidade.Text          = _cliente.Cidade;
            txtEstado.Text          = _cliente.Estado;
            txtObs.Text             = _cliente.Observacao;
        }

        private bool validaDadosCliente()
        {
            if (string.IsNullOrEmpty(txtNomeCliente.Text.Trim()))
            {
                MessageBox.Show("Insira o nome do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(mtbCPF.Text.Trim()))
            {
               mtbCPF.TextMaskFormat =  MaskFormat.ExcludePromptAndLiterals;

                MessageBox.Show("Insira o CPF do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(mtbRG.Text.Trim()))
            {
                MessageBox.Show("Insira o nome do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Insira o email do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(mtbCEP.Text.Trim()))
            {
                MessageBox.Show("Insira o CEP do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(mtbTelefone.Text.Trim()))
            {
                MessageBox.Show("Insira o telefone do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text.Trim()))
            {
                MessageBox.Show("Insira o bairro do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text.Trim()))
            {
                MessageBox.Show("Insira a cidade do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(result == DialogResult.Yes)
            {
                _business.excluirCliente(_cliente.IdCliente);
                this.Close();
            }
        }
    }
}
