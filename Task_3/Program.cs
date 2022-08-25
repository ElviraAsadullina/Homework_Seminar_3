Console.WriteLine("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");
int index = 1;
while (index <= N)
{
    Console.Write(" | " + Math.Pow(index, 3));
    index++;
}
Console.Write(" | ");