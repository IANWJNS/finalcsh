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
class Programm
{ 
static void Main() 
{ 
string[] inputArray = new string[] { "Hello", "2", "world", ":-)" }; 
string[] resultArray = FilterArray(inputArray); 

foreach (var item in resultArray) 
{ 
Console.Write(item + " "); 
} 
} 

static string[] FilterArray(string[] input) 
{ 
int count = 0; 
for (int i = 0; i < input.Length; i++) 
{ 
if (input[i].Length <= 3)  
{ 
count++; 
} 
} 

string[] result = new string[count]; 

count = 0;  
for (int i = 0; i < input.Length; i++) 
{ 
if (input[i].Length <= 3) 
{ 
result[count] = input[i]; 
count++; 
} 
} 

return result; 
} 
} 
