using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Aula1.Classes
{
    public class AssistenteTecnico : Pessoa
    {

        /*variáveis*/

        //nível técnico, nível acesso ao sistema
        public int NivelTecnico;
        public string NivelAcessoSistema;

        /*ações*/

        public AssistenteTecnico(string nome)
        {
            Nome = nome;
        }

        //responder perguntas técnicas
        public void ResponderPerguntasTecnicas(string pergunta)
        {
            Console.WriteLine("O assistente" + Nome + "respondeu à pergunta técnica: "+ pergunta);
        }

        //resolver problemas do sistema
        public void ResolverProblemas()
        {
            Console.WriteLine("O assistente resolveu os problemas encontrados!");
        }
    }
}
