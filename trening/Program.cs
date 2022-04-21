//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4


/*double length(double x1, double y1, double x2, double y2)
{
    // x1 = 1, y1 = 1
    // x2 = 3, y2 = 5
    double deltaX = Math.Abs(x1 - x2);
    double deltaY = Math.Abs(y1 - y2);
    double deltaXY = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
    return deltaXY;
}

double ax = -1;
double ay = 1;
double bx = 2;
double by = 5;

Console.WriteLine("lenght " + Math.Round(length(ax, ay, bx, by), 2));*/
void BoxSq(int N)
{
    int i = 1;
    int[] array = new int[N - 1];
    while (i <= N)
    {
        array[i] = i * i;
        //Console.WriteLine(i*i);
        i++;
        //return;
    }
}
int Num = 5;
BoxSq(Num);