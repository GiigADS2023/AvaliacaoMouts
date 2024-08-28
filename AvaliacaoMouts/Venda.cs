using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoMouts
{
    internal class Venda
    {
        public List<Produto> Produtos { get; set; }
        public string FormaPagamento { get; set; }
        public Cliente Cliente { get; set; }
        public double Total { get; private set; }

        public Venda(List<Produto> produtos, string formaPagamento, Cliente cliente = null)
        {
            Produtos = produtos;
            FormaPagamento = formaPagamento;
            Cliente = cliente;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            foreach (var produto in Produtos)
            {
                Total += produto.Preco;
            }
        }

        public void GerarCupomFiscal()
        {
            Console.WriteLine("\n--- Cupom Fiscal ---");
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"{produto.Nome}: R$ {produto.Preco}");
            }
            Console.WriteLine($"Total: R$ {Total}");
            Console.WriteLine($"Forma de Pagamento: {FormaPagamento}");

            if (Cliente != null)
            {
                Console.WriteLine($"Cliente: {Cliente.Nome}");
                Cliente.AddPontosFidelidade((int)Total); // 1 ponto por cada real gasto
            }
            else
            {
                Console.WriteLine("Venda realizada sem identificação de cliente.");
            }
            Console.WriteLine("--------------------\n");
        }

        public string FormadePgto()
        {
            string formaPagamento = "Não especificado"; 
            bool validInput = false; 

            while (!validInput) 
            {
                Console.WriteLine("Informe a forma de pagamento (1 - Dinheiro, 2 - Cartão, 3 - Pix):");

                try
                {
                    if (int.TryParse(Console.ReadLine(), out int opcaoPagamento))
                    {
                        switch (opcaoPagamento)
                        {
                            case 1:
                                formaPagamento = "Dinheiro";
                                validInput = true; 
                                break;
                            case 2:
                                formaPagamento = "Cartão";
                                validInput = true; 
                                break;
                            case 3:
                                formaPagamento = "Pix";
                                validInput = true; 
                                break;
                            default:
                                throw new ArgumentException("Opção inválida. Tente novamente.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Entrada inválida. Tente novamente.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message); 
                }
            }

            return formaPagamento;
        }


    }
}
