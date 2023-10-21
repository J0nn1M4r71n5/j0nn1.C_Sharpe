using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Número: ");
    int n = int.Parse(Console.ReadLine());
    int r;
    Console.WriteLine("*** TABUADA DO {0} ***", n);
    for (int cont = 1; cont <= 10; cont++) {
      r = n * cont;
      Console.WriteLine("{0} x {1} = {2}", n, cont, r);
    }
  }
}