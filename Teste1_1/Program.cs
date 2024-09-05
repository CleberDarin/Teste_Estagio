using System;

class Program
{
    static void Main()
    {
        // Definir uma string ou obter a entrada do usuário
        Console.WriteLine("Digite a string a ser invertida (ou deixe em branco para usar uma mensagem padrão):");
        string input = Console.ReadLine();

        // Verificar se a entrada é vazia e definir uma string padrão ou inverter a string fornecida
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Nenhuma entrada fornecida. Exibindo mensagem padrão.");
            Console.WriteLine("Mensagem padrão: Nenhuma string fornecida.");
        }
        else
        {
            // Inverter a string fornecida
            string reversed = InverterString(input);

            // Exibir o resultado da inversão
            Console.WriteLine($"String original: {input}");
            Console.WriteLine($"String invertida: {reversed}");
        }

        // Esperar a entrada do usuário antes de fechar
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static string InverterString(string str)
    {
        string resultado = "";
        int i = str.Length - 1; // Inicializar o índice no final da string

        // Utilizar while para iterar de trás para frente
        while (i >= 0)
        {
            // Adicionar o caractere atual ao resultado
            resultado += str.Substring(i, 1);
            i--; // Decrementar o índice
        }

        return resultado;
    }
}

