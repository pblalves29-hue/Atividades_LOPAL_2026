class Program
{
    static void Main()
{
    Console.WriteLine("=== Calculadora de Juros Simples ===");

    Console.Write("Digite o capital (R$): ");
    double capital = double.Parse(s: Console.ReadLine());

    Console.Write("Digite a taxa de juros (%): ");
    double taxa = double.Parse(s: Console.ReadLine());

    Console.Write("Digite o tempo (meses/anos): ");
    double tempo = double.Parse(s: Console.ReadLine());

    // Converter taxa para decimal
    taxa = taxa / 100;

    // Cálculo
    double juros = capital * taxa * tempo;
    double montante = capital + juros;

    // Saída
    Console.WriteLine($"\nJuros: R$ {juros}");
    Console.WriteLine($"Montante final: R$ {montante}");
}
}
