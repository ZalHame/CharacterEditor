using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterEditor
{
    internal class MongoDB
    {
        public void AddToDB(Unit unit)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            collection.InsertOne(unit);

        }

        public void FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                MessageBox.Show($"Nickname - {item?.Name} \nHP - {item?.HP} \nMP - {item?.MP}" +
                                $"\nAtt - {item?.Att} \nMAtt - {item?.MAtt} \nDef{item?.Def}");
            }
        }

        public void Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();

            MessageBox.Show($"Nickname - {one?.Name} \nHP - {one?.HP} \nMP - {one?.MP}" +
                            $"\nAtt - {one?.Att} \nMAtt - {one?.MAtt} \nDef - {one?.Def}");
        }

        /*public void ReplaceByName(string name, Unit unit)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            collection.ReplaceOne(x => x.Name == name, unit);
        }

        public void TestMethod()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharList");
            var collection = database.GetCollection<Unit>("Units");
            var update = Builders<Unit>.Update.Set("MilitaryTicket", 0);
            collection.UpdateMany(x => x.Age >= 18 && x.Age < 35, update);
        }*/
    }
}