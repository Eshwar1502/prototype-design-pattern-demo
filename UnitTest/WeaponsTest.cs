using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype;

namespace UnitTest
{
    public class WeaponsTesting
    {
        [Fact]
        public void SwordTesting()
        {
            var sword = new Sword { Name = "Excalibur", AttackPower = 20, Cost = 30 };

            var ClonedSword = sword.Clone();

            //Attack Power should increase by 5
            Assert.Equal(25, ClonedSword.AttackPower);

            //Cost Should Reduce by 10
            Assert.Equal(20, ClonedSword.Cost);
        }

        [Fact]
        public void StaffTesting()
        {
            var staff = new Staff { Name = "Mystic Staff", AttackPower = 30, Cost = 40 };
            
            var ClonedStaff = staff.Clone();

            // HitPoints should increase by 15
            Assert.Equal(40, ClonedStaff.AttackPower);

            // HealthPoints should decrease by 15
            Assert.Equal(35, ClonedStaff.Cost);
        }
    }
}
