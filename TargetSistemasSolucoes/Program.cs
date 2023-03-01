using System;

namespace TargetSistemasSolucoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
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
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(verificaFibonacci(num) ? "Pertence a sequência de Fibonacci" : " Não pertence a sequência de Fibonacci");
            Console.ReadKey();
            


        }
    }
}