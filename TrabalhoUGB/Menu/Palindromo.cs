using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoUGB.Menu
{
       public static class Palindromo 
        {
            // Função para verificar se o número é palíndromo
            public static void VerificarPalindromo()
            {
                Console.Write("Digite um número: ");
                string numero = Console.ReadLine();

                if (EhPalindromo(numero))
                {
                    Console.WriteLine($"O número {numero} é um palíndromo.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} não é um palíndromo.");
                }

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

            // Função para verificar se a string de um número é palíndromo
            public static bool EhPalindromo(string numero)
            {
                int inicio = 0;
                int fim = numero.Length - 1;

                while (inicio < fim)
                {
                    if (numero[inicio] != numero[fim])
                    {
                        return false;
                    }
                    inicio++;
                    fim--;
                }

                return true;
            }
        }
    }

