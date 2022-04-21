int n = 123;
int i1 = 100;
int i2 = 10;
int result1 = 0;
int result2 = 0;
while (i1 < n)
{
    result1 = result1 + 100;
    i1 = i1 + 100;
}
int b = n - result1;
while (i2 < b)
{
    result2 = result2 + 10;
    i2 = i2 + 10;
}
int c = b - result2;

int d = (n - result1 - c) / 10;
Console.WriteLine(d);