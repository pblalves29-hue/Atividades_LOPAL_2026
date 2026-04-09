using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculadora de Área ===");
        Console.WriteLine("1 - Quadrado");
        Console.WriteLine("2 - Círculo");

        Console.WriteLine("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Write("Lado: ");
                double lado = double.Parse(Console.ReadLine());
                Console.WriteLine("Área = " + (lado * lado));
                break;

            case 2:
                Console.Write("Raio: ");
                double raio = double.Parse(Console.ReadLine());
                Console.WriteLine("Área = " + (Math.PI * raio * raio));
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}