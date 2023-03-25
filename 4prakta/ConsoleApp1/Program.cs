namespace zadacha_1
{
    class Spells
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        private string Effect { get; set; }
        public Spells(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void Use()
        {
            Console.WriteLine(Effect);
        }
    }
    class Magic
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        public Magic(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spells spells)
        {
            if (Mana >= spells.Mana)
            {
                Mana -= spells.Mana;
                Console.WriteLine("{0} ультует!", Name);
                spells.Use();
            }
            else
            {
                int mana = spells.Mana - Mana;
                Console.WriteLine(
                    "Для использования {0} не хватает {1} единиц маны. Хлебните зелья маны!",
                    spells.Name, mana);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Spells alohomora = new Spells("REQUIEM OF SOULS", 60, "Дамой!");
            Spells vingardiumLeviosa = new Spells("Shadoraze", 40, "Улетели в таверну!");
            Magic garryPotter = new Magic("Сфчик", 100);
            garryPotter.CastSpell(alohomora);
            garryPotter.CastSpell(vingardiumLeviosa);
            Console.ReadKey();
        }
    }
}