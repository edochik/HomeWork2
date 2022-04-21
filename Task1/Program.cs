int n = new Random().Next(10, 100);
int i = 10;
int result = 0;
while (i-1 < n)
{
    i = i + 10;
    result = result + 10;
}
int a = n - result;
int b = result / 10;
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
