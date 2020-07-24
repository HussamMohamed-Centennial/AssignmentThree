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

        //CONSTRUCTOR

        /// <summary>
        /// This constructor will take 4 arguments, string name , double diameters and mass, bool oxygen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass , bool oxygen) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS

        /// <summary>
        /// HasMoons methods will check the mons counts, if it is more than 0 it will return true
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Habitable method will check oxygen value ,if it is true it will return true 
        /// </summary>
        /// <returns></returns>
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

        public override string ToString()
        {
            string output = String.Empty;
            output += "===Terrestrial Planet=======\n";
            output += $" Planet name   : {Name}\n ";
            output += $"Diameter is   : {Diameter} km\n";
            output += $" Mass is       : {Mass}\n ";
            
            if (HasMoons() == true)
            {
                output += $"Moons Count is: {MoonCount}\n";
            }

            if (Habitable() == true)
            {
                output += $"It is a habitable planet\n";
            }

            if (Habitable() == false)
            {
                output += "It is an uninhabitable Planet\n";
            }

            
            output += "============================\n";
            return output;
        }
    }
}
