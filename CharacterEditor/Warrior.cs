using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Warrior : Unit
    {
        /*static public int MinStr = 30;
        static public int MaxStr = 250;
        static public int MinDex = 15;
        static public int MaxDex = 70;
        static public int MinCons = 20;
        static public int MaxCons = 100;
        static public int MinInt = 10;
        static public int MaxInt = 50;*/
        
        public Warrior() : base ( 30, 15, 20, 10)
        {
            MinStr = 30;
            MaxStr = 250;
            MinDex = 15;
            MaxDex = 70;
            MinCons = 20;
            MaxCons = 100;
            MinInt = 10;
            MaxInt = 50;
            HP = MinStr * 2 + MinCons * 10;
            MP = MinInt * 1;
            Att = MinStr * 5 + MinDex * 1;
            MAtt = MinInt * 1;
            Def = MinDex * 1 + MinCons * 2;
            SkillPoint = 100;
        }

        public void changeStrPlus(Warrior warrior)
        {
            warrior.Att += 5;
            warrior.HP += 2;
        }
        public void changeStrMinus(Warrior warrior)
        {
            warrior.Att -= 5;
            warrior.HP -= 2;
        }
        public void changeDexPlus(Warrior warrior)
        {
            warrior.Att += 1;
            warrior.Def += 1;
        }
        public void changeDexMinus(Warrior warrior)
        {
            warrior.Att -= 1;
            warrior.Def -= 1;
        }
        public void changeConsPlus(Warrior warrior)
        {
            warrior.HP += 10;
            warrior.Def += 2;
        }
        public void changeConsMinus(Warrior warrior)
        {
            warrior.HP -= 10;
            warrior.Def -= 2;
        }
        public void changeIntPlus(Warrior warrior)
        {
            warrior.MP += 1;
            warrior.MAtt += 1;
        }
        public void changeIntMinus(Warrior warrior)
        {
            warrior.MP -= 1;
            warrior.MAtt -= 1;
        }
    }
}