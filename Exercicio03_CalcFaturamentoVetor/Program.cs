using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Exercicio03_CalcFaturamentoVetor;

internal class Program
{
    /*
     *  Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa,
     *  na linguagem que desejar, que calcule e retorne:
            • O menor valor de faturamento ocorrido em um dia do mês;
            • O maior valor de faturamento ocorrido em um dia do mês;
            • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
     */
    static void Main(string[] args)
    {
        string fileName = "dados.json";
        string jsonString = File.ReadAllText(fileName);

        List<Faturamento> fat = JsonSerializer.Deserialize<List<Faturamento>>(jsonString);


        float menor = fat.Select(i => i.valor).Min();
        float maior = fat.Select(i => i.valor).Max();

        Console.WriteLine("O menor valor do mês = " + menor + "\n O maior do mês = " + maior);

        float soma = 0;
        int cont = 0;
        int acima = 0;
            for (int j = 0; j < fat.Count; j++)
            {
                if (fat[j].valor > 0)
                {
                 soma += fat[j].valor;
                    cont++;
                }
                
            }
            float media = soma / cont;
            Console.WriteLine("media = " + media);

            for (int j = 0; j < fat.Count; j++)
            {
                if (fat[j].valor > media)
                {
                    acima++;
                    Console.WriteLine("dia " + fat[j].dia + " valor = " + fat[j].valor);
                }

            }
            Console.WriteLine("Quantidade de dias acima da media: " + acima);
            Console.ReadKey();
    }
}

