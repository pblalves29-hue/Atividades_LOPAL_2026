using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.UTF8;
float moeda, conversorReal, resultado;
int escolha;
Console.WriteLine("Conversor de Moedas💵");
Console.Write("Digite o Valor em Reais que Você Quer Converter: ");
float.TryParse(Console.ReadLine()!, out moeda);
Console.WriteLine("\nDigite 1 para converter para Dólar\n" +
"Digite 2 para converter para libras\nDigite: ");
int.TryParse(Console.ReadLine(), out escolha);
switch (escolha) {
    case 1:
        Console.Write("Digite o valor do dólar turismo: ");
        float.TryParse(Console.ReadLine()!.Replace(".", "."), out conversorReal);
        resultado = moeda / conversorReal;
        Console.WriteLine($"R${moeda} / U${conversorReal} = U${resultado}");
        break;
    default:
        Console.WriteLine("Digite um valor válido");
        break;
}
switch (escolha) { 
 case 2:
        Console.Write("Digite o valor das libras turismo: ");
        float.TryParse(Console.ReadLine()!.Replace(".", "."), out conversorReal);
        resultado = moeda / conversorReal;
        Console.WriteLine($"R${moeda} / £{conversorReal} = £{resultado}");
        break;
    default:
        Console.WriteLine("Digite um valor válido");
        break;
    }
    