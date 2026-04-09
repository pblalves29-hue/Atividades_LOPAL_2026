using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Conversor de Temperaturas ===");
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.WriteLine("3 - Kelvin para Celsius");
        Console.WriteLine("4 - Kelvin para Fahrenheit");

        Console.Write("\nEscolha uma opção: ");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            Console.Write("Digite a temperatura: ");

            if (float.TryParse(Console.ReadLine(), out float temp))
            {
                switch (opcao)
                {
                    case 1:
                        float f = (temp * 9 / 5) + 32;
                        Console.WriteLine($"\nResultado: {f:F2} °F");
                        break;

                    case 2:
                        float c = (temp - 32) * 5 / 9;
                        Console.WriteLine($"\nResultado: {c:F2} °C");
                        break;

                    case 3:
                        float c2 = temp - 273.15f;
                        Console.WriteLine($"\nResultado: {c2:F2} °C");
                        break;

                    case 4:
                        float f2 = (temp - 273.15f) * 9 / 5 + 32;
                        Console.WriteLine($"\nResultado: {f2:F2} °F");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Erro: Digite apenas números para a temperatura.");
            }
        }
        else
        {
            Console.WriteLine("Erro: Digite um número válido para a opção.");
        }
    }
}
