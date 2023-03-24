solveSqrtExpression root = new solveSqrtExpression();
void sqrtExpression(int a, int b, int c)
{
    root.setDiscr(a, b, c);
    root.setSqrt1(a, b, c);
    root.setSqrt2(a, b, c);
}
sqrtExpression(17, -7, 5);
Console.WriteLine("Дискриминант = " + root.getdisqualification());
if (root.getroot1() == -999999999 && root.getroot2() == -999999999)
{
    Console.WriteLine("Корней нет");
}
else if (root.getroot1() == -999999999 || root.getroot2() == -999999999)
{
    if (root.getroot1() == -999999999)
    {
        Console.WriteLine("Корень 1: Корня нет");
    }
    else
    {
        Console.WriteLine("Корень 2: Корня нет");
    }
}
else
{
    Console.WriteLine("Корень 1  " + root.getroot1());
    Console.WriteLine("Корень 2  " + root.getroot2());
}
Console.ReadKey();
class solveSqrtExpression
{
    private double root1/*первый корень*/, root2/*второй корень*/, disqualification/*дискрименант*/;

    public double getroot1()
    {
        return root1;
    }
    public double getroot2()
    {
        return root2;
    }
    public double getdisqualification()
    {
        return disqualification;
    }
    public void setSqrt1(int a, int b, int c)
    {
        this.root1 = CalculateRoots(a, b, getdisqualification())[0];
    }
    public void setSqrt2(int a, int b, int c)
    {
        this.root2 = CalculateRoots(a, b, getdisqualification())[1];
    }
    public void setDiscr(int a, int b, int c)
    {
        this.disqualification = (b * b) - 4 * a * c;
    }
    private double[] CalculateRoots(int a, int b, double d)
    {
        if (d > 0)
        {
            double root1 = (-b + Math.Sqrt(d)) / (2 * a);
            double root2 = (-b - Math.Sqrt(d)) / (2 * a);
            double[] roots = { root1, root2 };
            return roots;
        }
        else if (d == 0)
        {
            double root1 = (-b + Math.Sqrt(d)) / (2 * a);
            double[] roots = { root1, -999999999 };
            return roots;
        }
        else
        {
            double[] roots = { -999999999, -999999999 };
            return roots;
        }
    }
}
