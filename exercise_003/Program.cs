Console.WriteLine("Введите номер дня недели");
string numberOfWeek = Console.ReadLine();

switch(numberOfWeek)
{
    case "1":
        Console.WriteLine("Нет");
    break;
    case "2":
        Console.WriteLine("Нет");
    break;
    case "3":
        Console.WriteLine("Нет");
    break;
    case "4":
        Console.WriteLine("Нет");
    break;
    case "5":
        Console.WriteLine("Нет");
    break;
    case "6":
        Console.WriteLine("Да, это суббота!!!");
    break;
    case "7":
        Console.WriteLine("Да, это воскресенье!!!");
    break;
    default:
        Console.WriteLine("Такого дня недели нет");
    break;
}

