using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    [BsonKnownTypes(typeof(Helmet), typeof(Armor), typeof(Weapon))]
    public class Item
    {
        public Item(string itemName, int itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public double Damage { get; set; }
        public double Hp { get; set; }
        public double PhDef { get; set; }
        public double Mana { get; set; }
        public double MageAttack { get; set; }
    }
}
