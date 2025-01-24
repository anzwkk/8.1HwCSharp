//1. Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random (https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0) Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
int[] array = new int[10];
Random rand = new Random();

for (int i = 1; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}