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
        public Skill skill = null;
        public WinSkills()
        {
            InitializeComponent();
        }
        private void SkillButtonBorrowedTime_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            BorrowedTime borrowedTime = new BorrowedTime();
            skill = borrowedTime;
            skill.LvlSkill++;
            this.Close();
        }
        private void SkillButtonCoupdeGrace_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            CoupdeGrace coupdeGrace = new CoupdeGrace();
            skill = coupdeGrace;
            skill.LvlSkill++;
            this.Close();
        }
        private void SkillButtonFingerofDeath_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            FingerofDeath fingerofDeath = new FingerofDeath();
            skill = fingerofDeath;
            skill.LvlSkill++;
            this.Close();
        }
    }
}