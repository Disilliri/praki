// See https://aka.ms/new-console-template for more information
Car vaz2110 = new Car();
vaz2110.name = "Ваз 2110";
vaz2110.speed = 200;
vaz2110.Print();

Car priora = new Car();
priora.name = "Лада Приора";
priora.speed = 140;
priora.Print();

Car bmw = new Car();
bmw.name = "Бэха";
bmw.speed = 190;
bmw.Print();

Car mers = new Car();
mers.name = "Мерседес";
mers.speed = 40;
mers.Print();

Console.WriteLine($"гоночки");
if (vaz2110.speed> priora.speed)
{
    Console.WriteLine($"ВАЗ 21110 пришел первым");
}

if (priora.speed> bmw.speed)
{
    Console.WriteLine($"Приора пришла второй");
}

if (bmw.speed> mers.speed)
{
    Console.WriteLine($"ВАЗ 21110 победила, а мерсик улетел в сервис");
}

class Car
{
    public string name;
    public int speed;
    public void Print()
    {
        Console.WriteLine($"Название автомобиля: {name}");
        Console.WriteLine($"Максимальная скорость: {speed} км/ч");
    }
}

