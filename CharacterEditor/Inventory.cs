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
        public double Damage = 0;
        public double Hp = 0;
        public double PhDef = 0;
        public double Mana = 0;
        public double MageAttack = 0;

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
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            if (Str >= Convert.ToInt32(lv_Shop.SelectedItems[0].SubItems[4].Text) && Dex >= Convert.ToInt32(lv_Shop.SelectedItems[0].SubItems[5].Text)
                && Cons >= Convert.ToInt32(lv_Shop.SelectedItems[0].SubItems[6].Text) && Int >= Convert.ToInt32(lv_Shop.SelectedItems[0].SubItems[7].Text))
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
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                PhDef += 10;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                Hp += 30;
                                PhDef += 15;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                Hp += 60;
                                PhDef += 40;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Разбойник")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                PhDef += 7;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                Hp += 20;
                                PhDef += 10;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                Hp += 50;
                                PhDef += 30;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Маг")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                PhDef += 5;
                                Mana += 30;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                Hp += 10;
                                PhDef += 10;
                                Mana += 60;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                Hp += 20;
                                PhDef += 30;
                                Mana += 100;
                            }
                        }
                    }
                }
                Helmet helmet = new Helmet(ComboBoxHelmet.Text, cash);
                helmet.Damage = Damage;
                helmet.Hp = Hp;
                helmet.PhDef = PhDef;
                helmet.Mana = Mana;
                helmet.MageAttack = MageAttack;
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
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                PhDef += 30;
                                Hp += 30;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                Hp += 60;
                                PhDef += 70;
                                Damage += 20;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                Hp += 100;
                                PhDef += 100;
                                Damage += 40;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Разбойник")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                PhDef += 15;
                                Hp += 15;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                Hp += 30;
                                PhDef += 50;
                                Damage += 10;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                Hp += 75;
                                PhDef += 80;
                                Damage += 25;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Маг")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                PhDef += 10;
                                Mana += 50;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                Hp += 10;
                                PhDef += 15;
                                Mana += 80;
                                MageAttack += 35;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                Hp += 20;
                                PhDef += 30;
                                Mana += 100;
                                MageAttack += 60;
                            }
                        }
                    }
                }
                Armor armor = new Armor(ComboBoxArmor.Text, cash);
                armor.Damage = Damage;
                armor.Hp = Hp;
                armor.PhDef = PhDef;
                armor.Mana = Mana;
                armor.MageAttack = MageAttack;
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
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                Damage += 15;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                PhDef += 20;
                                Damage += 40;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                PhDef += 40;
                                Damage += 100;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Разбойник")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                Damage += 10;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                Damage += 25;
                                PhDef += 5;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                PhDef += 30;
                                Damage += 75;
                            }
                        }
                        if (lv_Shop.Items[i].SubItems[3].Text == "Маг")
                        {
                            if (lv_Shop.Items[i].SubItems[2].Text == "Низк")
                            {
                                Damage += 10;
                                Mana += 50;
                                MageAttack += 20;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Средн")
                            {
                                Damage += 25;
                                Mana += 100;
                                MageAttack += 45;
                            }
                            if (lv_Shop.Items[i].SubItems[2].Text == "Высок")
                            {
                                Damage += 50;
                                Mana += 200;
                                MageAttack += 90;
                            }
                        }
                    }
                }
                Weapon weapon = new Weapon(ComboBoxWeapon.Text, cash);
                weapon.Damage = Damage;
                weapon.Hp = Hp;
                weapon.PhDef = PhDef;
                weapon.Mana = Mana;
                weapon.MageAttack = MageAttack;
                Items.Add(weapon);
            }
            this.Close();
        }
    }
}
