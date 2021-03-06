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
                _cmd.ExecuteNonQuery();
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

        public void atualizaCliente(Cliente _cliente)
        {
            //Comando sql
            _cmd.CommandText = @"
                                UPDATE CLIENTE 
                                SET 
                                    NOME_CLIENTE = @NOME, 
                                    CPF = @CPF, 
                                    RG = @RG, 
                                    EMAIL = @EMAIL, 
                                    DATA_NASCIMENTO = @DATA_NASCIMENTO, 
                                    CEP = @CEP, 
                                    TELEFONE = @TELEFONE, 
                                    BAIRRO = @BAIRRO, 
                                    CIDADE = @CIDADE, 
                                    ESTADO = @ESTADO, 
                                    OBSERVACAO = @OBSERVACAO
                                WHERE
                                    ID_CLIENTE = @ID_CLIENTE";

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
            _cmd.Parameters.AddWithValue("@ID_CLIENTE", _cliente.IdCliente);

            try
            {
                //Conecar com o banco
                _cmd.Connection = _con.conectar();
                //Executando consulta
                _cmd.ExecuteNonQuery();
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
                                ORDER BY 
                                    CLIENTE";

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
        
        public Cliente buscaCliente(int idCliente)
        {
            var a = new Cliente();
            
            //Comando sql
            _cmd.CommandText = @"
                                SELECT 
                                    ID_CLIENTE AS ID,
                                    NOME_CLIENTE AS CLIENTE,
                                    CPF,
                                    RG,
                                    EMAIL,
                                    DATA_NASCIMENTO,
                                    CEP,
                                    TELEFONE,
                                    BAIRRO,
                                    CIDADE,
                                    ESTADO,
                                    OBSERVACAO
                                FROM CLIENTE WITH (NOLOCK)
                                WHERE 
                                    ID_CLIENTE = @ID
                                ORDER BY 
                                    CLIENTE";
            
            _cmd.Parameters.AddWithValue("@ID", idCliente);

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
                        CPF = Convert.ToString(_reader["CPF"]),
                        RG = Convert.ToString(_reader["RG"]),
                        Email = Convert.ToString(_reader["EMAIL"]),
                        DataNascimento = Convert.ToDateTime(_reader["DATA_NASCIMENTO"]).Date,
                        CEP = Convert.ToString(_reader["CEP"]),                        
                        Telefone = Convert.ToString(_reader["TELEFONE"]),
                        Bairro = Convert.ToString(_reader["BAIRRO"]),
                        Cidade = Convert.ToString(_reader["CIDADE"]),
                        Estado = Convert.ToString(_reader["ESTADO"]),
                        Observacao = Convert.ToString(_reader["OBSERVACAO"])
                    };

                    a = cliente;
                }
                return a;
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

        public void excluirCliente(int idCliente)
        {
            //Comando sql
            _cmd.CommandText = @"DELETE FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";

            //Adicionado parametros
            _cmd.Parameters.AddWithValue("@ID_CLIENTE", idCliente);

            try
            {
                //Conecar com o banco
                _cmd.Connection = _con.conectar();
                //Executando consulta
                _cmd.ExecuteNonQuery();
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
