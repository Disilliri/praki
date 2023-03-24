Random rand = new Random();
rand.GetIntFixedLength(8);
public static class RandExtension
{
    public static int GetIntFixedLength(this Random rand, int length)
    {
        length = length > 0 && length < 10 ? length : 1; 
        return rand.Next(Convert.ToInt32(Math.Pow(10, length - 1)),
        Convert.ToInt32(Math.Pow(10, length)));
    }
    static void Variance()/*дисперсия*/
    {
        int N = 0;
        double sum;
        int myN;
        int a, b, c;
        double[] avr;
        avr = new double[N];
        for (a = 1; a <= N / 2; a++)
        {
            myN = N / a;
            for (b = 0; b <= myN - 1; b++)
            {
                sum = 0;
                for (c = b * a; c < b * a + a; c++)
                {
                    sum += c;
                }
                avr[b] = sum / a;
            }
            sum = 0;
            for (b = 0; b < (myN - 1); b++)
            {
                sum += Math.Pow((avr[b + 1] - avr[b]), 2);
            }
        }
    }
    public static double StandardDeviation(List<double> valueList)/*отклонение*/
    {
        double M = 0.0;
        double S = 0.0;
        int k = 1;
        foreach (double value in valueList)
        {
            double tmpM = M;
            M += (value - tmpM) / k;
            S += (value - tmpM) * (value - M);
            k++;
        }
        return Math.Sqrt(S / (k - 2));
    }
    public static double GetMedian(double[] arrSource)/*Медиана*/
    {
        /*Проверка есть ли в массиве значения*/       
        if (arrSource == null || arrSource.Length == 0)
            throw new ArgumentException("Массив пустой.");

        /*Сортировка массива*/
        double[] arrSorted = (double[])arrSource.Clone();
        Array.Sort(arrSorted);

        /*Вычисление медианы*/
        int size = arrSorted.Length;
        int mid = size / 2;

        if (size % 2 != 0)
            return arrSorted[mid];

        dynamic value1 = arrSorted[mid];
        dynamic value2 = arrSorted[mid - 1];
        return (value1 + value2) / 2;
    }
}

