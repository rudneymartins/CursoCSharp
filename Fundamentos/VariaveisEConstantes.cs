using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //are da circunferencia
            double raio = 4.5; //aqui iniciamos a variavel co um valor
            const double PI = 3.14;

            raio = 5.5; // e aqui mudamos o valor da variavel

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);
            Console.WriteLine("Área é " + (1000 + area));

            //Tipos internos

            bool estaChovento = true;
            Console.WriteLine("Está Chovendo? " + estaChovento);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario é " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros!
            Console.WriteLine("Menor Valor é " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("populacao mundial " + populacaoMundial);

            float precoCOmputador = 1299.99f; //o "f" vai no final para dizer que é float
            Console.WriteLine("Preco Computador " + precoCOmputador);

            double valorDeMercadoApple = 1_000_000_000_000.00; //Mais usado dos reais!
            Console.WriteLine("Valor da Apple " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Entrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            String texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);

        }
    }
}