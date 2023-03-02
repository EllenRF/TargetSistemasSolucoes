using System;

namespace TargetSistemasSolucoes
{
    internal class Program
    {
        /*
         * Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
         * (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...)
         * escreva um programa na linguagem que desejar onde, informado um número, 
         * ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
         */
        public static bool verificaFibonacci(int num)
        {
            int anterior1 = 0;
            int anterior2 = 1;
            int valor = 0;
            if(num == anterior1 || num == anterior2) { return true; }
            while (valor <= num)
            {
                valor = anterior1 + anterior2;
                anterior1 = anterior2;
                anterior2 = valor;
                if(valor == num) { return true; }
            }
            return false;

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine()!);
            Console.WriteLine(verificaFibonacci(num) ? "Pertence a sequência de Fibonacci" : " Não pertence a sequência de Fibonacci");
            Console.ReadKey();
            


        }
    }
}