namespace zadacha_2
{
    class ThePackage
    {
        public string Description { get; private set; }
        public int Weight { get; private set; }
        public ThePackage(string description, int weight)
        {
        Description = description;
        Weight = weight;
        }
    }
    class Sending
    {
        private const int Limit = 40;
        private static int LimitWeight;
        public void SendPackage(ThePackage thepackage)
        {
            LimitWeight += thepackage.Weight;
            if (LimitWeight >= Limit)
            {
            Console.WriteLine(
            "Вес отправленных посылок превысил лимит, отправка прервана.");
            }
            else
            {
            Console.WriteLine("{0} весом {1} кг успешно отправлена.",
            thepackage.Description, thepackage.Weight);
            }
        }
    }
    class mail
    {
        static void Main(string[] args)
        {
            ThePackage package_1 = new ThePackage("Легкая посылка #1", 10);
            ThePackage package_2 = new ThePackage("Тяжелая посылка #2", 20);
            Sending sendingService = new Sending();
            sendingService.SendPackage(package_1);
            sendingService.SendPackage(package_2);
            Console.ReadKey();
        }
    }
}