// See https://aka.ms/new-console-template for more information
string nome1, nome2;

Console.WriteLine("Digite o nome 1");
nome1 = Console.ReadLine()!; 
Console.WriteLine("Digite o nome 2");
nome2 = Console.ReadLine()!;
Console.WriteLine("_\n_");
Console.WriteLine($"Nome 1 = {nome1}");
Console.WriteLine($"Nome 2 = {nome2}");
Console.WriteLine("_\n_");
Console.WriteLine("Após trocar os valores temos:");
Console.WriteLine("_\n_");
Console.WriteLine($"Nome 1 = {nome2}");
Console.WriteLine($"Nome 2 = {nome1}");
