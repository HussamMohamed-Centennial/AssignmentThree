using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class TerrestrialPlanet : Planet , IHasMoons , IHabitable
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass , bool oxygen) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
