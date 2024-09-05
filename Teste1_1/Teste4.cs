using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Teste1_1
{

    public static class Teste4
    {
        public class FaturamentoEstado
        {
            public string estado { get; set; }
            public double faturamento { get; set; }
        }

        public static void Executar()
        {
            // Dados de faturamento diretamente no código como uma string JSON
            string json = @"
        [
          {""estado"": ""SP"", ""faturamento"": 67836.43},
          {""estado"": ""RJ"", ""faturamento"": 36678.66},
          {""estado"": ""MG"", ""faturamento"": 29229.88},
          {""estado"": ""ES"", ""faturamento"": 27165.48},
          {""estado"": ""Outros"", ""faturamento"": 19849.53}
        ]";

            // Desserializar a string JSON em uma lista de objetos FaturamentoEstado
            List<FaturamentoEstado> faturamentos = JsonConvert.DeserializeObject<List<FaturamentoEstado>>(json);

            double totalFaturamento = 0;

            // Calcular o total de faturamento
            foreach (var faturamento in faturamentos)
            {
                totalFaturamento += faturamento.faturamento;
            }

            // Calcular e exibir o percentual de representação de cada estado
            foreach (var faturamento in faturamentos)
            {
                double percentual = (faturamento.faturamento / totalFaturamento) * 100;
                Console.WriteLine($"Estado: {faturamento.estado}");
                Console.WriteLine($"Faturamento: {faturamento.faturamento:C}");
                Console.WriteLine($"Percentual de Representação: {percentual:F2}%");
                Console.WriteLine();
            }

            // Manter o console aberto até que o usuário pressione uma tecla
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey(); // Alternativa ao Console.ReadLine()
        }
    }
}
