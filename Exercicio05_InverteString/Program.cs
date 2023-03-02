using System;

namespace Exercicio05_InverteString 
{
    internal class Program
    {
        /*
         * Escreva um programa que inverta os caracteres de um string.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string: ");
            string st = Console.ReadLine();
            
            for(int i = st.Length - 1; i >= 0; i--)
            {
                Console.Write(st[i].ToString());
            }
            Console.ReadKey();


        }
    }
}