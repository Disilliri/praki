namespace zadacha_3
{
    interface IFilter
    {
        string Execute(string textLine);
    }
    class DigitFilter : IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            char[] symbols = { ' ', ',', ':', ';', '-', '"', '(', ')', '.', '!', '?' };
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    class LetterFilter : IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    internal class TEST
    {
        static void Main(string[] args)
        {
            DigitFilter stringLetters = new DigitFilter();
            Console.WriteLine(stringLetters.Execute("Яблоко от яблони недалеко падает."));
            LetterFilter stringDigits = new LetterFilter();
            Console.WriteLine(stringDigits.Execute("1Наива2жнейшею прим3етою уд4ачи Х5охля6тского на7рода ес8ть ег9о садис1тская жесто2кос3ть."));
            Console.ReadKey(true);
        }
    }
}
