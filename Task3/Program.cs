int a = 34;
int b = 5;
if (a % b == 0)
{
    Console.WriteLine("кратно");
}
else
{
    int c = a % 10;
    Console.WriteLine("не кратно, остаток " + c);
}