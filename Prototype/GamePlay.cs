using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{

    public class GameMap
    {
        public string MapName { get; set; }
        public string ElementOfPower { get; set; }
    }

    public class GamePlay
    {
        public InGameCharacterPrototype InGameWarrior { get; set; }
        public InGameCharacterPrototype InGameDestroyer { get; set; }

        public string NameofMap { get; set; }

        public List<GameMap> ListOfMaps = new List<GameMap>
    {
        new GameMap { MapName = "TheArctic", ElementOfPower = "Ice" },
        new GameMap { MapName = "DragonsLiar", ElementOfPower = "Fire" },
        new GameMap { MapName = "ThunderStruck", ElementOfPower = "Lightning" },
        new GameMap { MapName = "TheStorm", ElementOfPower = "Air" },
    };

        public GamePlay(InGameCharacterPrototype Warrior1, InGameCharacterPrototype Destroyer1, string Map)
        {
            InGameWarrior = Warrior1;
            InGameDestroyer = Destroyer1;
            NameofMap = Map;
        }

        public void Winner()
        {
            var InGameMap = ListOfMaps.Find(m => m.MapName == NameofMap);

            var WarriorScore = (InGameWarrior.HealthPoints + InGameWarrior.HitPoints + InGameWarrior.Weapon.AttackPower) / 2;

            var DestroyerScore = (InGameDestroyer.HealthPoints + InGameDestroyer.HitPoints + InGameDestroyer.Weapon.AttackPower) / 2;

            if (InGameMap == null)
            {
                Console.WriteLine("You Have Not Unlocked This Map Yet");
                return;
            }

            else if (InGameWarrior.Element == InGameMap.ElementOfPower && InGameDestroyer.Element != InGameMap.ElementOfPower)
            {
                Console.WriteLine("{0} Wins the Game Because He is in his Element and has {1} Advantage", InGameWarrior.Name, InGameWarrior.Element);
            }

            else if (InGameWarrior.Element != InGameMap.ElementOfPower && InGameDestroyer.Element == InGameMap.ElementOfPower)
            {
                Console.WriteLine("{0} Wins the Game Because He is in his Element and has {1} Advantage", InGameDestroyer.Name, InGameDestroyer.Element);
            }

            else
            {
                if (WarriorScore > DestroyerScore)
                {
                    Console.WriteLine("{0} Wins the Game Because of a Higher Hit Rate", InGameWarrior.Name);
                }

                else if (WarriorScore < DestroyerScore)
                {
                    Console.WriteLine("{0} Wins the Game Because of a Higher Hit Rate", InGameDestroyer.Name);
                }

                else
                {
                    Console.WriteLine("MATCH DRAW");
                }

            }
        }
    }
}
