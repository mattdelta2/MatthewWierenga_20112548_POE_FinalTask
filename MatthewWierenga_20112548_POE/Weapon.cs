using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_20112548_POE
{
    abstract class Weapon
    {
        protected int damage;
        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }

        protected int range;
        public int RANGE
        {
            get { return range; }
            set { range = value; }
        }

        protected int durability;
        public int DURABILITY
        {
            get { return durability; }
            set { durability = value; }

        }

        protected int cost;
        public int COST
        {
            get { return cost; }
            set { cost = value; }
        }

        protected string weaponType;

        public string WEAPONTYPE
        {
            get { return weaponType; }
            set { weaponType = value; }
        }
    }

    class MeleeWeapon : Weapon
    {
        enum MeleeWeapons
        {
            Dagger,
            Longsword
        }

        


        
    }


    class RangeWeapon: Weapon
    {
        enum RangeWeapons
        {
            LongBow,
            Rifle
        }
    }
}
