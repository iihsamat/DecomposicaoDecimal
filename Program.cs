// Stefeson

Console.Clear();

int numero, cen, dez, uni;

Console.Write("Coloque algum número: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O número que você digitou contém:");

cen = numero / 100;
dez = (numero % 100) / 10;
uni = (numero % 100) % 10;

Thread.Sleep(2000);
Console.WriteLine($"{uni} Unidade(s)");
Thread.Sleep(1000);
Console.WriteLine($"{dez} Dezenas(s)");
Thread.Sleep(1000);
Console.WriteLine($"{cen} Centenas(s)");