using HelloWorld.Exercises;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o exercício digitando o respectivo número associado:");
        Console.WriteLine("1 - Mensagem de bem-vindo;");
        Console.WriteLine("2 - Nome completo;");
        Console.WriteLine("3 - Expressões númericas;");
        Console.WriteLine("4 - Contagem de caracteres;");
        Console.WriteLine("5 - Validar placa de veículo;");
        Console.WriteLine("6 - Data e hora;");

        int idExercise = Convert.ToInt32(Console.ReadLine());

        switch (idExercise)
        {
            case 1:
                Exerc1.Welcome();
                break;

            case 2:
                Exerc2.Fullname();
                break;
            case 3:
                Exerc3.NumericalExpressions();
                break;
            case 4:
                Exerc4.CountCaracteres();
                break;
            case 5:
                Exerc5.ValidatePlate();
                break;
            case 6:
                Exerc6.DateNow();
                break;
            default:
                Console.WriteLine("Digite uma opção válida.");
                break;
        }
    }
}