using System;

namespace Teste1_1
{
    public static class Teste1
    {
        public static void Executar()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine("O valor final de SOMA é: " + SOMA);

            // Esperar a entrada do usuário antes de fechar
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
        }
    }
}
