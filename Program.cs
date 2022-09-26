using System.Runtime.Intrinsics.X86;

double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
if (x >= -1 && x <= 1)
{
    if (y <= 1 && y >= 0)
    {
        if (Math.Abs(x + y) == 1)
            Console.WriteLine("Входит");
        else
            Console.WriteLine("Не входит");
    }
    if (y <= 0 && y >= -1)
    {
        if (y == Math.Pow(-x, Math.E))
            Console.WriteLine("Входит");
        else
            Console.WriteLine("Не входит");

    }
}
else
    Console.WriteLine("Не входит");

