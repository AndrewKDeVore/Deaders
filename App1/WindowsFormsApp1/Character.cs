using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Character
    {
        public Boolean isKill;

        public int health { get; set; }
        public int Moves { get; set; }
        public int Strength { get; set; }
        public int Resiliency { get; set; }

        public int Age { get; set; }
        public int weight { get; set; }
        public int height { get; set; } //In inches

        public List<RadiationManipulation> RadManips { get; set; }

        public List<Skill> Skills { get; set; }

        public Character()
        {
            Moves = Dice.Roll(1, 12);
            Strength = 0;
            Resiliency = Dice.Roll(1, 6) + 3;

            height = Dice.Roll(6, 6) + 48;
            weight = height * weightGen();
            Tables.TableC2.Manipulate(this);

            RadManips = new List<RadiationManipulation>();
            Skills = new List<Skill>();
        }

        private int weightGen()
        {
            int det = Dice.Roll(5, 6);
            if(det < 7)
            {
                return 1;
            }
            if(det >= 7 && det < 18)
            {
                return 2;
            }
            if(det >= 18 && det < 25)
            {
                return 3;
            }
            if(det >= 25 && det < 28)
            {
                return 4;
            }
            return 5;
        }

        public void alterMoves(int change)
        {
            Moves += change;
        }

        public void alterStrength(int change)
        {
            Strength += change;
            checkDead();
        }

        public void alterResiliency(int change)
        {
            Resiliency += change;
        }

        public void checkDead()
        {
            if (health <= 0)
            {
                isKill = true;
            }
        }
        public Boolean isDead()
        {
            return isKill;
        }
    }
}
