namespace zadacha_2
{
    interface IHello
    {
        void SayHello();
    }
    class Russian : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class Belarusian : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("прывітанне");
        }
    }
    class Ukrainian : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("хрю хрю");
        }
    }
    class Japanese : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("今日は");
        }
    }
    class Polish : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Cześć");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new Belarusian());
            greetings.Add(new Ukrainian());
            greetings.Add(new Japanese());
            greetings.Add(new Polish());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}
