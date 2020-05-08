using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{

    [Serializable]
    class Lych : Monster
    {
        // example monster: rat
        public Lych(int lychLevel)
        {
            Health = 30 + 5 *lychLevel;
            Strength = 10 + lychLevel;
            Armor = 0;
            Precision = 50;
            MagicPower = 40;
            Stamina = 50;
            XPValue = 30 + lychLevel;
            Name = "monster0003";
            BattleGreetings = "YOU WILL BE MINE "; // rat doesn't say anything
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                // will implement drian mechanics

                return new List<StatPackage>() { new StatPackage("drain", 5 + MagicPower, "Rat uses Bite! (" + (5 + MagicPower) + " stab damage)") };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Lych has no energy to attack anymore!") };
            }
        }
    }

}

