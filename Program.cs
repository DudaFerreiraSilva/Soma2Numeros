int primeiroNumero, segundoNumero, soma;

Console.WriteLine("Cálculo da soma entre dois números.\n");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite o primeiro número: ");
primeiroNumero = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite o segundo número: ");
segundoNumero = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

soma = primeiroNumero + segundoNumero;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nSoma: {soma}");
Console.ResetColor();
