using System;
using System.Globalization;

namespace _01_Aula_Construtores
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto (string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this ( nome, preco)
        {
            _quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get
            {
                return _preco;
            }
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
