using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forest.Interfaces
{
    public interface ILivingEntity
    {
        bool IsDead();
        void TakeDamage(int dmg);
        void Attack();

    }
}
