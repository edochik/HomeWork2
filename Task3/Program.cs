double N1 = 34;
double N2 = 5;
int i = 10;
int result = 0;
double a = (N1 / N2);
if (a % 1 == 0) // делим на 1 если остаток не равен нулю, то число не целое(google)
{
    Console.WriteLine("Кратно");
}
else
{
    while (i-2 < N1)
    {
        result = result + 10;
        i = i + 10;
        Console.WriteLine(result);
    }
    double b = N1 - result;
    Console.WriteLine("не кратн, остаток " + b);
}
// с целыми десятками не работает 30 будет выводить остаток 10