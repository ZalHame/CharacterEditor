using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    [BsonIgnoreExtraElements]
    [BsonKnownTypes(typeof(Wizard), typeof(Rogue), typeof(Warrior))]

    internal class Unit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public int Str;
        public int Dex;
        public int Cons;
        public int Int;
        static public int MinStr;
        static public int MaxStr;
        static public int MinDex;
        static public int MaxDex;
        static public int MinCons;
        static public int MaxCons;
        static public int MinInt;
        static public int MaxInt;
        public string Name { get; set; }
        public int SkillPoint { get; set; }
        public int Level { get; set; }
        public int ExpCurrent { get; set; }
        public double HP { get; set; }
        public double MP { get; set; }
        public double Att { get; set; }
        public double MAtt { get; set; }
        public double Def { get; set; }
        public Unit(int str, int dex, int cons, int int_)
        {
            Str = str;
            Dex = dex;
            Cons = cons;
            Int = int_;
            Level = 1;
            ExpCurrent = 0;
            Items = new List<Item>();
            AllItems = new List<Item>();
            Skills = new List<Skill>();
        }

        [BsonIgnoreIfNull]
        public List<Skill> Skills { get; set; }

        [BsonIgnoreIfNull]
        public List<Item> Items { get; set; }

        [BsonIgnoreIfNull]
        public List<Item> AllItems { get; set; }

        public override string ToString()
        {
            return $"Nickname - {this.Name} \n" +
                   $"HP - {this.HP} \n" +
                   $"MP - {this.MP} \n" +
                   $"Att - {this.Att} \n" +
                   $"MAtt - {this.MAtt} \n" +
                   $"Def - {this.Def}";
        }
    }
}