using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Rogue : Unit
    {
        /*static public int MinStr = 15;
        static public int MaxStr = 55;
        static public int MinDex = 30;
        static public int MaxDex = 250;
        static public int MinCons = 20;
        static public int MaxCons = 80;
        static public int MinInt = 15;
        static public int MaxInt = 70;*/
        public Rogue() : base(15, 30, 20, 15)
        {
            MinStr = 15;
            MaxStr = 55;
            MinDex = 30;
            MaxDex = 250;
            MinCons = 20;
            MaxCons = 80;
            MinInt = 15;
            MaxInt = 70;
            HP = MinStr * 1 + MinCons * 6;
            MP = MinInt * 1.5;
            Att = MinStr * 2 + MinDex * 4;
            MAtt = MinInt * 2;
            Def = MinDex * 1.5 + MinCons * 2;
            SkillPoint = 100;
        }

        public void changeStrPlus(Rogue rogue)
        {
            rogue.Att += 2;
            rogue.HP += 1;
        }
        public void changeStrMinus(Rogue rogue)
        {
            rogue.Att -= 2;
            rogue.HP -= 1;
        }
        public void changeDexPlus(Rogue rogue)
        {
            rogue.Att += 4;
            rogue.Def += 1.5;
        }
        public void changeDexMinus(Rogue rogue)
        {
            rogue.Att -= 4;
            rogue.Def -= 1.5;
        }
        public void changeConsPlus(Rogue rogue)
        {
            rogue.HP += 6;
        }
        public void changeConsMinus(Rogue rogue)
        {
            rogue.HP -= 6;
        }
        public void changeIntPlus(Rogue rogue)
        {
            rogue.MP += 1.5;
            rogue.MAtt += 2;
        }
        public void changeIntMinus(Rogue rogue)
        {
            rogue.MP -= 1.5;
            rogue.MAtt -= 2;
        }
    }
}
