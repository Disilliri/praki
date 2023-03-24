class code
{
    static void Main(string[] args)
    {
        Console.WriteLine("Текст для шифрования:");
        string text = Console.ReadLine();
        Console.WriteLine("Ключ = ");
        int key = Convert.ToInt32(Console.ReadLine());
        string encodedText = Encoded(text, key);
        Console.WriteLine("Зашифрованный текст: " + encodedText);
        Console.ReadLine();
    }
    static string Encoded(string text, int key)
    {
        string encodedText = "";
        for (int i = 0; i < text.Length; i++)
        {
            encodedText += (char)(text[i] + key);
        }
        return encodedText;
    }
    static string Decoded(string text, int key)
    {
        string decodedText = "";
        for (int i = 0; i < text.Length; i++)
        {
            decodedText += (char)(text[i] - key);
        }
        return decodedText;
    }
}
