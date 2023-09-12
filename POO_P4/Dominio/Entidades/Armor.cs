using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P4.Dominio.Entidades
{
    public class Armor
    {
        public int ArmorPoints { get; protected set; }
        public int GoodGuyArmor { get; protected set; }
        public int BadGuyArmor { get; protected set; }

        private Armor() { }

        public Armor(int armorPoints, int goodGuyArmor, int badGuyArmor)
        {
            SetArmorPoints(armorPoints);
            SetGoodGuyArmor(goodGuyArmor);
            SetBadGuyArmor(badGuyArmor);
        }

        public void SetArmorPoints(int armorPoints)
        {
            ArmorPoints = armorPoints;
        }

        public void SetGoodGuyArmor(int goodGuyArmor)
        {
            GoodGuyArmor = goodGuyArmor;
        }

        public void SetBadGuyArmor(int badGuyArmor)
        {
            BadGuyArmor = badGuyArmor;
        }
    }
}
