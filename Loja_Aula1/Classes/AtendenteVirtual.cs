using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Aula1.Classes
{
    class AtendenteVirtual /*identidade da classe*/
    {
        /*propriedades - variáveis*/
        //3 partes para declarar variáveis 
        //<1-visibilidade, 2-tipo, 3-nome da variável>

        //nome, respostas
        public string Nome = "";
        public string Resposta1 = "", Resposta2, Resposta3;

        /*ações - métodos*/
        //3 partes para declarar métodos 
        //<1-visibilidade, 2-tipo de retorno, 3-nome do método>

        /*EXCEÇÃO - método construtor*/
        public AtendenteVirtual()
        {

        }

        public AtendenteVirtual(string nome, string resposta1)
        {
            Nome = nome;
            Resposta1 = resposta1;
        }

        //responderPerguntas
        public void ResponderPergunta(string perguntaEscolhida)
        {
            Console.WriteLine("O Atendente respondeu à: "+perguntaEscolhida);
            Console.WriteLine("A resposta é: " + Resposta1);
        }
    }
}
