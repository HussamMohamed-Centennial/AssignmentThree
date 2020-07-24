using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Program
    {
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        } 
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupitor" , 140.07 , 300 , "Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mercury", 4879.4,3877,true );
            Console.WriteLine(terrestrialPlanet.ToString());


            WaitForAnyKey();
        }
    }
}
