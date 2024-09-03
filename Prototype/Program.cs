using System.Threading;

namespace Prototype
{

    public class Program
    {
        public static void Main(string[] args)
        {

            var WeaponSword = new Sword { Name = "Excalibur", AttackPower = 20, Cost = 30 };
            var WeaponStaff = new Staff { Name = "Mystic Staff", AttackPower = 30, Cost = 40 };

            var WeaponSwordClone = WeaponSword.Clone();
            var WeaponStaffClone = WeaponStaff.Clone();


            var ChampOne = new Champion { Name = "FlameBlade", Element = "Fire", HealthPoints = 100, HitPoints = 30, Weapon = WeaponSword };
            var ChampTwo = new Champion { Name = "Vortex", Element = "Air", HealthPoints = 100, HitPoints = 25, Weapon = WeaponSwordClone };

            var DestOne = new Destroyer { Name = "IceBurst", Element = "Ice", HealthPoints = 100, HitPoints = 25, Weapon = WeaponStaff };
            var DestTwo = new Destroyer { Name = "ThunderBird", Element = "Lightning", HealthPoints = 100, HitPoints = 35, Weapon = WeaponStaffClone };

            var ChampOneClone = ChampOne.Clone();
            var ChampTwoClone = ChampTwo.Clone();

            var DestOneClone = DestOne.Clone();
            var DestTwoClone = DestTwo.Clone();

            Console.WriteLine("Original Champion: Name = {0}, Element = {1}, Health = {2} ,HitPoints = {3}",
            ChampOne.Name, ChampOne.Element, ChampOne.HealthPoints, ChampOne.HitPoints);

            Console.WriteLine("Cloned Champion: Name = {0}, Element = {1}, Health = {2} ,HitPoints = {3}",
            ChampOneClone.Name, ChampOneClone.Element, ChampOneClone.HealthPoints, ChampOneClone.HitPoints);

            Console.WriteLine("Original Destroyer: Name = {0}, Element = {1}, Health = {2} ,HitPoints = {3}",
            DestOne.Name, DestOne.Element, DestOne.HealthPoints, DestOne.HitPoints);

            Console.WriteLine("Cloned Destroyer: Name = {0}, Element = {1}, Health = {2} ,HitPoints = {3}",
            DestTwoClone.Name, DestTwoClone.Element, DestTwoClone.HealthPoints, DestTwoClone.HitPoints);

            Console.WriteLine("Original Weapon: Name = {0}, Attack Power= {1}, Cost= {2}",
            WeaponSword.Name, WeaponSword.AttackPower, WeaponSword.Cost);

            Console.WriteLine("Cloned Weapon: Name = {0}, Attack Power= {1}, Cost= {2}",
            WeaponSwordClone.Name, WeaponSwordClone.AttackPower, WeaponSwordClone.Cost);


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("GAME 1 BEGINS");
            var Game1 = new GamePlay(ChampTwoClone, DestTwo, "DragonsLiar");
            Game1.Winner();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("GAME 2 BEGINS");
            var Game2 = new GamePlay(ChampOneClone, DestOne, "TheArctic");
            Game2.Winner();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("GAME 3 BEGINS");
            var Game3 = new GamePlay(DestOneClone, DestTwoClone, "ThunderStruck");
            Game3.Winner();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("GAME 4 BEGINS");
            var Game4 = new GamePlay(ChampOne, ChampTwo, "TheStorm");
            Game4.Winner();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        }
    }
}
