using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite a velocidade: ");
    int velocidade = int.Parse(Console.ReadLine());
    if (velocidade > 70) {
      Console.WriteLine("Multado!");
    }
    Console.WriteLine("Fim do programa.");
  }
}