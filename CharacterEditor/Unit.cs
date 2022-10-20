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
        ObjectId _id;
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
        public double HP { get; set; }
        public double MP { get; set; }
        public double Att { get; set; }
        public double MAtt { get; set; }
        public double Def { get; set; }
        

        public Unit(int str,int dex, int cons, int int_)
        {
            this.Str = str;
            this.Dex = dex;
            this.Cons = cons;
            this.Int = int_;
        }
    }
}
