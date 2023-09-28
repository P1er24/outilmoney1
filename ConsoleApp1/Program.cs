// Emmanuel


double cadAmount, usdamount, euramount;

Console.WriteLine("hello, customer" + "Please enter you're money value (CAD):");
if (double.TryParse(Console.ReadLine(), out cadAmount))
{
    usdamount = cadAmount * 0.79; //tAUX DE change CAD vers USD
    euramount = cadAmount * 0.68; //taux de change CAD vers EUR

    object usdAmount = null;
    Console.WriteLine($"Montant en dollars américains (USD) : {usdAmount:C}");
    object eurAmount = null;
    Console.WriteLine($"Montant en euros (EUR) : {eurAmount:C}");
}
else
{
    Console.WriteLine("Montant invalide. Assurez-vous d'entrer un nombre valide.");
}

Console.ReadKey();
//declare before closing