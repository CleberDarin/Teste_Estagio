using System;

namespace Teste1_1
{
    public static class Teste2
    {
        public static void Executar()
        {
            // Solicitar ao usuário um número
            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
            int numero = int.Parse(Console.ReadLine());

            // Variáveis iniciais da sequência de Fibonacci
            int a = 0, b = 1, proximo = 0;

            // Verificar se o número informado é 0 ou 1, que fazem parte da sequência de Fibonacci
            if (numero == 0 || numero == 1)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                return;
            }

            // Calcular a sequência de Fibonacci até o número informado ou maior
            while (proximo < numero)
            {
                proximo = a + b;
                a = b;
                b = proximo;
            }

            // Verificar se o número informado pertence à sequência de Fibonacci
            if (proximo == numero)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
            }

            // Manter o console aberto até que o usuário pressione uma tecla
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadLine(); // Alternativa ao Console.ReadKey()
        }
    }
}
