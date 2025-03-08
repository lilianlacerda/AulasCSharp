using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProduto
{
    internal class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        //Geralmente o contrutor tem o mesmo nome da classe 
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double getTotalAmaunt()
        {
            return Preco * Quantidade;
        }

        public string getDetailProdut()
        {
            return $"Nome: {Nome}, Preço: {Preco}, quantidade: {Quantidade}";
        }

    }
}
