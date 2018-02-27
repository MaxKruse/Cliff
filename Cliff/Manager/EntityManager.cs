using System;
using System.Collections.Generic;

namespace Cliff{
    
    class EntityManager
    {
        internal List<Entity> EntityList { get; set; }
        public EntityManager()
        {
            this.EntityList = new List<Entity>();
        }

        public Entity CreateCharacter(int level = 1, int hp_current = 50, int hp_max = 100, float hp_max_modifier = 0,
            int exp = 0, float exp_modifier = 0, int exp_Up = 1920, float exp_Up_modifier = 0,
            int attack = 10, float attack_modifier = 0, int defense = 15, float defense_modifier = 0,
            float critical_rate = 5, float critical_rate_modifier = 0, float critical_damage = 0, float critical_damage_modifier = 0,
            int speed = 0, float speed_modifier = 0, float speed_Gauge = 0, int priority = 0, int power = 10, int knowledge = 10, int agility = 10)
            {

            Entity c = new Entity(this, level, hp_current, hp_max, hp_max_modifier, exp, exp_modifier, exp_Up, exp_Up_modifier, attack,
            attack_modifier, defense, defense_modifier, critical_rate, critical_rate_modifier,
            critical_damage, critical_damage_modifier, speed, speed_modifier, speed_Gauge, priority, power, knowledge, agility);

            this.EntityList.Add(c);

            return c;
        }

        
    }

}