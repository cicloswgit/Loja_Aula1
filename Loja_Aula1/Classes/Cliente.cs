using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Loja_Aula1.Classes
{
    class Cliente : Pessoa  /*identidade da classe*/
    {
        /*propriedades - variáveis*/
        
        //3 partes para declarar variáveis 
        //<1-visibilidade, 2-tipo, 3-nome da variável>
        //métodos de acesso à variável
        
        
        //classificação, nível social, preferências, frequência de compras
        //limite de crédito, disponibilidade
        private string Classificacao;
        private string NivelSocial;
        private string Preferencias;
        private string FrequenciaCompra;
        private double LimiteCredito;
        private DateTime Disponibilidade;


        /*ações - métodos*/

        //3 partes para declarar variáveis 
        //<1-visibilidade, 2-tipo do retorno, 3-nome do método>

        public Cliente(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        //acessa loja
        public void AcessarLoja()
        {
            Console.WriteLine("O cliente acessou a loja!");
        }

        //lista produtos
        public void ConsultarProduto(string nomeProduto)
        {
            Console.WriteLine("O cliente consultou o produto: "+nomeProduto);
        }
        //realiza comentários
        //adiciona produtos ao carrinho de compras
        //conclui uma compra
        //analisa o subtotal da compra
        //desiste de uma compra
        //faz uma pergunta no chat
        //calcula frete
        //busca informações de classificação dos produtos
    }
}
