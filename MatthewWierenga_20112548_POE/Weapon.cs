using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MatthewWierenga_20112548_POE
{
    abstract class Weapon
    {
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected string weaponType;

        public Weapon(int damage, int range, int durability, int cost, string weaponType)
        {
            this.damage = damage;
            this.range = range;
            this.durability = durability;
            this.cost = cost;
            this.weaponType = weaponType;
        }

        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }


        public int RANGE
        {
            get { return range; }
            set { range = value; }
        }


        public int DURABILITY
        {
            get { return durability; }
            set { durability = value; }

        }


        public int COST
        {
            get { return cost; }
            set { cost = value; }
        }



        public string WEAPONTYPE
        {
            get { return weaponType; }
            set { weaponType = value; }
        }
    }


    enum Types
    {
        Dagger,
        Longsword
    };


    internal class MeleeWeapon : Weapon

        
        
    {
      
        public MeleeWeapon(int damage, int range, int durability, int cost, string weaponType) : base(damage, range, durability, cost, weaponType)
        {
            range = 1;  


        }

    }

       


    class RangeWeapon : Weapon
    {
        public RangeWeapon(int damage, int range, int durability, int cost, string weaponType) : base(damage, range, durability, cost, weaponType)
        {
        }

        enum RangeWeapons
        {
            LongBow,
            Rifle
        }
    }
}
