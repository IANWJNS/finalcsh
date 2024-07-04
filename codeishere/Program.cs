void Commands()
{
    Console.WriteLine();
    Console.WriteLine("1: [“Rice”, “Chicken”, “Noodles”, “Pizza”]");
    Console.WriteLine("2: [“Поспать”, “Полежать”, “Посидеть”, “Попердеть”]");
    Console.WriteLine("3: [“Тут”, “Три”, “Слова”]");
    Console.WriteLine();
}

string? ReadInput(string msg) 
{
    Console.Write(msg);
    return Console.ReadLine();
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}

Commands();
string[] array = new string[] {};
string? fromUser = ReadInput("Введите команду: ");
switch (fromUser)
{
    case "1":
        array = new string[] { "Rice", "Chicken", "Noodles", "Pizza" };
        break;
    case "2":
        array = new string[] { "Поспать", "Полежать", "Посидеть", "Попердеть" };
        break;
    case "3":
        array = new string[] { "Тут", "Три", "Слова" };
        break;
    default:
        Console.WriteLine($"{fromUser} - От 1 до 3, дружище.");
        break;
}
int lenNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lenNewArray++;
}

string[] newArray = new string[lenNewArray];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);
