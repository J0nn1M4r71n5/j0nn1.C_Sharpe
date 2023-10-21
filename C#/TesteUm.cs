using System;

class Program
{
    static void Main()
    {
        double num1, num2, resultado;
        char operacao;

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /): ");
        operacao = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case '-':
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case '*':
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: divisão por zero.");
                }
                break;

            default:
                Console.WriteLine("Operação inválida. Por favor, digite uma operação válida (+, -, *, /).");
                break;
        }
    }
}