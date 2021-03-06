using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroReval.Class
{
    public class Cliente
    {
        public int      IdCliente       { get; set; }
        public string   NomeCliente     { get; set; }
        public string   CPF             { get; set; }
        public string   RG              { get; set; }
        public string   Email           { get; set; }
        public DateTime DataNascimento  { get; set; }
        public string   CEP             { get; set; }
        public string   Telefone        { get; set; }
        public string   Bairro          { get; set; }
        public string   Cidade          { get; set; }
        public string   Estado          { get; set; }
        public string   Observacao      { get; set; }
    }
}
