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

//int sum = 0;
//foreach (int number in array)
//{
//    sum += number;
//}

//if (sum >= 0)
//{
//    Console.WriteLine("Сума елементів масиву є невід'ємною");
//}
//else
//{
//    Console.WriteLine("Сума елементів масиву є від'ємною");
//}

// Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.
//int[,] multipTable = new int[9, 9];

//for (int i = 0; i < 9; i++) 
//{
//    for (int j = 0; j < 9; j++) 
//    {
//        multipTable[i, j] = (i + 1) * (j + 1);
//        Console.Write(multipTable[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//4. Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран: а) максимальний елемент масиву; б) мінімальний елемент масиву; в) координати мінімального елемента масиву. г) координати максимального елемента масиву.
int[,] array = new int[5, 5];
Random rand =  new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] = rand.Next(-50, 50);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
int max = array[0, 0];
int min = array[0, 0];
int maxRow = array[0, 0];
int minRow = array[0, 0];
int maxCol = array[0, 0];
int minCol = array[0, 0];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array[i, j] > max)
        {
            max = array[i, j];
            maxRow = i;
            maxCol = j;
        }
        if (array[i, j] < min)
        {
            min = array[i, j];
            minRow = i;
            minCol = j;
        }
    }
}
Console.WriteLine($"Максимальний елемент: {max} на позиції ({maxRow}, {maxCol})");
Console.WriteLine($"Мінімальний елемент: {min} на позиції ({minRow}, {minCol})");
