using POO_P4.Dominio.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P4.Dominio.Entidades
{
    public class Warrior
    {
        public Faction Faction { get; protected set; }
        public int Health { get; protected set; }
        public string Name { get; protected set; }
        public bool IsAlive { get; protected set; }
        public Weapon Weapon { get; protected set; }
        public Armor Armor { get; protected set; }
        public int GoodGuyStartingHealth { get; protected set; }
        public int BadGuyStartingHealth { get; protected set; }

        public Warrior(Faction faction, string name, int goodGuyStartingHealth, int badGuyStartingHealth)
        {
            Faction = faction;
            Name = name;
            GoodGuyStartingHealth = goodGuyStartingHealth;
            BadGuyStartingHealth = badGuyStartingHealth;
            SetHealth((faction == Faction.GoodGuy) ? goodGuyStartingHealth : badGuyStartingHealth);
            IsAlive = true;
        }

        public void SetHealth(int health)
        {
            Health = health;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetIsAlive(bool isAlive)
        {
            IsAlive = isAlive;
        }

        public void SetWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }

        public void SetArmor(Armor armor)
        {
            Armor = armor;
        }

        public void SetGoodGuyStartingHealth(int goodGuyStartingHealth)
        {
            GoodGuyStartingHealth = goodGuyStartingHealth;
        }

        public void SetBadGuyStartingHealth(int badGuyStartingHealth)
        {
            BadGuyStartingHealth = badGuyStartingHealth;
        }

        public void Attack(Warrior enemy)
        {
            if (IsAlive && enemy.IsAlive)
            {
                int damage = (Faction == Faction.GoodGuy) ? Weapon.GoodGuyDamage : Weapon.BadGuyDamage;
            }
        }
    }
}
