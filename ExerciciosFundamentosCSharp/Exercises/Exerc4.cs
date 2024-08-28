namespace HelloWorld.Exercises;

public class Exerc4
{
    public static void CountCaracteres()
    {
        Console.Clear();

        Console.WriteLine("Digite uma palavra para a contagem de caracteres:");
        var word = Console.ReadLine();
        Console.Clear();

        var result = word.Count();

        Console.WriteLine($"A palavra tem {result} caracteres.");
    }
}
