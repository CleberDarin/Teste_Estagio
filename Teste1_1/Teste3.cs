using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Teste1_1
{
    public static class Teste3
    {
        public class Faturamento
        {
            public int dia { get; set; }
            public double faturamento { get; set; }
        }

        public static void Executar()
        {
            // Dados de faturamento diretamente no código como uma string JSON
            string json = @"
        [
          {""dia"": 1, ""faturamento"": 2000.00},
          {""dia"": 2, ""faturamento"": 3500.00},
          {""dia"": 3, ""faturamento"": 0.00},
          {""dia"": 4, ""faturamento"": 1000.00},
          {""dia"": 5, ""faturamento"": 0.00},
          {""dia"": 6, ""faturamento"": 1500.00},
          {""dia"": 7, ""faturamento"": 4000.00}
        ]";

            // Desserializar a string JSON em uma lista de objetos Faturamento
            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            double menorFaturamento = double.MaxValue;
            double maiorFaturamento = double.MinValue;
            double somaFaturamento = 0;
            int diasComFaturamento = 0;

            // Calcular menor e maior faturamento, e somar os valores para calcular a média
            foreach (var faturamento in faturamentos)
            {
                if (faturamento.faturamento > 0) // Ignorar dias sem faturamento (faturamento = 0)
                {
                    if (faturamento.faturamento < menorFaturamento)
                    {
                        menorFaturamento = faturamento.faturamento;
                    }

                    if (faturamento.faturamento > maiorFaturamento)
                    {
                        maiorFaturamento = faturamento.faturamento;
                    }

                    somaFaturamento += faturamento.faturamento;
                    diasComFaturamento++;
                }
            }

            // Calcular a média mensal, considerando apenas os dias com faturamento
            double mediaFaturamento = somaFaturamento / diasComFaturamento;

            // Contar quantos dias o faturamento foi superior à média mensal
            int diasAcimaDaMedia = 0;
            foreach (var faturamento in faturamentos)
            {
                if (faturamento.faturamento > mediaFaturamento)
                {
                    diasAcimaDaMedia++;
                }
            }

            // Exibir os resultados
            Console.WriteLine($"Menor faturamento do mês: {menorFaturamento:C}");
            Console.WriteLine($"Maior faturamento do mês: {maiorFaturamento:C}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");

            // Manter o console aberto até que o usuário pressione uma tecla
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
        }
    }
}
