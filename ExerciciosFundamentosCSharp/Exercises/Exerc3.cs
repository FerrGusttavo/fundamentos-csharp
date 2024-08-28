namespace HelloWorld.Exercises;

public class Exerc3
{
    public static void NumericalExpressions()
    {
        Console.Clear();

        Console.WriteLine("Digite um número:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite outro número:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine($"A soma entre os dois números é {firstNumber + secondNumber}.");

        Console.WriteLine($"A subtração entre os dois números é {firstNumber - secondNumber}.");

        Console.WriteLine($"A multiplicação entre os dois números é {firstNumber * secondNumber}.");

        Console.WriteLine($"A divisão entre os dois números é {firstNumber / secondNumber}.");

        Console.WriteLine($"A média entre os dois números é {(firstNumber + secondNumber) / 2}.");
    }
}