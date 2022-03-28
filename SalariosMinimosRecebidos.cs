double salM, salF, result;
  Console.WriteLine("Insira o valor do salario mínimo:");
    salM=double.Parse(Console.ReadLine());

  Console.WriteLine("Insira o valor do salario do funcionario:");
    salF=double.Parse(Console.ReadLine());
  result=salF/salM;
  Console.WriteLine("A quantidade de salarios minimos recebidos pelo funcionário é de: {0}", result);

