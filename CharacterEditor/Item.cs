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
        public double HP { get; set; }
        public double MP { get; set; }
        public double Att { get; set; }
        public double MAtt { get; set; }
        public double Def { get; set; }
    }
}
