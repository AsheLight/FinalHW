Commands ();
string [] array = new string [] {};

string fromUser = ReadInput ("Введите команду: ");
switch (fromUser)
{
    case "1":
        array = new string [] {"Hello", "2", "world", ":-)"};  
        break;
    case "2":
        array = new string [] {"1234", "1567", "-2", "computer science"};
        break;
    case "3":
        array = new string [] {"Russia", "Denmark", "Kazan",};
        break;
    default:
        Console.WriteLine ($"{fromUser} - Такой команды нет");
        break;

}

