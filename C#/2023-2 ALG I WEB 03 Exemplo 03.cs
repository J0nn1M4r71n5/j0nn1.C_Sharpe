using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Peso: ");
    double peso = double.Parse(Console.ReadLine());
    Console.Write("Altura: ");
    double altura = double.Parse(Console.ReadLine());
    double imc = peso / (altura * altura);
    Console.WriteLine("IMC = {0:N3}", imc);
    if (imc < 20) {
      Console.WriteLine("Abaixo do Peso.");
    }
    else if (imc < 25) {
      Console.WriteLine("Peso Ideal.");
    }
    else {
      Console.WriteLine("Acima do peso.");
    }
  }
}