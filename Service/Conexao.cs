using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroReval.Service
{
    public class Conexao
    {
        SqlConnection _con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            _con.ConnectionString = @"Server=localhost;Database=REVAL;Trusted_Connection=True";
        }

        //Metodo Conextar
        public SqlConnection conectar()
        {
            if(_con.State == System.Data.ConnectionState.Closed)
            {
                _con.Open();
            }
            
            return _con;
        }

        public void desconectar()
        {
            if (_con.State == System.Data.ConnectionState.Open)
            {
                _con.Close();
            }
        }
    }
}
