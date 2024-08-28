using System.Globalization;

namespace HelloWorld.Exercises;

public class Exerc6
{
    public static void DateNow()
    {
        Console.Clear();

        Console.WriteLine("Como você quer que a data seja exibida:");
        Console.WriteLine("1 - Formato completo;");
        Console.WriteLine("2 - Apenas a data no formato dd/mm/yyyy;");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas;");
        Console.WriteLine("4 - A data com o mês por extenso;");
        int option = Convert.ToInt32(Console.ReadLine());

        DateTime dateNow = (DateTime.Now);

        switch (option)
        {
            case 1:
                Console.WriteLine($"{dateNow.DayOfWeek}, {dateNow:dd-MM-yyyy HH:mm:ss}");
                break;
            case 2:
                Console.WriteLine(dateNow.ToString("dd/MM/yyyy"));
                break;
            case 3:
                string formatDateTime = dateNow.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
                Console.WriteLine(formatDateTime);
                break;
            case 4:
                Console.WriteLine(dateNow.ToString("dd/MMMM/yyyy"));
                break;
            default:
                Console.WriteLine("Digite uma opção válida.");
                break;
        }
    }
}
