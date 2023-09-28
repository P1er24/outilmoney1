// Emmanuel

using System;

double cadAmount, usdAmount, eurAmount;

Console.WriteLine("Please enter you're Name Sir/Miss");
string name = Console.ReadLine();
Console.WriteLine("Welcome " + name);

Console.WriteLine("Welcome the bank of Wopper's,Please enter you're money value in (CAD):");

if (double.TryParse(Console.ReadLine(), out cadAmount))
{
    usdAmount = cadAmount * 0.79; // Taux de change CAD vers USD
    eurAmount = cadAmount * 0.68; // Taux de change CAD vers EUR

    Console.WriteLine($"Montant en dollars américains (USD) : {usdAmount:C}");
    Console.WriteLine($"Montant en euros (EUR) : {eurAmount:C}");
}
else
{
    Console.WriteLine("Money Unavalable, Plese make sure to enter the right amount");
}

Console.ReadKey();
