using OrquestraVirtual.OrquestraVirtual;

namespace OrquestraVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- O POLIMORFISMO EM AÇÃO ---
            // Criamos uma lista que aceita qualquer objeto que implemente a interface IInstrumento.
            // Ela pode conter Violinos, Pianos, Tambores, todos juntos.
            // Isso é Polimorfismo: tratar objetos diferentes de forma unificada.
            var orquestra = new List<IInstrumento>();

            Console.WriteLine("--- Monte sua Orquestra Virtual ---");
            Console.WriteLine("Digite o número do instrumento para adicionar (ou 'sair' para finalizar):");
            Console.WriteLine("1: Violino");
            Console.WriteLine("2: Piano");
            Console.WriteLine("3: Tambor");

            string escolha;
            // Laço 'while' para permitir que o usuário adicione vários instrumentos.
            while (true)
            {
                var input = Console.ReadLine();
                if (input == null)
                    break;
                escolha = input.ToLower();
                if (escolha == "sair")
                    break;
                // Estrutura 'switch' para decidir qual instrumento criar com base na escolha do usuário.
                switch (escolha)
                {
                    case "1":
                        orquestra.Add(new Violino());
                        Console.WriteLine("Violino adicionado!");
                        break;
                    case "2":
                        orquestra.Add(new Piano());
                        Console.WriteLine("Piano adicionado!");
                        break;
                    case "3":
                        orquestra.Add(new Tambor());
                        Console.WriteLine("Tambor adicionado!");
                        break;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine("\nAdicione outro instrumento ou digite 'sair':");
            }
            
            // Verifica se algum instrumento foi adicionado antes de tentar tocar.
            if (orquestra.Count > 0)
            {
                Console.WriteLine("\n--- A Apresentação Vai Começar ---");
                
                // Cria uma string com os nomes dos instrumentos na orquestra.
                // string.Join pega todos os 'Nome' da lista e os junta com ", ".
                var nomesInstrumentos = string.Join(", ", orquestra.Select(i => i.Nome));
                Console.WriteLine($"Instrumentos na orquestra: {nomesInstrumentos}");

                // Laço 'foreach' para percorrer a lista da orquestra.
                foreach (var instrumento in orquestra)
                {
                    // A MÁGICA DO POLIMORFISMO:
                    // Não precisamos saber se o 'instrumento' é um Violino, Piano ou Tambor.
                    // Apenas chamamos o método Tocar(), e o .NET se encarrega de executar
                    // a implementação correta para cada objeto.
                    instrumento.Tocar();
                }
            }
            else
            {
                Console.WriteLine("\nNenhum instrumento foi adicionado à orquestra.");
            }
            
            Console.WriteLine("\n--- Fim da Apresentação ---");
        }
    }
}
