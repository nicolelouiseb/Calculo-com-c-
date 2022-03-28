double valori,valorf;
double aumento=0.10;
Console.WriteLine("Insira o valor do produto:");
valori=double.Parse(Console.ReadLine());
valorf=valori-(valori*aumento);
Console.WriteLine("O valor final após o aumento é de:{0}",valorf);
