using System;
using System.Collections.Generic;
using System.Text;

namespace estoqueOO.Entities
{
    class Produto
    {
        protected string Descricao { get; set; }
        protected string Marca { get; set; }
        protected string Tipo { get; set; }

        public Produto() {}
        public Produto(string Descricao, string Marca, string Tipo)
        {
            this.Descricao = Descricao;
            this.Marca = Marca;
            this.Tipo = Tipo;
        }

    }
}
