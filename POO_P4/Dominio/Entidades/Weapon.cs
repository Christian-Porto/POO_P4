using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P4.Dominio.Entidades
{
    public class Weapon
    {
        public int Damage { get; protected set; }
        public int GoodGuyDamage { get; protected set; }
        public int BadGuyDamage { get; protected set; }

        private Weapon() { }

        public Weapon(int damage, int goodGuyDamage, int badGuyDamage)
        {
            SetDamage(damage);
            SetGoodGuyDamage(goodGuyDamage);
            SetBadGuyDamage(badGuyDamage);
        }

        public void SetDamage(int damage)
        {
            Damage = damage;
        }

        public void SetGoodGuyDamage(int goodGuyDamage)
        {
            GoodGuyDamage = goodGuyDamage;
        }

        public void SetBadGuyDamage(int badGuyDamage)
        {
            BadGuyDamage = badGuyDamage;
        }
    }
}
