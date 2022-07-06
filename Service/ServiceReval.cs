using CadastroReval.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroReval.Service
{
    public class ServiceReval
    {
        Conexao _con = new Conexao();
        SqlCommand _cmd = new SqlCommand();

        public void cadastraCliente(Cliente _cliente)
        {
            //Comando sql
            _cmd.CommandText = "";

            //parametros
            //_cmd.Parameters.AddWithValue("",);

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
