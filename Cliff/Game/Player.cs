using System;
using System.Collections.Generic;
using System.Text;

namespace cliff
{
    class Player
    {
        int level { get; set; }

        int hp_current { get; set; }
        int hp_max { get; set; }
        float hp_max_modifier { get; set; }

        int exp { get; set; }
        float exp_modifier { get; set; }

        int exp_Up { get; set; }
        float exp_Up_modifier { get; set; }

        List<int> slots;

        int attack { get; set; }
        float attack_modifier { get; set; }

        int defense { get; set; }
        float defense_modifier { get; set; }

        float critical_rate { get; set; }
        float critical_rate_modifier { get; set; }

        float critical_damage { get; set; }
        float critical_damage_modifier { get; set; }

        int speed { get; set; }
        float speed_modifier { get; set; }

        float speed_Gauge { get; set; }
        int priority { get; set; }

        public Player(int level, int hp_current, int hp_max, float hp_max_modifier, int exp, float exp_modifier, int exp_Up, float exp_Up_modifier,
            int attack, float attack_modifier, int defense, float defense_modifier, float critical_rate, float critical_rate_modifier,
            float critical_damage, float critical_damage_modifier, int speed, float speed_modifier, float speed_Gauge, int priority)
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
        }
    }
}
