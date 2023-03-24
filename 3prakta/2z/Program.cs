class SmsMessage
{
    private string MessageText { get; set; }
    private double Price { get; set; }
    public SmsMessage(string messageText)
    {
        MessageText = messageText;
        Price = 0;
    }
    public void CalculatePrice()
    {
        if (MessageText.Length <= 65)
        {
            Price = 150;
        }
        else
        {
            Price = (150 + (MessageText.Length - 65) * 50) / 100;
        }
    }
    public override string ToString()
    {
        return $"Сообщение: {MessageText}, Цена: {Price} копеек";
    }
    public static void Main(string[] args)
    {
        SmsMessage message = new SmsMessage("я чурка?");
        message.CalculatePrice();
        Console.WriteLine(message);
    }
}