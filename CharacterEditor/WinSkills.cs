using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CharacterEditor
{
    public partial class WinSkills : Form
    {
        public WinSkills()
        {
            InitializeComponent();
        }

        public Skill qqskill = null;
        private void LogicSkillButton(string nameskill)
        {
            this.DialogResult = DialogResult.OK;
            Skill skill = new Skill(nameskill, 0);
            qqskill = skill;
            skill.LvlSkill++;
            this.Close();
        }
        private void SkillButtonBorrowedTime_Click(object sender, EventArgs e)
        {
            LogicSkillButton("Borrowed Time");
        }
        private void SkillButtonCoupdeGrace_Click(object sender, EventArgs e)
        {
            LogicSkillButton("Coup de Grace");
        }
        private void SkillButtonFingerofDeath_Click(object sender, EventArgs e)
        {
            LogicSkillButton("Finger of Death");
        }
    }
}