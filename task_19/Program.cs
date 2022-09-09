Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int t = num;
int rev;
int total = 0;
while (num > 0)
{
    rev = num % 10;
    total = (total * 10) + rev;
    num = num / 10;
}
if (t == total) Console.Write("Палиндром.");
else Console.Write("Не палиндром");