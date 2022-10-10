﻿using System.Globalization;

namespace Course {
    class Produto {
        private string _nome;
        public double Preco { get; private set;}
        public int Quantidade { get; private set;}
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    this._nome = value;
            }
        }

        //public Produto(string nome, double preco, int quantidade) {

        //    Nome = nome;
        //    this.preco = preco;
        //    this.quantidade = quantidade;

        //}


        //public Produto(string nome, double preco) {
        //    Nome = nome;
        //    this.preco = preco;
        //    quantidade = 5;
        //}


        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            this.Quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
