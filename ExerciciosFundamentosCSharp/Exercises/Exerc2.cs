namespace HelloWorld.Exercises;

public class Exerc2
{
    public static void Fullname()
    {
        Console.Clear();

        Console.WriteLine("Digite seu primeiro nome:");
        var firstName = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Digite seu sobrenome nome:");
        var lastName = Console.ReadLine();
        Console.Clear();

        string fullName = string.Join(" ", firstName, lastName);

        Console.WriteLine($"Olá, {fullName}!");
    }
}
