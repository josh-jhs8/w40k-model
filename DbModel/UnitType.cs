using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static List<UnitType> SeedUnitTypes()
        {
            var unitTypes = new List<UnitType>();

            foreach (var value in Enum.GetValues(typeof(UnitTypeEnum)))
            {
                var unitType = new UnitType { Name = Enum.GetName(typeof(UnitTypeEnum), value) };
                unitTypes.Add(unitType);
            }

            return unitTypes;
        }

    }
}
