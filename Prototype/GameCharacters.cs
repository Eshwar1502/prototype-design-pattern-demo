using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class InGameCharacterPrototype
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int HealthPoints { get; set; }
        public int HitPoints { get; set; }
        public WeaponPrototype Weapon { get; set; }
        protected InGameCharacterPrototype ShallowCopy()
        {
            return (InGameCharacterPrototype)this.MemberwiseClone();
        }
        public abstract InGameCharacterPrototype Clone();

    }

    public class Champion : InGameCharacterPrototype
    {
        public override InGameCharacterPrototype Clone()
        {
            var ClonedPrototype = this.ShallowCopy();

            ClonedPrototype.HitPoints = this.HitPoints + 10;
            ClonedPrototype.HealthPoints = this.HealthPoints - 10;

            ClonedPrototype.Weapon = this.Weapon.Clone();

            return ClonedPrototype;
        }
    }

    public class Destroyer : InGameCharacterPrototype
    {
        public override InGameCharacterPrototype Clone()
        {
            var ClonedPrototype = this.ShallowCopy();

            ClonedPrototype.HitPoints = this.HitPoints + 15;
            ClonedPrototype.HealthPoints = this.HealthPoints - 15;

            ClonedPrototype.Weapon = this.Weapon.Clone();

            return ClonedPrototype;
        }
    }


}
