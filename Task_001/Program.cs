int b1 = 0;
int k1 = 0;
int b2 = 0;
int k2 = 0;
int x = 0;
int y1 = 0;
int y2 = 0;

int MathLines()
{
    return new Random().Next(1, 10);
}
k1 = MathLines();
k2 = MathLines();
b1 = MathLines();
b2 = MathLines();

void Lines()
{
    x = (b2-b1) / (k1-k2);
    y1 = k1 * x + b1;
    y2 = k2 * x + b2;
}
Lines();
if (y1 == y2)
{
    Console.WriteLine("Точка пересечения двух прям находится на координатах "+ x + ", " + y1);
}
else
{
    Console.WriteLine("Точек пересечения нет");
}