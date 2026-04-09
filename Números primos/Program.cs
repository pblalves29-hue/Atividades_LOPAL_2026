Console.OutputEncoding = System.Text.Encoding.UTF8;
//declarar varivéis
int cont = 0, resultado;
Console.WriteLine("Calculadora de Números Primos");
Console.WriteLine("Digite um número: ");
int.TryParse(Console.ReadLine(), out int primo);
for (int i = 1; i <= primo; i++)
{
    if (primo % i == 0)
    {
        cont++;
    }
    Console.Write($"{primo % i}➡️");
}
Console.Write("");
if (cont == 2)
{
    Console.WriteLine($"\nO número {primo} é primo✅");
}
else
{
    Console.WriteLine($"\nO número {primo} não é primo❌");
}