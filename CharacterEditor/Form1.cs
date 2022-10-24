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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListChar.Items.Clear();
            foreach (var item in MongoDB.FindAll())
            {
                ListChar.Items.Add(item.Name);
            }
        }

        private void ListChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxNickname.Text = ListChar.Text;
            EditChar(TextBoxNickname.Text);
        }
        private void EditChar(string name)
        {
            var one = MongoDB.Find(name);

            ComboBoxClass.Text = one?.GetType().Name;
            LabelStr.Text = one?.Str.ToString();
            LabelDex.Text = one?.Dex.ToString();
            LabelCons.Text = one?.Cons.ToString();
            LabelInt.Text = one?.Int.ToString();
            LabelHP.Text = one?.HP.ToString();
            LabelMP.Text = one?.MP.ToString();
            LabelAtt.Text = one?.Att.ToString();
            LabelMAtt.Text = one?.MAtt.ToString();
            LabelDef.Text = one?.Def.ToString();
            LabelSkillPoint.Text = one?.SkillPoint.ToString();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (MongoDB.Find(TextBoxNickname.Text) == null)
            {
                if (TextBoxNickname.Text != "")
                {
                    switch (ComboBoxClass.Text)
                    {
                        case "Warrior":
                            Warrior warrior = new Warrior();
                            CreatChar(warrior);
                            MongoDB.AddToDB(warrior);
                            MessageBox.Show(MongoDB.Find(TextBoxNickname.Text).ToString());
                            break;
                        case "Rogue":
                            Rogue rogue = new Rogue();
                            CreatChar(rogue);
                            MongoDB.AddToDB(rogue);
                            MessageBox.Show(MongoDB.Find(TextBoxNickname.Text).ToString());
                            break;
                        case "Wizard":
                            Wizard wizard = new Wizard();
                            CreatChar(wizard);
                            MongoDB.AddToDB(wizard);
                            MessageBox.Show(MongoDB.Find(TextBoxNickname.Text).ToString());
                            break;
                    }
                    TextBoxNickname.Text = "";
                    ComboBoxClass.SelectedIndex = 1;
                    ComboBoxClass.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Ведите имя персонажа");
                }
            }
            else
            {
                MessageBox.Show("Имя персонажа занято");
            }
        }

        private void CreatChar(Unit unit)
        {
            unit.Str = int.Parse(LabelStr.Text);
            unit.Dex = int.Parse(LabelDex.Text);
            unit.Cons = int.Parse(LabelCons.Text);
            unit.Int = int.Parse(LabelInt.Text);
            unit.HP = double.Parse(LabelHP.Text);
            unit.MP = double.Parse(LabelMP.Text);
            unit.Att = double.Parse(LabelAtt.Text);
            unit.MAtt = double.Parse(LabelMAtt.Text);
            unit.Def = double.Parse(LabelDef.Text);
            unit.SkillPoint = int.Parse(LabelSkillPoint.Text);
            unit.Name = TextBoxNickname.Text;
            ListChar.Items.Add(unit.Name);
        }

        private void ComboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    Value(warrior);
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    Value(rogue);
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    Value(wizard);
                    break;
            }
        }

        private void Value(Unit unit)
        {
            LabelStr.Text = Unit.MinStr.ToString();
            LabelDex.Text = Unit.MinDex.ToString();
            LabelCons.Text = Unit.MinCons.ToString();
            LabelInt.Text = Unit.MinInt.ToString();
            LabelHP.Text = unit.HP.ToString();
            LabelMP.Text = unit.MP.ToString();
            LabelAtt.Text = unit.Att.ToString();
            LabelMAtt.Text = unit.MAtt.ToString();
            LabelDef.Text = unit.Def.ToString();
            LabelSkillPoint.Text = unit.SkillPoint.ToString();
        }
        //---------------------------------
        private void ButtonStrMinus_Click(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    warrior.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    warrior.Str = int.Parse(LabelStr.Text);
                    warrior.Att = double.Parse(LabelAtt.Text);
                    warrior.HP = double.Parse(LabelHP.Text);
                    if (Warrior.MinStr < int.Parse(LabelStr.Text))
                    {
                        LabelStr.Text = (warrior.Str - 1).ToString();
                        LabelSkillPoint.Text = (warrior.SkillPoint + 1).ToString();
                        warrior.changeStrMinus(warrior);
                        LabelAtt.Text = warrior.Att.ToString();
                        LabelHP.Text = warrior.HP.ToString();
                    }
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    rogue.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    rogue.Str = int.Parse(LabelStr.Text);
                    rogue.Att = double.Parse(LabelAtt.Text);
                    rogue.HP = double.Parse(LabelHP.Text);
                    if (Warrior.MinStr < int.Parse(LabelStr.Text))
                    {
                        LabelStr.Text = (rogue.Str - 1).ToString();
                        LabelSkillPoint.Text = (rogue.SkillPoint + 1).ToString();
                        rogue.changeStrMinus(rogue);
                        LabelAtt.Text = rogue.Att.ToString();
                        LabelHP.Text = rogue.HP.ToString();
                    }
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    wizard.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    wizard.Str = int.Parse(LabelStr.Text);
                    wizard.Att = double.Parse(LabelAtt.Text);
                    wizard.HP = double.Parse(LabelHP.Text);
                    if (Warrior.MinStr < int.Parse(LabelStr.Text))
                    {
                        LabelStr.Text = (wizard.Str - 1).ToString();
                        LabelSkillPoint.Text = (wizard.SkillPoint + 1).ToString();
                        wizard.changeStrMinus(wizard);
                        LabelAtt.Text = wizard.Att.ToString();
                        LabelHP.Text = wizard.HP.ToString();
                    }
                    break;
            }
        }
        private void ButtonStrPlus_Click(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    warrior.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    warrior.Str = int.Parse(LabelStr.Text);
                    warrior.Att = double.Parse(LabelAtt.Text);
                    warrior.HP = double.Parse(LabelHP.Text);
                    if ((Warrior.MaxStr > int.Parse(LabelStr.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelStr.Text = (warrior.Str + 1).ToString();
                        LabelSkillPoint.Text = (warrior.SkillPoint - 1).ToString();
                        warrior.changeStrPlus(warrior);
                        LabelAtt.Text = warrior.Att.ToString();
                        LabelHP.Text = warrior.HP.ToString();
                    }
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    rogue.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    rogue.Str = int.Parse(LabelStr.Text);
                    rogue.Att = double.Parse(LabelAtt.Text);
                    rogue.HP = double.Parse(LabelHP.Text);
                    if ((Warrior.MaxStr > int.Parse(LabelStr.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelStr.Text = (rogue.Str + 1).ToString();
                        LabelSkillPoint.Text = (rogue.SkillPoint - 1).ToString();
                        rogue.changeStrPlus(rogue);
                        LabelAtt.Text = rogue.Att.ToString();
                        LabelHP.Text = rogue.HP.ToString();
                    }
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    wizard.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    wizard.Str = int.Parse(LabelStr.Text);
                    wizard.Att = double.Parse(LabelAtt.Text);
                    wizard.HP = double.Parse(LabelHP.Text);
                    if ((Warrior.MaxStr > int.Parse(LabelStr.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelStr.Text = (wizard.Str + 1).ToString();
                        LabelSkillPoint.Text = (wizard.SkillPoint - 1).ToString();
                        wizard.changeStrPlus(wizard);
                        LabelAtt.Text = wizard.Att.ToString();
                        LabelHP.Text = wizard.HP.ToString();
                    }
                    break;
            }
        }
        //-------------------------------------
        private void ButtonDexMinus_Click(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    warrior.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    warrior.Dex = int.Parse(LabelDex.Text);
                    warrior.Att = double.Parse(LabelAtt.Text);
                    warrior.Def = double.Parse(LabelDef.Text);
                    if (Warrior.MinDex < int.Parse(LabelDex.Text))
                    {
                        LabelDex.Text = (warrior.Dex - 1).ToString();
                        LabelSkillPoint.Text = (warrior.SkillPoint + 1).ToString();
                        warrior.changeDexMinus(warrior);
                        LabelAtt.Text = warrior.Att.ToString();
                        LabelDef.Text = warrior.Def.ToString();
                    }
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    rogue.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    rogue.Dex = int.Parse(LabelDex.Text);
                    rogue.Att = double.Parse(LabelAtt.Text);
                    rogue.Def = double.Parse(LabelDef.Text);
                    if (Warrior.MinDex < int.Parse(LabelDex.Text))
                    {
                        LabelDex.Text = (rogue.Dex - 1).ToString();
                        LabelSkillPoint.Text = (rogue.SkillPoint + 1).ToString();
                        rogue.changeDexMinus(rogue);
                        LabelAtt.Text = rogue.Att.ToString();
                        LabelDef.Text = rogue.Def.ToString();
                    }
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    wizard.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    wizard.Dex = int.Parse(LabelDex.Text);
                    wizard.Def = double.Parse(LabelDef.Text);
                    if (Warrior.MinDex < int.Parse(LabelDex.Text))
                    {
                        LabelDex.Text = (wizard.Dex - 1).ToString();
                        LabelSkillPoint.Text = (wizard.SkillPoint + 1).ToString();
                        wizard.changeDexMinus(wizard);
                        LabelDef.Text = wizard.Def.ToString();
                    }
                    break;
            }
        }
        private void ButtonDexPlus_Click(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    warrior.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    warrior.Dex = int.Parse(LabelDex.Text);
                    warrior.Att = double.Parse(LabelAtt.Text);
                    warrior.Def = double.Parse(LabelDef.Text);
                    if ((Warrior.MaxDex > int.Parse(LabelDex.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelDex.Text = (warrior.Dex + 1).ToString();
                        LabelSkillPoint.Text = (warrior.SkillPoint - 1).ToString();
                        warrior.changeDexPlus(warrior);
                        LabelAtt.Text = warrior.Att.ToString();
                        LabelDef.Text = warrior.Def.ToString();
                    }
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    rogue.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    rogue.Dex = int.Parse(LabelDex.Text);
                    rogue.Att = double.Parse(LabelAtt.Text);
                    rogue.Def = double.Parse(LabelDef.Text);
                    if ((Warrior.MaxDex > int.Parse(LabelDex.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelDex.Text = (rogue.Dex + 1).ToString();
                        LabelSkillPoint.Text = (rogue.SkillPoint - 1).ToString();
                        rogue.changeDexPlus(rogue);
                        LabelAtt.Text = rogue.Att.ToString();
                        LabelDef.Text = rogue.Def.ToString();
                    }
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    wizard.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    wizard.Dex = int.Parse(LabelDex.Text);
                    wizard.Def = double.Parse(LabelDef.Text);
                    if ((Warrior.MaxDex > int.Parse(LabelDex.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelDex.Text = (wizard.Dex + 1).ToString();
                        LabelSkillPoint.Text = (wizard.SkillPoint - 1).ToString();
                        wizard.changeDexPlus(wizard);
                        LabelDef.Text = wizard.Def.ToString();
                    }
                    break;
            }
        }
        //----------------------------------
        private void ButtonConsMinus_Click(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    warrior.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    warrior.Cons = int.Parse(LabelCons.Text);
                    warrior.HP = double.Parse(LabelHP.Text);
                    warrior.Def = double.Parse(LabelDef.Text);
                    if (Warrior.MinCons < int.Parse(LabelCons.Text))
                    {
                        LabelCons.Text = (warrior.Cons - 1).ToString();
                        LabelSkillPoint.Text = (warrior.SkillPoint + 1).ToString();
                        warrior.changeConsMinus(warrior);
                        LabelHP.Text = warrior.HP.ToString();
                        LabelDef.Text = warrior.Def.ToString();
                    }
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    rogue.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    rogue.Cons = int.Parse(LabelCons.Text);
                    rogue.HP = double.Parse(LabelHP.Text);
                    if (Warrior.MinCons < int.Parse(LabelCons.Text))
                    {
                        LabelCons.Text = (rogue.Cons - 1).ToString();
                        LabelSkillPoint.Text = (rogue.SkillPoint + 1).ToString();
                        rogue.changeConsMinus(rogue);
                        LabelHP.Text = rogue.HP.ToString();
                    }
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    wizard.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    wizard.Cons = int.Parse(LabelCons.Text);
                    wizard.HP = double.Parse(LabelHP.Text);
                    wizard.Def = double.Parse(LabelDef.Text);
                    if (Warrior.MinCons < int.Parse(LabelCons.Text))
                    {
                        LabelCons.Text = (wizard.Cons - 1).ToString();
                        LabelSkillPoint.Text = (wizard.SkillPoint + 1).ToString();
                        wizard.changeConsMinus(wizard);
                        LabelHP.Text = wizard.HP.ToString();
                        LabelDef.Text = wizard.Def.ToString();
                    }
                    break;
            }
        }
        private void ButtonConsPlus_Click(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    warrior.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    warrior.Cons = int.Parse(LabelCons.Text);
                    warrior.HP = double.Parse(LabelHP.Text);
                    warrior.Def = double.Parse(LabelDef.Text);
                    if ((Warrior.MaxCons > int.Parse(LabelCons.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelCons.Text = (warrior.Cons + 1).ToString();
                        LabelSkillPoint.Text = (warrior.SkillPoint - 1).ToString();
                        warrior.changeConsPlus(warrior);
                        LabelHP.Text = warrior.HP.ToString();
                        LabelDef.Text = warrior.Def.ToString();
                    }
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    rogue.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    rogue.Cons = int.Parse(LabelCons.Text);
                    rogue.HP = double.Parse(LabelHP.Text);
                    if ((Warrior.MaxCons > int.Parse(LabelCons.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelCons.Text = (rogue.Cons + 1).ToString();
                        LabelSkillPoint.Text = (rogue.SkillPoint - 1).ToString();
                        rogue.changeConsPlus(rogue);
                        LabelHP.Text = rogue.HP.ToString();
                    }
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    wizard.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    wizard.Cons = int.Parse(LabelCons.Text);
                    wizard.HP = double.Parse(LabelHP.Text);
                    wizard.Def = double.Parse(LabelDef.Text);
                    if ((Warrior.MaxCons > int.Parse(LabelCons.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelCons.Text = (wizard.Cons + 1).ToString();
                        LabelSkillPoint.Text = (wizard.SkillPoint - 1).ToString();
                        wizard.changeConsPlus(wizard);
                        LabelHP.Text = wizard.HP.ToString();
                        LabelDef.Text = wizard.Def.ToString();
                    }
                    break;
            }
        }
        //-------------------------------------
        private void ButtonIntMinus_Click(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    warrior.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    warrior.Int = int.Parse(LabelInt.Text);
                    warrior.MP = double.Parse(LabelMP.Text);
                    warrior.MAtt = double.Parse(LabelMAtt.Text);
                    if (Warrior.MinInt < int.Parse(LabelInt.Text))
                    {
                        LabelInt.Text = (warrior.Int - 1).ToString();
                        LabelSkillPoint.Text = (warrior.SkillPoint + 1).ToString();
                        warrior.changeIntMinus(warrior);
                        LabelMP.Text = warrior.MP.ToString();
                        LabelMAtt.Text = warrior.MAtt.ToString();
                    }
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    rogue.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    rogue.Int = int.Parse(LabelInt.Text);
                    rogue.MP = double.Parse(LabelMP.Text);
                    rogue.MAtt = double.Parse(LabelMAtt.Text);
                    if (Warrior.MinInt < int.Parse(LabelInt.Text))
                    {
                        LabelInt.Text = (rogue.Int - 1).ToString();
                        LabelSkillPoint.Text = (rogue.SkillPoint + 1).ToString();
                        rogue.changeIntMinus(rogue);
                        LabelMP.Text = rogue.MP.ToString();
                        LabelMAtt.Text = rogue.MAtt.ToString();
                    }
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    wizard.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    wizard.Int = int.Parse(LabelInt.Text);
                    wizard.MP = double.Parse(LabelMP.Text);
                    wizard.MAtt = double.Parse(LabelMAtt.Text);
                    if (Warrior.MinInt < int.Parse(LabelInt.Text))
                    {
                        LabelInt.Text = (wizard.Int - 1).ToString();
                        LabelSkillPoint.Text = (wizard.SkillPoint + 1).ToString();
                        wizard.changeIntMinus(wizard);
                        LabelMP.Text = wizard.MP.ToString();
                        LabelMAtt.Text = wizard.MAtt.ToString();
                    }
                    break;
            }
        }
        private void ButtonIntPlus_Click(object sender, EventArgs e)
        {
            switch (ComboBoxClass.Text)
            {
                case "Warrior":
                    Warrior warrior = new Warrior();
                    warrior.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    warrior.Int = int.Parse(LabelInt.Text);
                    warrior.MP = double.Parse(LabelMP.Text);
                    warrior.MAtt = double.Parse(LabelMAtt.Text);
                    if ((Warrior.MaxInt > int.Parse(LabelInt.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelInt.Text = (warrior.Int + 1).ToString();
                        LabelSkillPoint.Text = (warrior.SkillPoint - 1).ToString();
                        warrior.changeIntPlus(warrior);
                        LabelMP.Text = warrior.MP.ToString();
                        LabelMAtt.Text = warrior.MAtt.ToString();
                    }
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    rogue.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    rogue.Int = int.Parse(LabelInt.Text);
                    rogue.MP = double.Parse(LabelMP.Text);
                    rogue.MAtt = double.Parse(LabelMAtt.Text);
                    if ((Warrior.MaxInt > int.Parse(LabelInt.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelInt.Text = (rogue.Int + 1).ToString();
                        LabelSkillPoint.Text = (rogue.SkillPoint - 1).ToString();
                        rogue.changeIntPlus(rogue);
                        LabelMP.Text = rogue.MP.ToString();
                        LabelMAtt.Text = rogue.MAtt.ToString();
                    }
                    break;
                case "Wizard":
                    Wizard wizard = new Wizard();
                    wizard.SkillPoint = int.Parse(LabelSkillPoint.Text);
                    wizard.Int = int.Parse(LabelInt.Text);
                    wizard.MP = double.Parse(LabelMP.Text);
                    wizard.MAtt = double.Parse(LabelMAtt.Text);
                    if ((Warrior.MaxInt > int.Parse(LabelInt.Text)) &&
                        (int.Parse(LabelSkillPoint.Text) > 0))
                    {
                        LabelInt.Text = (wizard.Int + 1).ToString();
                        LabelSkillPoint.Text = (wizard.SkillPoint - 1).ToString();
                        wizard.changeIntPlus(wizard);
                        LabelMP.Text = wizard.MP.ToString();
                        LabelMAtt.Text = wizard.MAtt.ToString();
                    }
                    break;
            }
        }
    }
}