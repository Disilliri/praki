Operation n = new Operation();
n.numpred();
while (true)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (n.setNumber(input))
    {
        n.numpred();
    }
    else
    {
        Console.WriteLine("Error");
        break;
    }
}
class Operation
{
    private int n = 0;
    public int getNumber()
    {
        return n;
    }
    public void resetNumber()
    {
        n = 0;
    }
    public bool setNumber(int n)
    {
        if (this.n + 1 == n)
        {
            this.n = n;
            return true;
        }
        else
        {
            resetNumber();
            return false;
        }
    }
    public void numpred()
    {
        Console.WriteLine("Введите число " + (this.n + 1));
    }
}


