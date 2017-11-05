using System;
using Loja_Aula1.Classes;

namespace Loja_Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaração de Objetos
            //Cliente1

            //criar objeto
            Cliente Cliente1 = new Cliente("Lorena", "Rua do Paraíso, 58");
            Console.WriteLine("O cliente: " + Cliente1.Nome + " mora no endereço " + Cliente1.Endereco);

            //modificar atributo
            Cliente1.Nome = "Márcio";
            
            //acessar atributo
            Console.WriteLine("O cliente: "+Cliente1.Nome+ " mora no endereço "+Cliente1.Endereco);
            
            //chamadas a métodos
            Cliente1.AcessarLoja();
            Cliente1.ConsultarProduto("Livro");

            //Atendente Virtual

            AtendenteVirtual Atendente2 = new AtendenteVirtual("Robô Vitor", "Olá, bom dia! O seu produto está disponível no estoque da loja!");
            Console.WriteLine("Olá, eu sou o Atendente: " + Atendente2.Nome);
            Console.WriteLine("A resposta à sua pergunta é: " + Atendente2.Resposta1);

            Atendente2.ResponderPergunta("O seu produto não está disponível no estoque da loja!");

            #endregion

            #region Conceitos de Herança

            //Assistente Técnico
            AssistenteTecnico Assistente = new AssistenteTecnico("Vanessa");
            Assistente.ResolverProblemas();

            //polimorfismo
            if (1 == 1)
            {
                Pessoa Cliente2 = new Cliente("", "");
            }
            else
            {
                Pessoa Assistente2 = new AssistenteTecnico("");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
