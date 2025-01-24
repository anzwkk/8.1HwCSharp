//1. Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random (https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0) Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
//int[] array = new int[10];
//Random rand = new Random();

//for (int i = 1; i < array.Length; i++)
//{
//    array[i] = rand.Next(-10, 11);
//}

//Console.WriteLine("Елементи масиву з парними індексами: ");
//for (int i = 0; i < array.Length; i += 2)
//{
//    Console.WriteLine($"Індекс {i}: {array[i]}");
//}

//2. Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
int[] array = new int[10];
Random rand = new Random();

for (int i = 1; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}

Console.WriteLine("Елементи масиву з парними індексами: ");
for (int i = 0; i < array.Length; i += 2)
{
    Console.WriteLine($"Індекс {i}: {array[i]}");
}

int sum = 0;
foreach (int number in array)
{
    sum += number;
}

if (sum >= 0)
{
    Console.WriteLine("Сума елементів масиву є невід'ємною");
}
else
{
    Console.WriteLine("Сума елементів масиву є від'ємною");
}