using POO_P4.Dominio.Entidades;
using POO_P4.Dominio.Enumeradores;

namespace POO_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            var warrior1 = new Warrior(Faction.GoodGuy, "Warrior1", 100, 100);
            var warrior2 = new Warrior(Faction.BadGuy, "Warrior2", 100, 100);

            var weapon1 = new Weapon(20, 25, 15);
            var weapon2 = new Weapon(18, 22, 12);

            var armor1 = new Armor(30, 35, 25);
            var armor2 = new Armor(25, 30, 20);

            warrior1.SetWeapon(weapon1);
            warrior2.SetWeapon(weapon2);

            warrior1.SetArmor(armor1);
            warrior2.SetArmor(armor2);

            int damage = warrior1.Attack(warrior2);
            Console.WriteLine($"{warrior1.Name} attacked {warrior2.Name} for {damage}.\n" +
                $"{warrior1.Name} current health: {warrior1.Health}\n" +
                $"{warrior2.Name} current health: {warrior2.Health}\n" +
                new string('-', 40));

            Console.ReadLine();
        }
    }
}
