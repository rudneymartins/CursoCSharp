using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            //Preço com Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}",totalComDesconto);

            //IMC
            Console.Write("Digite seu peso: ");
            string peso = Console.ReadLine();
            double peso2 = double.Parse(peso);

            Console.Write("Digite sua altura: ");
            string altura = Console.ReadLine();
            double altura2 = double.Parse(altura);

            double imc = peso2 / Math.Pow(altura2,2);//elevado ao quadrado
            Console.WriteLine($"Seu IMC é {imc}.");

            //Numero Par / Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par,par % 2); // % é o operador para o resto da divisao
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
