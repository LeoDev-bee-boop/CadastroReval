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
    }
}
