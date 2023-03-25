namespace zadacha_3
{
    class Orc
    {
        private static int Count;
        public static int totalGold { get; private set; }
        public int PortableGold { get; private set; }
        public Orc()
        {
            Count++;
            totalGold += 2;
            if (Count > 5)
            {
                PortableGold += 2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc_1 = new Orc();
            Console.WriteLine(Orc.totalGold);
            Orc orc_2 = new Orc();
            Orc orc_3 = new Orc();
            Console.WriteLine(Orc.totalGold);
            Orc orc_4 = new Orc();
            Orc orc_5 = new Orc();
            Orc orc_6 = new Orc();
            Console.WriteLine(orc_6.PortableGold);
            Console.ReadKey(true);
        }
    }
}