using System;
using TrabalhoUGB.Menu; // Certifique-se de que os namespaces estão corretos

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear(); // Limpa o console a cada exibição do menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Verificar se o número é palíndromo");
            Console.WriteLine("2. Adivinhar o número (usando recursão)");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Palindromo.VerificarPalindromo(); // Chama o método estático diretamente pela classe
                    break;

                case "2":
                    Adivinhar.AdivinharNumero(); // Chama o método estático diretamente pela classe
                    break;

                case "3":
                    running = false;
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey(); // Pausa para o usuário ler a mensagem de erro
                    break;
            }
        }
    }
}
