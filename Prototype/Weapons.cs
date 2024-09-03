using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class WeaponPrototype
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Cost { get; set; }

        public WeaponPrototype ShallowCopy()
        {
            return (WeaponPrototype)this.MemberwiseClone();
        }

        public abstract WeaponPrototype Clone();
    }
    public class Sword : WeaponPrototype
    {
        public override WeaponPrototype Clone()
        {
            var ClonedPrototype = this.ShallowCopy();
            ClonedPrototype.AttackPower += 5;
            ClonedPrototype.Cost -= 10;
            return ClonedPrototype;
        }
    }
    public class Staff : WeaponPrototype
    {
        public override WeaponPrototype Clone()
        {
            var ClonedPrototype = this.ShallowCopy();
            ClonedPrototype.AttackPower += 10;
            ClonedPrototype.Cost -= 5;
            return ClonedPrototype;
        }
    }
}
