using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine());
    double salarioReajustado;
    if (salario < 300) {
      // reajusta em 15%
      // salarioReajustado = (salario * 0.15) + salario;
      salarioReajustado = salario * 1.15;
    }
    else {
      // reajusta em 7.5%
      // salarioReajustado = (salario * 0.075) + salario;
      salarioReajustado = salario * 1.075;
    }
    Console.WriteLine("Salário Reajustado = R$ {0:N2}", salarioReajustado);
  }
}