using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Wizard : Unit
    {
        /*static public int MinStr = 10;
        static public int MaxStr = 45;
        static public int MinDex = 20;
        static public int MaxDex = 70;
        static public int MinCons = 15;
        static public int MaxCons = 60;
        static public int MinInt = 35;
        static public int MaxInt = 250;*/
        public Wizard() : base(10, 20, 15, 35)
        {
            MinStr = 10;
            MaxStr = 45;
            MinDex = 20;
            MaxDex = 70;
            MinCons = 15;
            MaxCons = 60;
            MinInt = 35;
            MaxInt = 250;
            HP = MinStr * 1 + MinCons * 3;
            MP = MinInt * 2;
            Att = MinStr * 3;
            MAtt = MinInt * 5;
            Def = MinDex * 0.5 + MinCons * 1;
            SkillPoint = 100;
        }

        public void changeStrPlus(Wizard wizard)
        {
            wizard.Att += 3;
            wizard.HP += 1;
        }
        public void changeStrMinus(Wizard wizard)
        {
            wizard.Att -= 3;
            wizard.HP -= 1;
        }
        public void changeDexPlus(Wizard wizard)
        {
            wizard.Def += 0.5;
        }
        public void changeDexMinus(Wizard wizard)
        {
            wizard.Def -= 0.5;
        }
        public void changeConsPlus(Wizard wizard)
        {
            wizard.HP += 3;
            wizard.Def += 1;
        }
        public void changeConsMinus(Wizard wizard)
        {
            wizard.HP -= 3;
            wizard.Def -= 1;
        }
        public void changeIntPlus(Wizard wizard)
        {
            wizard.MP += 2;
            wizard.MAtt += 5;
        }
        public void changeIntMinus(Wizard wizard)
        {
            wizard.MP -= 2;
            wizard.MAtt -= 5;
        }
    }
}
