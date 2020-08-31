using estoqueOO.Entities;
using System;
using System.Globalization;

namespace estoqueOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemProduto itemProduto = new ItemProduto();

            Console.Write("Informe a Descricao do produto: ");
            string descricao = Console.ReadLine();
            itemProduto.setDescricao(descricao);

            Console.Write("Informe a marca do produto: ");
            string marca = Console.ReadLine();
            itemProduto.setMarca(marca);

            Console.Write("Informe o Tipo do produto: ");
            string tipo = Console.ReadLine();
            itemProduto.setTipo(tipo);

            Console.Write("Informe o Preco de Custo do produto: ");
            double precoCusto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            itemProduto.setPrecoCusto(precoCusto);

            Console.Write("Informe o Preco de Venda do produto: ");
            double precoVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bool regra = itemProduto.setprecoVenda(precoVenda);
            while (regra)
            {
                Console.Write("Informe o Preco de Venda do produto: ");
                precoVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                regra = itemProduto.setprecoVenda(precoVenda);
            }

            Console.Write("O produto já foi vendido? [Sim/Nao] ");
            string foiVendido = Console.ReadLine();
            bool vendido = false;

            if (foiVendido == "Sim" || foiVendido == "SIM" || foiVendido == "sim" || foiVendido == "S" || foiVendido == "s"){ vendido = true; };
            itemProduto.setVendido(vendido);

            itemProduto.setMargemLucro(itemProduto.calcularMargemLucro(precoCusto, precoVenda));

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(itemProduto.ToString());

            Console.ReadLine();
        }
    }
}
