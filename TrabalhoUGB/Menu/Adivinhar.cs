using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabalhoUGB.Menu
{
    public class Adivinhar
    {
        // Função para adivinhar o número
        public static void AdivinharNumero()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101); // Número aleatório entre 1 e 100
            Console.WriteLine("Tente adivinhar o número entre 1 e 100!");

            // Chamada inicial da função recursiva
            TentarAdivinhar(numeroAleatorio);
        }

        // Função recursiva que tenta adivinhar o número
        public static void TentarAdivinhar(int numeroCorreto)
        {
            Console.Write("Digite seu palpite: ");
            int palpite;

            // Verifica se a entrada é um número válido
            if (int.TryParse(Console.ReadLine(), out palpite))
            {
                if (palpite > 0 && palpite < 101)
                {
                    if (palpite < numeroCorreto)
                    {
                        Console.WriteLine("O número correto é maior. Tente novamente.");
                        TentarAdivinhar(numeroCorreto); // Recursão: chama a função novamente
                    }
                    else if (palpite > numeroCorreto)
                    {
                        Console.WriteLine("O número correto é menor. Tente novamente.");
                        TentarAdivinhar(numeroCorreto); // Recursão: chama a função novamente
                    }
                    else
                    {
                        Console.WriteLine("Parabéns! Você adivinhou o número!");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey(); // Pausa para o usuário voltar ao menu
                    }
                }
                else
                {
                    Console.WriteLine("O valor está entre 01 e 100!");
                    TentarAdivinhar(numeroCorreto); // Chama a função novamente se a entrada for inválida
                }

            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                TentarAdivinhar(numeroCorreto); // Chama a função novamente se a entrada for inválida
            }
        }
    }
}


