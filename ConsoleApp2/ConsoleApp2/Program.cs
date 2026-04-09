using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Você está preso em um prédio com três portas secretas, para sair você precisa adivinhar a porta que volta ao mundo normal.");
Console.WriteLine("---Seja Bem vindo! Qual porta você quer abrir?---");
int.TryParse(Console.ReadLine(), out int opcao);
switch (opcao)
{
    case (1):
        Console.WriteLine("Porta 1: Você entrou em um quarto branco sem nada.😑");
        break;
    case (2):
        Console.WriteLine("Porta 2: Você conseguiu encontrar a saída e voltar para o mundo normal.✅");
        break;
    case (3):
        Console.WriteLine("Porta 3: Você entra em uma sala cheia de animais peçonhentos.😭❌");
        break;
    default:
        Console.WriteLine("Digite uma opção válida (1 a 3)");
        break;
}
