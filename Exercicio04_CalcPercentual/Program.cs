﻿using System;

namespace Exercicio04_CalcPercentual// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estados> estados = new List<Estados>
            {

                new Estados() {nome = "SP", valor = 67836.43},
                new Estados() {nome = "RJ", valor = 36678.66},
                new Estados() {nome = "MG", valor = 29229.88},
                new Estados() {nome = "ES", valor = 27165.48},
                new Estados() {nome = "OUTROS", valor = 19849.53}
            };

            double soma = 0;
            foreach(var estado in estados)
            {
                soma += estado.valor;

            }

            for (int i = 0; i < estados.Count; i++)
            {
                Console.WriteLine(estados[i].nome + " - " + Math.Round((estados[i].valor / soma) * 100, 2) + "%");
            }
            Console.ReadKey();

        }
    }
}