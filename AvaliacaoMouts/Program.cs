namespace AvaliacaoMouts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produtosDisponiveis = new List<Produto>
            {
                new Produto(1,"Arroz", 10.50d),
                new Produto(2, "Feijão", 8.00d),
                new Produto(3, "Café", 20.00d),
                new Produto(4, "Macarrão", 18.50d),
                new Produto(5, "Pão", 9.50d)
            };

            var clientes = new List<Cliente>
            {
                new Cliente(1, "Emanuela", "Rua tal 1", "00011122233"),
                new Cliente(2, "João", "Rua tal 2", "99988877755"),
                new Cliente(3, "Lucas", "Rua tal 3", "00011122233789"),
            };

            Console.WriteLine("Bem-vindo(a)!");
            List<Produto> produtosComprados = new List<Produto>();

            Console.WriteLine("Selecione os produtos comprados:");
            for (int i = 0; i < produtosDisponiveis.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {produtosDisponiveis[i].Nome} - R$ {produtosDisponiveis[i].Preco}");
            }

            int opcao;
            do
            {
                Console.WriteLine("Digite o número do produto para adicionar ao carrinho (0 para finalizar):");
                opcao = int.Parse(Console.ReadLine());
                if (opcao > 0 && opcao <= produtosDisponiveis.Count)
                {
                    produtosComprados.Add(produtosDisponiveis[opcao - 1]);
                    Console.WriteLine($"{produtosDisponiveis[opcao - 1].Nome} adicionado ao carrinho.");
                }
            } while (opcao != 0);

            Console.WriteLine("Informe a forma de pagamento (Dinheiro, Cartão, Pix):");
            string formaPagamento = Console.ReadLine();

            Console.WriteLine("Informe o nome do cliente (deixe em branco se não quiser informar):");
            string nomeCliente = Console.ReadLine();
            Cliente cliente = null;

            Venda venda = new Venda(produtosComprados, formaPagamento, cliente);
            venda.GerarCupomFiscal();
        }
    }
}
