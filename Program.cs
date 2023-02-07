// See https://aka.ms/new-console-template for more information


Console.WriteLine("Digite seu nome completo: ");
string name = Console.ReadLine();

Console.WriteLine("Quantos quartos tem sua casa?");
int rooms = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço de um produto: ");
double price = double.Parse(Console.ReadLine());

Console.WriteLine("Digite seu nome, idade e altura na mesma linha: ");
string[] vet = Console.ReadLine().Split(' ');
string p1 = vet[0];
int p2 = int.Parse(vet[1]);
double p3 = double.Parse(vet[2]);

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);