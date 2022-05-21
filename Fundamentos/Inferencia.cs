using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo"; // Nesse caso o C# reconhece que o vampo é texto e substitui a var por string, por exemplo
            Console.WriteLine(nome);

            var idade = 32;  // aqui se criou a variavel é já atribui um valor a ela
            Console.WriteLine(idade);

            int a; // aqui criou a variavel
            a = 3; // e aqui iniciou um valor a variavel

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}