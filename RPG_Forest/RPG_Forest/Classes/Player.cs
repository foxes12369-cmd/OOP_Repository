using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forest.Classes
{
    public class Player : LivingEntity
    {
        private int hpMax;
        private bool protect;
        private int xp;
        private Weapon playerWeapon;
        private int gp;
        private Monster enemy;
        private List<Power> powerList;


        public Player()
        {
            this.playerWeapon = new Weapon();
        }

        public Player(string name, int hp) : base(name, hp)
        {
        }

        public override void Attack()
        {
            
        }

        public override void TakeDamage(int dmg)
        {
            if (this.protect == true)
            {
                dmg /= 2; //take hald dmg
                Console.WriteLine("Your protection decreased the Damage Taken by half!!!");


            }

            base.TakeDamage(dmg);
        }
        
        public void Heal()
        {

        }

        public void Hide()
        {
            Console.WriteLine("you are hiding and escape");
            //this.enemy = null;
        }

        public void SprinkeSleepingDust()
        {
            if(this.enemy != null && this.enemy is Dragon)
            {
                this.gp += (enemy as Dragon).rwg;
            }
        }

        public void AddPower(Power newPower)
        {
            powerList.Add(newPower);
            Console.WriteLine($"{this.name} now has the anility, {newPower.Name}");
        }
        public Power GetPower(PowerType powerType)
        {
            foreach(Power p  in powerList)
            {
                if(p.Type == powerType )
                {
                    return p;
                }
            }

            return null;
        }

        public void ApplyPower(PowerType pt)
        {
            Power p = GetPower(pt);
            //we can apply powertype INLY ONCE

            if(p != null)
            {
                if(this.xp >= p.MinXp)
                {
                    this.powerList.Remove(p); //remove pwr from list as it is no longer available to buy

                    switch(pt) 
                    {
                        case PowerType.Protect:
                            this.protect = true; 
                            break;
                        case PowerType.Healing:
                            this.Heal(); 
                            break;
                        case PowerType.Invisible:
                            this.Hide(); 
                            break;
                        case PowerType.Sleep:
                            this.SprinkeSleepingDust(); 
                            break;
                        default:
                            Console.WriteLine("Uknown Power: Power does noit exist"); 
                            break;      
                    }
                }
                else
                {
                    Console.WriteLine("not enough XP to aquire power");

                }
            }
            else
            {
                Console.WriteLine("Power unavailable");
            }
        }
        
        public void UpdateWeapon(Weapon w)
        {
            if(this.playerWeapon.MaxDmg <  w.MaxDmg)
            {
                this.playerWeapon = w;
            }
        }
        public void BuyItem(Item newitm)
        {
            if(this.gp >= newitm.PriceGp)
            {
                this.gp -= newitm.PriceGp;
                if(newitm is Weapon)
                {
                    this.UpdateWeapon(newitm as Weapon);
                }
                else if (newitm is Power) 
                {
                    //this.powerList.Add(newitm as Power);
                    this.powerList.Add((Power)newitm);
                }
            }
            else
            {
                Console.WriteLine("insufficient funds");
            }
        }
    }
}
