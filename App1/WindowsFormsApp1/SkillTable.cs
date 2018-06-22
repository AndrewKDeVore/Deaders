using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SkillTable
    {
        List<TableSkill> table = new List<TableSkill>();
    }

    class TableSkill
    {
        static string name { get; set; }
        static string desc { get; set; }
        static List<string> prereqs { get; set; }
    }
}
