Console.Clear();
int n = InputInt("Введите количество чисел: ");
int count = 0;
for (int i = 0; i < n; i++)
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine(count);


int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}