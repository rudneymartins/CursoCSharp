using System;
using System.Globalization;  // para usar na variavel salario 


namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o Seu Nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            
            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); // dessa forma mesmo usando . ou , o sistema ignora e usa a da formatação da maquina

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}