
float n1,p1,n2,p2, result;
Console.WriteLine("Insira a nota1:");
n1=float.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota2:");
n2=float.Parse(Console.ReadLine());
p1=2;
p2=3;
result=(p1*n1+p2*n2)/(p1+p2);
Console.WriteLine("A media ponderada das notas é: {0}", result);