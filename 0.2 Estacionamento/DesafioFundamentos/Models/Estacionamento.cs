namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Lê placa digitada e armazena em veiculos
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
             Console.WriteLine("Veículo com placa {0} adicionado com sucesso!", placa);
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper(); // Converter para maiúsculas para comparação sem distinção de maiúsculas/minúsculas
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {              
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                 // Calcula o valor total a pagar e remove placa
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);

            // Exibir mensagem de remoção e valor total
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }     
            else
            {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
    }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento e exibe 
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine("- " + placa.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
