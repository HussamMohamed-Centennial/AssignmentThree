using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class GiantPlanet : Planet ,IHasMoons,IHasRings
    {
        //PRIVATE INSTANCE VARIABLES 
        private string _type;

        //CONSTRUCTOR

        /// <summary>
        /// this is the constructor . it will take 4 arguments string name , double diameter and mass , string type.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass , string type) : base(name, diameter, mass)
        {
            _type = type;
        }

        //PRIVATE METHODS 


        //PUBLIC METHODS
        /// <summary>
        /// Hasmoons methods will check the moon count if it is more than zero it will return true.
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
        /// HasRings methods will check the rings count, if it is more than zero it will return true 
        /// </summary>
        /// <returns></returns>
        public bool HasRings()
        {
            if (RingCount > 0)
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
            output += "===Giant Planet============\n";
            output += $" Planet name   : {Name}\n ";
            output += $"Diameter is   : {Diameter} km\n";
            output += $" Mass is       : {Mass}\n ";
            output += $"Type is       : {_type}\n";
            
            if (HasMoons() == true)
            {
                output += $" Moons Count is: {MoonCount}\n";
            }

            if (HasRings() == true)
            {
                output += $" Rings Count is: {RingCount}\n";
            }

            

            output += "===========================\n";
            return output;
        }
    }
}
