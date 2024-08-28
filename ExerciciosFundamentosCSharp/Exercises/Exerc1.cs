namespace HelloWorld.Exercises;

public class Exerc1
{
   public static void Welcome()
    {
        Console.Clear();

        Console.WriteLine("Digite seu nome:");
        var name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }
}
