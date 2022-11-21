using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterEditor
{
    public partial class Teams : Form
    {
        int FirstTeam = 0;
        int SecondTeam = 0;
        Dictionary<string, int> units = new Dictionary<string, int>();
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("CharList");
        static IMongoCollection<Unit> collection = database.GetCollection<Unit>("Units");

        public void FindAllCharacters(ListBox list)
        {
            List<Unit> characters = collection.AsQueryable().ToList();
            foreach (var item in characters)
            {
                units.Add(item.Name, item.Level);
            }
            foreach (var pair in units.OrderBy(pair => pair.Value).Reverse())
            {
                list.Items.Add(pair.ToString());
            }
        }

        public Teams()
        {
            InitializeComponent();
            FindAllCharacters(lb_AllChar);
        }

        private void button_Autodistribution_Click(object sender, EventArgs e)
        {
            lb_FirstTeam.Items.Clear();
            lb_SecondTeam.Items.Clear();
            FirstTeam = 0;
            SecondTeam = 0;
            Random rnd = new Random();
            int a = rnd.Next(2);

            if (lb_AllChar.Items.Count != 0)
            {
                foreach (var pair in units.OrderBy(pair => pair.Value).Reverse())
                {
                    if (FirstTeam > SecondTeam)
                    {
                        lb_SecondTeam.Items.Add(pair);
                        SecondTeam += pair.Value;
                    }
                    else if (SecondTeam > FirstTeam)
                    {
                        lb_FirstTeam.Items.Add(pair);
                        FirstTeam += pair.Value;
                    }
                    else
                    {
                        if (a == 1)
                        {
                            lb_FirstTeam.Items.Add(pair);
                            FirstTeam += pair.Value;
                        }
                        else
                        {
                            lb_SecondTeam.Items.Add(pair);
                            SecondTeam += pair.Value;
                        }
                    }
                    lb_AllChar.Items.Remove(pair);
                }
                if (FirstTeam - SecondTeam >= 10 || SecondTeam - FirstTeam >= 10)
                {
                    MessageBox.Show("Невозможно создать сбалансированные команды!");
                    lb_FirstTeam.Items.Clear();
                    lb_SecondTeam.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show($"Нет персонажей");
            }
        }
    }
}
