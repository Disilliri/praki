namespace zadacha_5
{
    interface ISpell
    {
        string Name
        {
            get;
            set;
        }
        int Mana
        {
            get;
            set;
        }
        void WriteInfo();
    }
    namespace zadacha_1
    {
        class Spell
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }
            private string Effect { get; set; }
            public Spell(string name, int mana, string effect)
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
        class Magician
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }
            public Magician(string name, int mana)
            {
                Name = name;
                Mana = mana;
            }
            public void CastSpell(Spell spell)
            {
                if (Mana >= spell.Mana)
                {
                    Mana -= spell.Mana;
                    Console.WriteLine("{0} ультует!", Name);
                    spell.Use();
                }
                else
                {
                    int mana = spell.Mana - Mana;
                    Console.WriteLine(
                        "Для использования {0} не хватает {1} единиц маны. Хлебните зелья маны!",
                        spell.Name, mana);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Spell alohomora = new Spell("REQUIEM OF SOULS", 60, "Дамой!");
                Spell vingardiumLeviosa = new Spell("Shadoraze", 40, "Улетели в таверну!");
                Magician garryPotter = new Magician("Сфчик", 100);
                garryPotter.CastSpell(alohomora);
                garryPotter.CastSpell(vingardiumLeviosa);
                Console.ReadKey();
            }
        }
    }
}