using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_PD_Tasks.BL
{
    internal class Stats
    {
        public string SkillName;
        public float Damage;
        public string description;
        public float penetration;
        public float Cost;
        public float heal;
        public Stats(string SkillName, float Damage, float penetration, float heal, float Cost, string description)
        {
            this.SkillName = SkillName;
            this.Damage = Damage;
            this.penetration = penetration;
            this.heal = heal;
            this.Cost = Cost;
            this.description = description;
        }
        public Stats()
        {

        }
    }
}
