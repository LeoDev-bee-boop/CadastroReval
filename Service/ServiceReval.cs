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
            _cmd.CommandText = @"INSERT INTO CLIENTE(NOME_CLIENTE, CPF, RG, EMAIL, DATA_NASCIMENTO, CEP, TELEFONE, BAIRRO, CIDADE, ESTADO, OBSERVACAO)
                                 VALUES (@NOME, @CPF, @RG, @EMAIL, @DATA_NASCIMENTO, @CEP, @TELEFONE, @BAIRRO, @CIDADE, @ESTADO, @OBSERVACAO)";

            //Adicionado parametros
            _cmd.Parameters.AddWithValue("@NOME", _cliente.NomeCliente);
            _cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
            _cmd.Parameters.AddWithValue("@RG", _cliente.RG);
            _cmd.Parameters.AddWithValue("@EMAIL", _cliente.Email);
            _cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _cliente.DataNascimento.ToString());
            _cmd.Parameters.AddWithValue("@CEP", _cliente.CEP);
            _cmd.Parameters.AddWithValue("@TELEFONE", _cliente.Telefone);
            _cmd.Parameters.AddWithValue("@BAIRRO", _cliente.Bairro);
            _cmd.Parameters.AddWithValue("@CIDADE", _cliente.Cidade);
            _cmd.Parameters.AddWithValue("@ESTADO", _cliente.Estado);
            _cmd.Parameters.AddWithValue("@OBSERVACAO", _cliente.Observacao);

            try
            {
                //Conecar com o banco
                _cmd.Connection = _con.conectar();
                //Executando consulta
                _cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //desconectando
                _con.desconectar();
            }
        }
    }
}
