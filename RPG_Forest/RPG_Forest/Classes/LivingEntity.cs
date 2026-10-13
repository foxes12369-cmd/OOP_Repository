using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Forest.Interfaces;

namespace RPG_Forest.Classes
{
    public abstract class LivingEntity : ILivingEntity
    {
        protected string name;
        protected int hp;

        protected LivingEntity()
        {
            hp = 0;
            name = "Unnamed Entity";
        }

        protected LivingEntity(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        protected string Name { get => name; set => name = value; }
        protected int Hp { get => hp; set => hp = value; }

        public abstract void Attack();


        public bool IsDead()
        {
            return this.Hp < 1;
        }

        public virtual void TakeDamage(int dmg)
        {
            this.hp -= dmg;
            
            if(IsDead())
            {
                Console.WriteLine($"{this.name} Was Defeated!");
            }
            else
            {
                Console.WriteLine($"{this.name} took {dmg} Damage! \n" +
                    $"Remaing HP: {this.hp}");
            }
        }
    }
}
