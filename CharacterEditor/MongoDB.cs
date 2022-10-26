using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterEditor
{
    public class MongoDB
    {
        public static void AddToDB(Unit unit)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            collection.InsertOne(unit);

        }

        public static List<Unit> FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static Unit Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();
            if (one == null)
            {
                return null;
            }
            switch (one.GetType().Name)
            {
                case "Rogue": return one as Rogue;
                case "Wizard": return one as Wizard;
                case "Warrior": return one as Warrior;
            }
            return one;
        }

        public static void ReplaceByName(string name, Unit unit)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            collection.ReplaceOne(x => x.Name == name, unit);
        }

        /*public void TestMethod()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            var update = Builders<Unit>.Update.Set("MilitaryTicket", 0);
            collection.UpdateMany(x => x.Age >= 18 && x.Age < 35, update);
        }*/
    }
}