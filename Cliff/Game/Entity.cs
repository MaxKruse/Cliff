using System;
using System.Collections.Generic;
using System.Text;

namespace Cliff
{
    class Entity
    {

        public int Level { get; set; }
        public int Hp_current { get; set; }
        public int Hp_max { get; set; }
        public float Hp_max_modifier { get; set; }
        public int Exp { get; set; }
        public float Exp_modifier { get; set; }
        public int Exp_Up { get; set; }
        public float Exp_Up_modifier { get; set; }
        public List<int> Slots { get; set; }
        public int Attack { get; set; }
        public float Attack_modifier { get; set; }
        public int Defense { get; set; }
        public float Defense_modifier { get; set; }
        public float Critical_rate { get; set; }
        public float Critical_rate_modifier { get; set; }
        public float Critical_damage { get; set; }
        public float Critical_damage_modifier { get; set; }
        public int Speed { get; set; }
        public float Speed_modifier { get; set; }
        public float Speed_Gauge { get; set; }
        public int Priority { get; set; }
        public int Power { get; set; }
        public int Knowledge { get; set; }
        public int Agility { get; set; }
        private EntityManager Parent { get; set; }

        public Entity( EntityManager parent, int level, int hp_current, int hp_max, float hp_max_modifier, int exp, float exp_modifier, int exp_Up, float exp_Up_modifier,
            int attack, float attack_modifier, int defense, float defense_modifier, float critical_rate, float critical_rate_modifier,
            float critical_damage, float critical_damage_modifier, int speed, float speed_modifier, float speed_Gauge, int priority, int power, int knowledge, int agility)
        {
            GearSlotManager Slots = new GearSlotManager();

            this.Level = level;
            this.Hp_current = hp_current;
            this.Hp_max = Hp_max;
            this.Hp_max_modifier = Hp_max_modifier;
            this.Exp = exp;
            this.Exp_modifier = exp_modifier;
            this.Exp_Up = exp_Up;
            this.Exp_Up_modifier = exp_Up_modifier;
            
            Slots.CreateDefault();

            this.Attack = attack;
            this.Attack_modifier = attack_modifier;
            this.Defense = defense;
            this.Defense_modifier = defense_modifier;
            this.Critical_rate = critical_rate;
            this.Critical_rate_modifier = critical_rate_modifier;
            this.Critical_damage = critical_damage;
            this.Critical_damage_modifier = critical_damage_modifier;
            this.Speed = speed;
            this.Speed_modifier = speed_modifier;
            this.Speed_Gauge = speed_Gauge;
            this.Priority = priority;
            this.Power = power;
            this.Knowledge = knowledge;
            this.Agility = agility;

            this.Parent = parent;
        }


        int NextExpUp()
        {
            return (int)( (this.Level * ((Math.Pow(1.05, this.Level)) / Math.PI) + 100) * Math.Pow(Math.PI, 2));
        }

        public void UpdateHealth(int amount)
        {
            this.Hp_current += amount;
        }

        void Level_Up(){
            int NEXT = NextExpUp();

            //Doing the actual Levelup
            if(this.Exp > NEXT){
                this.Exp -= NEXT;

                this.Level++;

                //Increase all Stats except Crit-Related by 10

                
            }
        }


    }
}
