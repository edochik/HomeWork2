int a = 35767;
if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
if (a < 1000)
{
    int b = a % 10;
    Console.WriteLine(b);
}
if (a < 10000)
{
    int c = a % 100;
    int d = c % 10;
    int e = (c - d) / 10;
    Console.WriteLine(e);
}
if (a < 100000)
{
    int c = a % 1000;
    int b = c % 100;
    int e = b % 10;
    int f = (c-(b - e)) / 100;
    Console.WriteLine(f);
}