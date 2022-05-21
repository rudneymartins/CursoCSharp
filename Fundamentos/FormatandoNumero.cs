using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // com 1 decimal
            Console.WriteLine(valor.ToString("C")); //Currency - Moeda
            Console.WriteLine((valor / 100).ToString("P")); //Percentual
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //completar com zeros a esquerda até 10 posicoes
        }
    }
}