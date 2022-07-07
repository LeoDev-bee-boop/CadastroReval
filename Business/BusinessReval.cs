using CadastroReval.Class;
using CadastroReval.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroReval.Business
{
    public class BusinessReval
    {
        ServiceReval _service = new ServiceReval();

        public void cadastraCliente(Cliente _cliente)
        {
            try
            {
                _service.cadastraCliente(_cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Cliente> carregaGridCliente()
        {
            try
            {
                return _service.carregaGridCliente();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar método" + ex);
            }
        }

        public Cliente buscaCliente(int idCliente)
        {
            try
            {
                return _service.buscaCliente(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar método: " + ex);
            }
        }

        public void excluirCliente(int idCliente)
        {
            try
            {
                _service.excluirCliente(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar método: " + ex);
            }
        }
    }
}
