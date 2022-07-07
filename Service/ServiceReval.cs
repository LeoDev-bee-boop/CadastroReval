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
        SqlDataReader _reader;

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
                _reader = _cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar consulta: " + ex);
            }
            finally
            {
                //desconectando
                _con.desconectar();
            }
        }

        public List<Cliente> carregaGridCliente()
        {
            var lista = new List<Cliente>();
            
            //Comando sql
            _cmd.CommandText = @"
                                SELECT 
                                ID_CLIENTE AS ID,
                                NOME_CLIENTE AS CLIENTE,
                                EMAIL,
                                TELEFONE
                                FROM CLIENTE WITH (NOLOCK)
                                ORDER BY CLIENTE";

            try
            {
                //Conecar com o banco
                _cmd.Connection = _con.conectar();
                //Executando consulta
                _reader = _cmd.ExecuteReader();

                while (_reader.Read())
                {
                    var cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(_reader["ID"]),
                        NomeCliente = Convert.ToString(_reader["CLIENTE"]),
                        Email = Convert.ToString(_reader["EMAIL"]),
                        Telefone = Convert.ToString(_reader["TELEFONE"])
                    };

                    lista.Add(cliente);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar consulta: " + ex);
            }
            finally
            {
                //desconectando
                _con.desconectar();
            }
        }
    }
}
