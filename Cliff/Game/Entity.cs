using System;
using System.Collections.Generic;
using System.Text;

namespace Cliff
{
    class Entity
    {

        private int level;

        int hp_current;
        int hp_max;
        float hp_max_modifier;

        int exp;
        float exp_modifier;

        int exp_Up;
        float exp_Up_modifier;

        List<int> slots;

        int attack;
        float attack_modifier;

        int defense;
        float defense_modifier;

        float critical_rate;
        float critical_rate_modifier;

        float critical_damage;
        float critical_damage_modifier;

        int speed;
        float speed_modifier;

        float speed_Gauge;
        int priority;


        int power;

        int knowledge;

        int agility;


        public int Level { get => level; set => level = value; }
        public int Hp_current { get => hp_current; set => hp_current = value; }
        public int Hp_max { get => hp_max; set => hp_max = value; }
        public float Hp_max_modifier { get => hp_max_modifier; set => hp_max_modifier = value; }
        public int Exp { get => exp; set => exp = value; }
        public float Exp_modifier { get => exp_modifier; set => exp_modifier = value; }
        public int Exp_Up { get => exp_Up; set => exp_Up = value; }
        public float Exp_Up_modifier { get => exp_Up_modifier; set => exp_Up_modifier = value; }
        public List<int> Slots { get => slots; set => slots = value; }
        public int Attack { get => attack; set => attack = value; }
        public float Attack_modifier { get => attack_modifier; set => attack_modifier = value; }
        public int Defense { get => defense; set => defense = value; }
        public float Defense_modifier { get => defense_modifier; set => defense_modifier = value; }
        public float Critical_rate { get => critical_rate; set => critical_rate = value; }
        public float Critical_rate_modifier { get => critical_rate_modifier; set => critical_rate_modifier = value; }
        public float Critical_damage { get => critical_damage; set => critical_damage = value; }
        public float Critical_damage_modifier { get => critical_damage_modifier; set => critical_damage_modifier = value; }
        public int Speed { get => speed; set => speed = value; }
        public float Speed_modifier { get => speed_modifier; set => speed_modifier = value; }
        public float Speed_Gauge { get => speed_Gauge; set => speed_Gauge = value; }
        public int Priority { get => priority; set => priority = value; }
        public int Power { get => power; set => power = value; }
        public int Knowledge { get => knowledge; set => knowledge = value; }
        public int Agility { get => agility; set => agility = value; }


        public Entity(int level = 1, int hp_current = 50, int hp_max = 100, float hp_max_modifier = 0, int exp = 0, float exp_modifier = 0, int exp_Up = 1920, float exp_Up_modifier = 0,
            int attack = 10, float attack_modifier = 0, int defense = 15, float defense_modifier = 0, float critical_rate = 5, float critical_rate_modifier = 0,
            float critical_damage = 0, float critical_damage_modifier = 0, int speed = 0, float speed_modifier = 0, float speed_Gauge = 0, int priority = 0, int power = 10, int knowledge = 10, int agility = 10)
        {
            this.level = level;
            this.hp_current = hp_current;
            this.hp_max = hp_max;
            this.hp_max_modifier = hp_max_modifier;
            this.exp = exp;
            this.exp_modifier = exp_modifier;
            this.exp_Up = exp_Up;
            this.exp_Up_modifier = exp_Up_modifier;
            this.slots = new List<int>();
            this.attack = attack;
            this.attack_modifier = attack_modifier;
            this.defense = defense;
            this.defense_modifier = defense_modifier;
            this.critical_rate = critical_rate;
            this.critical_rate_modifier = critical_rate_modifier;
            this.critical_damage = critical_damage;
            this.critical_damage_modifier = critical_damage_modifier;
            this.speed = speed;
            this.speed_modifier = speed_modifier;
            this.speed_Gauge = speed_Gauge;
            this.priority = priority;
            this.power = power;
            this.knowledge = knowledge;
            this.agility = agility;
        }


        int Next_Exp_Up()
        {
            return (int)(this.Exp_Up * Math.Pow(this.Exp_Up, 1.05f));
        }

        public void UpdateHealth(int amount)
        {
            this.Hp_current += amount;
        }
    }
}
