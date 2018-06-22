using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface Skill
    {
        List<String> prereqs { get; set; }
        int pointsAssigned { get; set; }
        int adequacyVal { get; set; }
        int value { get; set; }
        string description { get; set; }
    }
}
