// Este é um programa de console em C# que verifica se uma palavra contém uma sequência
// de três letras consecutivas no alfabeto, como "abc", "xyz" ou "def".
// Ele é organizado em etapas para facilitar a compreensão e manutenção do código.

// Define um namespace para organizar o código.
namespace DecifradorDePalavras
{
    // Classe principal do nosso programa de console.
    class Program
    {
        // O Main é o ponto de entrada, onde a execução do programa começa.
        static void Main(string[] args)
        {
            // --- ETAPA 1: ENTRADA DE DADOS ---

            // Pede ao usuário para inserir uma palavra no console.
            Console.WriteLine("Digite uma palavra:");

            // Lê a palavra que o usuário digitou e a armazena na variável 'palavraOriginal'.
            string? palavraOriginal = Console.ReadLine();

            // --- ETAPA 2: VALIDAÇÃO E PREPARAÇÃO ---

            // Validação: Garante que a palavra não é nula ou vazia e tem pelo menos 3 caracteres.
            // Se não tiver, é impossível encontrar uma sequência de 3 letras.
            if (string.IsNullOrEmpty(palavraOriginal) || palavraOriginal.Length < 3)
            {
                // Informa ao usuário que a palavra é muito curta e encerra o programa.
                Console.WriteLine("Palavra muito curta para análise.");
                return; // Encerra a execução do Main.
            }

            // Converte a palavra inteira para minúsculas.
            // Isso garante que a verificação funcione para qualquer combinação, como "aBc" ou "AbC".
            string palavra = palavraOriginal.ToLower();

            // --- ETAPA 3: LÓGICA DE VERIFICAÇÃO ---

            // Inicia um laço 'for' para percorrer cada caractere da palavra.
            // A condição 'i <= palavra.Length - 3' garante que o laço pare no antepenúltimo
            // caractere, para que sempre tenhamos 3 letras para verificar (a atual, a próxima e a seguinte).
            for (int i = 0; i <= palavra.Length - 3; i++)
            {
                // Pega o caractere na posição atual (i), o próximo (i+1) e o seguinte (i+2).
                char c1 = palavra[i];
                char c2 = palavra[i + 1];
                char c3 = palavra[i + 2];

                // A MÁGICA DA LÓGICA: Verifica se os caracteres são consecutivos no alfabeto.
                // Em C#, caracteres podem ser tratados como números (seus valores na tabela ASCII).
                // 'b' é exatamente igual a 'a' + 1.
                // 'c' é exatamente igual a 'b' + 1.
                // Esta condição checa se a segunda letra é a sucessora da primeira E se a terceira é a sucessora da segunda.
                if (c2 == c1 + 1 && c3 == c2 + 1)
                {
                    // Se a condição for verdadeira, encontramos uma sequência!

                    // Monta a string da sequência encontrada usando os 3 caracteres.
                    string sequenciaEncontrada = $"{c1}{c2}{c3}";

                    // Exibe a mensagem de sucesso formatada, mostrando a sequência.
                    // As aspas duplas dentro da string são "escapadas" com uma barra invertida: \"
                    Console.WriteLine($"Palavra Rara: contém sequência alfabética: \"{sequenciaEncontrada}\"");

                    // Encerra o programa imediatamente, pois já encontramos o que procurávamos.
                    return;
                }
            }

            // --- ETAPA 4: SAÍDA CASO NADA SEJA ENCONTRADO ---

            // Se o laço 'for' terminar completamente sem ter encontrado nenhuma sequência
            // (ou seja, sem nunca ter entrado no 'if' e executado o 'return'),
            // esta linha de código será alcançada.
            Console.WriteLine("Palavra Comum: não contém sequência alfabética.");
        }
    }
}
