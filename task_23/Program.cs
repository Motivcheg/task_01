Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i;
for (i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {i*i*i}");
    Console.WriteLine("_______________");
    continue;
}