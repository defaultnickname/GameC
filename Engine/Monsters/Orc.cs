using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class Orc: Monster
    {
        public Orc (int orcLevel)
        {
            Health = 30 + 5 * orcLevel;
            Strength = 10 + orcLevel;
            Armor = 0;
            Precision = 50;
            MagicPower = 0;
            Stamina = 50;
            XPValue = 20 + orcLevel;
            Name = "monster0004";
            BattleGreetings = "TOPÓR KU*A"; // orc says "TOPÓR KUPA", "TOPÓR KUCA", "TOPÓR KUNA" or anything you wish
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                // a simple bite move dealing 5 + (rat strength statistic) damage
              
                if (Convert.ToBoolean(Index.RNG(0  ,1)))
                {
                    return new List<StatPackage>() {

                    new StatPackage("stab", 5 + Strength, "Orc smash! (" + (5 + Strength) + " stab damage)"),
                    new StatPackage("stab", 5 + Strength, "and again! (" + (5 + Strength) + " stab damage)")
                    };

                }
                else
                {
                    return new List<StatPackage>() {

                    new StatPackage("stab", 5 + Strength, "Orc smash once! (" + (5 + Strength) + " stab damage)") };
                }
                
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Orc has no energy to attack anymore!") };
            }
        }
    }


}

