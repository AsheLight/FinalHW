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

int lenNewArray = 0;
for (int i =0; i <= array.length -1; i++)
{
    if (array[i].length <=3) lenNewArray++;
}

string [] newArray = new string [lenNewArray];
int idx=0;

for (int i = 0; i <= array.length - 1; i++)
{
    if (array[i].length <=3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}

PrintArray(array);
Console.WriteLine("→");
PrintArray(newArray);

void Commands();
{

    Console.WriteLine();
    Console.WriteLine("Список команд: ");
    Console.WriteLine("1 - использовать массив : [“Hello”, “2”, “world”, “:-)”] ");
    Console.WriteLine("2 - использовать массив :[“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 - использовать массив : [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}

string ReadInput (string msg)
{
    Console.Write (msg);
    return Console.ReadLine();
}

void PrintArray (string [] array)
{
    Console.Write("[ ");
    for (int = 0; i < array.length; i++;)
    {
        Console.Write($"" {array[i]}" , ")
    }
    Console.Write("] ");
}
