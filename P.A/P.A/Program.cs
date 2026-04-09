Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Calculadora de P.A(Progressão Aritmética)");
int razão, termos, resultado = 0;
Console.Write("Digite o número de termos da sua P.A: ");
int.TryParse(Console.ReadLine(), out termos);
Console.WriteLine("Digite o número da razão (Salto): ");
int.TryParse(Console.ReadLine(), out razão);
for (int i = 1; i <= termos; i++ )
{
    resultado = resultado + razão;
    Console.Write($"{i}➡️");
}


