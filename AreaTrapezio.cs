
double bma,bme,alt, result;
Console.WriteLine("Insira o valor da base menor:");
bme=double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor da base maior:");
bma=double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor da altura:");
alt=double.Parse(Console.ReadLine());
result=((bma+bme)*alt)/2;
Console.WriteLine("A area do trapézio é:{0}", result);

