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
    public partial class Inventory : Form
    {
        public List<Item> Items = new List<Item>();
        public List<Item> AllItems = new List<Item>();
        public string NameChar;
        public int Str = 0;
        public int Dex = 0;
        public int Cons = 0;
        public int Int = 0;
        public double HP = 0;
        public double MP = 0;
        public double Att = 0;
        public double MAtt = 0;
        public double Def = 0;
        int count = 0;

        public Inventory()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;
        }

        private void Inventory_MouseMove(object sender, MouseEventArgs e)
        {
            InventoryLoad();
        }

        private void InventoryLoad()
        {
            if (count == 0)
            {
                var one = MongoDB.Find(NameChar);
                foreach (var item in AllItems)
                {
                    ListItems.Items.Add(item.ItemName);
                }
                foreach (var item in one.Items)
                {
                    for (int i = 0; i < lv_Shop.Items.Count; i++)
                    {
                        if (item.ItemName == lv_Shop.Items[i].Text)
                        {
                            switch (lv_Shop.Items[i].SubItems[1].Text)
                            {
                                case "Шлем":
                                    ComboBoxHelmet.Text = item.ItemName;
                                    break;
                                case "Броня":
                                    ComboBoxArmor.Text = item.ItemName;
                                    break;
                                case "Оружие":
                                    ComboBoxWeapon.Text = item.ItemName;
                                    break;
                                default: break;
                            }
                        }
                    }
                }
                foreach (var item in ListItems.Items)
                {
                    for (int i = 0; i < lv_Shop.Items.Count; i++)
                    {
                        if (item.ToString() == lv_Shop.Items[i].Text)
                        {
                            switch (lv_Shop.Items[i].SubItems[1].Text)
                            {
                                case "Шлем":
                                    ComboBoxHelmet.Items.Add(lv_Shop.Items[i].Text);
                                    break;
                                case "Броня":
                                    ComboBoxArmor.Items.Add(lv_Shop.Items[i].Text);
                                    break;
                                case "Оружие":
                                    ComboBoxWeapon.Items.Add(lv_Shop.Items[i].Text);
                                    break;
                                default: break;
                            }
                        }
                    }
                }

                count++;
            }
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            if (Str >= Convert.ToInt32(lv_Shop.SelectedItems[0].SubItems[4].Text) &&
                Dex >= Convert.ToInt32(lv_Shop.SelectedItems[0].SubItems[5].Text) &&
                Cons >= Convert.ToInt32(lv_Shop.SelectedItems[0].SubItems[6].Text) &&
                Int >= Convert.ToInt32(lv_Shop.SelectedItems[0].SubItems[7].Text))
            {
                ListItems.Items.Add(lv_Shop.SelectedItems[0].Text);
                switch (lv_Shop.SelectedItems[0].SubItems[1].Text)
                {
                    case "Шлем":
                        ComboBoxHelmet.Items.Add(lv_Shop.SelectedItems[0].Text);
                        int cash = 0;
                        for (int i = 0; i < lv_Shop.Items.Count; i++)
                        {
                            if (lv_Shop.Items[i].Text == ComboBoxHelmet.Text)
                            {
                                cash = Convert.ToInt32(lv_Shop.Items[i].SubItems[8].Text);
                            }
                        }
                        Helmet helmet = new Helmet(lv_Shop.SelectedItems[0].Text, cash);
                        AllItems.Add(helmet);
                        break;
                    case "Броня":
                        ComboBoxArmor.Items.Add(lv_Shop.SelectedItems[0].Text);
                        int cash1 = 0;
                        for (int i = 0; i < lv_Shop.Items.Count; i++)
                        {
                            if (lv_Shop.Items[i].Text == ComboBoxArmor.Text)
                            {
                                cash1 = Convert.ToInt32(lv_Shop.Items[i].SubItems[8].Text);
                            }
                        }
                        Armor arm = new Armor(lv_Shop.SelectedItems[0].Text, cash1);
                        AllItems.Add(arm);
                        break;
                    case "Оружие":
                        ComboBoxWeapon.Items.Add(lv_Shop.SelectedItems[0].Text);
                        int cash2 = 0;
                        for (int i = 0; i < lv_Shop.Items.Count; i++)
                        {
                            if (lv_Shop.Items[i].Text == ComboBoxWeapon.Text)
                            {
                                cash2 = Convert.ToInt32(lv_Shop.Items[i].SubItems[8].Text);
                            }
                        }
                        Weapon weap = new Weapon(lv_Shop.SelectedItems[0].Text, cash2);
                        AllItems.Add(weap);
                        break;
                    default: break;
                }
            }
            else
            {
                MessageBox.Show("Предмет не подходит по характеристикам!");
            }
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            if (ComboBoxHelmet.Text == ListItems.SelectedItem.ToString())
            {
                ComboBoxHelmet.Text = null;
            }
            if (ComboBoxArmor.Text == ListItems.SelectedItem.ToString())
            {
                ComboBoxArmor.Text = null;
            }
            if (ComboBoxWeapon.Text == ListItems.SelectedItem.ToString())
            {
                ComboBoxWeapon.Text = null;
            }
            for (int i = 0; i < ComboBoxHelmet.Items.Count; i++)
            {
                if (ComboBoxHelmet.Items[i].ToString() == ListItems.SelectedItem.ToString())
                {
                    ComboBoxHelmet.Items.Remove(ComboBoxHelmet.Items[i]);
                }
            }
            for (int i = 0; i < ComboBoxArmor.Items.Count; i++)
            {
                if (ComboBoxArmor.Items[i].ToString() == ListItems.SelectedItem.ToString())
                {
                    ComboBoxArmor.Items.Remove(ComboBoxArmor.Items[i]);
                }
            }
            for (int i = 0; i < ComboBoxWeapon.Items.Count; i++)
            {
                if (ComboBoxWeapon.Items[i].ToString() == ListItems.SelectedItem.ToString())
                {
                    ComboBoxWeapon.Items.Remove(ComboBoxWeapon.Items[i]);
                }
            }
            foreach (var i in AllItems.ToList())
            {
                if (i.ItemName == ListItems.SelectedItem.ToString())
                {
                    AllItems.Remove(i);
                }
            }
            ListItems.Items.Remove(ListItems.SelectedItem);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Items.Clear();
            if (ComboBoxHelmet.Text != "")
            {
                int cash = 0;
                for (int i = 0; i < lv_Shop.Items.Count; i++)
                {
                    if (lv_Shop.Items[i].Text == ComboBoxHelmet.Text)
                    {
                        cash = Convert.ToInt32(lv_Shop.Items[i].SubItems[8].Text);
                        if (lv_Shop.Items[i].SubItems[3].Text == "Воин")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Def += 10;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                HP += 30;
                                Def += 15;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                HP += 60;
                                Def += 40;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Убийца")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Def += 7;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                HP += 20;
                                Def += 10;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                HP += 50;
                                Def += 30;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Маг")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Def += 5;
                                MP += 30;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                HP += 10;
                                Def += 10;
                                MP += 60;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                HP += 20;
                                Def += 30;
                                MP += 100;
                            }
                        }
                    }
                }
                Helmet helmet = new Helmet(ComboBoxHelmet.Text, cash);
                helmet.HP = HP;
                helmet.MP = MP;
                helmet.Att = Att;
                helmet.MAtt = MAtt;
                helmet.Def = Def;
                Items.Add(helmet);
            }
            if (ComboBoxArmor.Text != "")
            {
                int cash = 0;
                for (int i = 0; i < lv_Shop.Items.Count; i++)
                {
                    if (lv_Shop.Items[i].Text == ComboBoxArmor.Text)
                    {
                        cash = Convert.ToInt32(lv_Shop.Items[i].SubItems[8].Text);
                        if (lv_Shop.Items[i].SubItems[3].Text == "Воин")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Def += 30;
                                HP += 30;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                HP += 60;
                                Def += 70;
                                Att += 20;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                HP += 100;
                                Def += 100;
                                Att += 40;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Убийца")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Def += 15;
                                HP += 15;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                HP += 30;
                                Def += 50;
                                Att += 10;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                HP += 75;
                                Def += 80;
                                Att += 25;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Маг")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Def += 10;
                                MP += 50;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                HP += 10;
                                Def += 15;
                                MP += 80;
                                MAtt += 35;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                HP += 20;
                                Def += 30;
                                MP += 100;
                                MAtt += 60;
                            }
                        }
                    }
                }
                Armor armor = new Armor(ComboBoxArmor.Text, cash);
                armor.HP = HP;
                armor.MP = MP;
                armor.Att = Att;
                armor.MAtt = MAtt;
                armor.Def = Def;
                Items.Add(armor);
            }
            if (ComboBoxWeapon.Text != "")
            {
                int cash = 0;
                for (int i = 0; i < lv_Shop.Items.Count; i++)
                {
                    if (lv_Shop.Items[i].Text == ComboBoxWeapon.Text)
                    {
                        cash = Convert.ToInt32(lv_Shop.Items[i].SubItems[8].Text);
                        if (lv_Shop.Items[i].SubItems[3].Text == "Воин")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Att += 15;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                Def += 20;
                                Att += 40;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                Def += 40;
                                Att += 100;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Убийца")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Att += 10;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                Att += 25;
                                Def += 5;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                Def += 30;
                                Att += 75;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Маг")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низкое")
                            {
                                Att += 10;
                                MP += 50;
                                MAtt += 20;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Среднее")
                            {
                                Att += 25;
                                MP += 100;
                                MAtt += 45;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высокое")
                            {
                                Att += 50;
                                MP += 200;
                                MAtt += 90;
                            }
                        }
                    }
                }
                Weapon weapon = new Weapon(ComboBoxWeapon.Text, cash);
                weapon.HP = HP;
                weapon.MP = MP;
                weapon.Att = Att;
                weapon.MAtt = MAtt;
                weapon.Def = Def;
                Items.Add(weapon);
            }
            this.Close();
        }
    }
}
