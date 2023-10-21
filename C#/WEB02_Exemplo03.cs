using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite o primeiro número: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    int n2 = int.Parse(Console.ReadLine());
    int soma = n1 + n2;
    Console.WriteLine("Soma = {0}", soma);
  }
}