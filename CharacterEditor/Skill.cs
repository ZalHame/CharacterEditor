using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    public class Skill
    {
        public string NameSkill { get; set; }
        public int LvlSkill { get; set; }

        public Skill (string nameSkill, int lvlSkill)
        {
            NameSkill = nameSkill;
            LvlSkill = lvlSkill;
        }
    }
}