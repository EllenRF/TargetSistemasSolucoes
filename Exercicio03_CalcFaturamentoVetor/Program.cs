using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Exercicio03_CalcFaturamentoVetor;

internal class Program
{
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
                Console.WriteLine(cont);
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

