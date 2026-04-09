using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

{
    {
        Console.WriteLine("=== Calculadora de Raiz Quadrada ===");

        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());
        {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} é {raiz}👍");
        }
    }
}
