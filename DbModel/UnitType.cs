using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModel
{
    public class UnitType : NameItem
    {
        public enum UnitTypeEnum
        {
            HQ,
            Troops,
            Elite,
            FastAttack,
            HeavySupport,
            LordOfWar
        }

    }
}
