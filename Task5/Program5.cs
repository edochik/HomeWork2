int a = 25;
int b = 5;
if (a > b)
{
    if (a % b == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
if (a < b)
{
    if (b % a == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}