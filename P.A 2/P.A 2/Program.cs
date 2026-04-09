Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Calculadora de P.A(Progressão Aritmética)");
int razão, termos, primeiroTermo, resultado = 0;
Console.Write("Digite o número de termos da sua P.A: ");
int.TryParse(Console.ReadLine(), out termos);
Console.WriteLine("Digite o número da razão (Salto): ");
int.TryParse(Console.ReadLine(), out razão);
Console.WriteLine("Digite o primeiro termo da P.A: ");
int.TryParse(Console.ReadLine(), out primeiroTermo);
for (int i = 0; i < termos; i++)
{
    resultado = resultado + razão;
    Console.Write($"{resultado}➡️");
}