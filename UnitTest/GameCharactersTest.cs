using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype;

namespace UnitTest
{
 
    public class GameCharacterTesting
    {
        [Fact]
        public void WarriorTesting()
        {
            var sword = new Sword { Name = "Excalibur", AttackPower = 20, Cost = 30 };
            var champion = new Champion { Name = "FlameBlade", Element = "Fire", HealthPoints = 100, HitPoints = 30, Weapon = sword };

            var ClonedChampion = champion.Clone();

            // HitPoints should increase by 10
            Assert.Equal(40, ClonedChampion.HitPoints);

            // HealthPoints should decrease by 10
            Assert.Equal(90, ClonedChampion.HealthPoints); 
        }

        [Fact]
        public void DestroyerTesting()
        {
            var staff = new Staff { Name = "Mystic Staff", AttackPower = 30, Cost = 40 };
            var destroyer = new Destroyer { Name = "IceBurst", Element = "Ice", HealthPoints = 100, HitPoints = 25, Weapon = staff };

            var ClonedDestroyer = destroyer.Clone();

            // HitPoints should increase by 15
            Assert.Equal(40, ClonedDestroyer.HitPoints);

            // HealthPoints should decrease by 15
            Assert.Equal(85, ClonedDestroyer.HealthPoints); 
        }
    }


}
