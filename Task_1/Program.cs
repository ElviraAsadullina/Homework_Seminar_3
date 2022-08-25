Console.WriteLine("Введите любое пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99999 ^ num < 10000)
{
    Console.WriteLine("Введенное число - не пятизначное!");
    return;
}
if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
{
    Console.WriteLine("Введенное число - ПАЛИНДРОМ.");
}
else
{
    Console.WriteLine("Введенное число - НЕ палиндром.");
}