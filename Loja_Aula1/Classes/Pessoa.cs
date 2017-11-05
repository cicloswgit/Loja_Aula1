using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Aula1.Classes
{
    public class Pessoa
    {
        //nome, endereço, estado civil, 
        //gênero idade, data de nascimento, telefone
        public string Nome { get; set; }
        public string Endereco { get; protected set; }

        protected string EstadoCivil;

        protected string Genero;

        protected int Idade;

        protected long Telefone;

        protected DateTime DataNascimento;
    }
}
