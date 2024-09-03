using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype;

namespace UnitTest
{
    
    public class GamePlayTesting
    {
        [Fact]
        public void GamePlayBasedOnMapTesting()
        {
            var sword = new Sword { Name = "Excalibur", AttackPower = 20, Cost = 30 };
            var staff = new Staff { Name = "Mystic Staff", AttackPower = 30, Cost = 40 };

            var champion = new Champion { Name = "FlameBlade", Element = "Fire", HealthPoints = 100, HitPoints = 30, Weapon = sword };
            var destroyer = new Destroyer { Name = "IceBurst", Element = "Ice", HealthPoints = 100, HitPoints = 25, Weapon = staff };

            var Game = new GamePlay(champion, destroyer, "DragonsLiar");

            using (var Output = new System.IO.StringWriter())
            {
                Console.SetOut(Output);

                Game.Winner();

                var result = Output.ToString().Trim();
                Assert.Contains("FlameBlade Wins the Game Because He is in his Element", result);
            }
        }

        [Fact]
        public void GamePlayBasedOnScoreTesting()
        {
            var sword = new Sword { Name = "Excalibur", AttackPower = 20, Cost = 30 };
            var staff = new Staff { Name = "Mystic Staff", AttackPower = 30, Cost = 40 };

            var champion = new Champion { Name = "FlameBlade", Element = "Fire", HealthPoints = 100, HitPoints = 30, Weapon = sword };
            var destroyer = new Destroyer { Name = "IceBurst", Element = "Ice", HealthPoints = 100, HitPoints = 25, Weapon = staff };

            var Game = new GamePlay(champion, destroyer, "ThunderStruck");

            using (var Output = new System.IO.StringWriter())
            {
                Console.SetOut(Output);

                Game.Winner();

                var result = Output.ToString().Trim();
                Assert.Contains("IceBurst Wins the Game Because of a Higher Hit Rate", result);
            }

        }
    }
}
