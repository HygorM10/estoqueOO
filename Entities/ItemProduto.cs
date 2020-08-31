using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace estoqueOO.Entities
{
    class ItemProduto : Produto
    {
        private double PrecoCusto;
        private double PrecoVenda;
        private double MargemLucro;
        private bool Vendido;

        public ItemProduto()
        {
        }

        public ItemProduto(string Descricao, string Marca, string Tipo, double PrecoCusto, double PrecoVenda, bool Vendido)
        {
            this.Descricao = Descricao;
            this.Marca = Marca;
            this.Tipo = Tipo;
            this.PrecoCusto = PrecoCusto;
            this.PrecoVenda = PrecoVenda;
            this.MargemLucro = calcularMargemLucro(this.PrecoCusto, this.PrecoVenda);
            this.Vendido = Vendido;
        }

        public ItemProduto(double PrecoCusto, double PrecoVenda, bool Vendido)
        {
            this.PrecoCusto = PrecoCusto;
            this.PrecoVenda = PrecoVenda;
            this.MargemLucro = calcularMargemLucro(this.PrecoCusto, this.PrecoVenda);
            this.Vendido = Vendido;
        }

        public string getDescricao()
        {
            return this.Descricao;
        }

        public void setDescricao(string Descricao)
        {
            this.Descricao = Descricao;
        }

        public string getMarca()
        {
            return this.Marca;
        }

        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }

        public string getTipo()
        {
            return this.Tipo;
        }

        public void setTipo(string Tipo)
        {
            this.Tipo = Tipo;
        }

        public string getPrecoCusto()
        {
            return this.Tipo;
        }

        public void setPrecoCusto(double PrecoCusto)
        {
            this.PrecoCusto = PrecoCusto;
        }

        public double getprecoVenda()
        {
            return this.PrecoVenda;
        }

        public bool setprecoVenda(double PrecoVenda)
        {
            if (PrecoVenda < PrecoCusto)
            {
                Console.WriteLine("O preco de venda " + PrecoVenda.ToString("F2", CultureInfo.InvariantCulture) +
                    " é inferior ao preco de custo " + PrecoCusto.ToString("F2", CultureInfo.InvariantCulture));

                return true;
            }

            this.PrecoVenda = PrecoVenda;
            return false;
        }

        public double getMargemLucro()
        {
            return this.MargemLucro;
        }

        public void setMargemLucro(double MargemLucro)
        {
            this.MargemLucro = MargemLucro;
        }

        public bool getVendido()
        {
            return this.Vendido;
        }

        public void setVendido(bool Vendido)
        {
            this.Vendido = Vendido;
        }

        public double calcularMargemLucro(double precoCusto, double precoVenda)
        {
            return precoVenda - precoCusto;
        }

        public double margemLucroPorcentagem()
        {
            return (MargemLucro / PrecoVenda) * 100;
        }

        public override string ToString()
        {
            return "Preco de Custo: " + PrecoCusto.ToString("F2", CultureInfo.InvariantCulture) + "\n" + 
                "Preco de Venda: " + PrecoVenda.ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "Margem de Lucro: " + MargemLucro.ToString("F2", CultureInfo.InvariantCulture) + "\n" + 
                "Margem de Lucro Percentual (%): " + margemLucroPorcentagem().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
