namespace HelloWorld.Exercises;

public class Exerc5
{
    public static void ValidatePlate()
    {
        Console.Clear();

        Console.WriteLine("Digite a placa do veículo:");
        var plate = Console.ReadLine();
        Console.Clear();

        if (plate is not null && plate.Length != 7)
        {
            Console.WriteLine("A placa deve ter 7 caracteres alfanúmericos.");
            return;
        }

        var validatePlate = Validate(plate);

        Console.WriteLine(validatePlate == true ? "Placa é VÁLIDA." : "Placa NÃO É VÁLIDA.");
    }

    private static bool Validate(string plate)
    {
        var arrayPlate = plate.ToArray();

        for (int i = 0; i < 3; i++)
        {
            if (!Char.IsLetter(arrayPlate[i]))
                return false;
        }

        for (int i = 3; i < 7; i++)
        {
            if (!Char.IsDigit(arrayPlate[i]))
                return false;
        }

        return true;
    }
}
