using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;


namespace Dependency_Chain_Tracker
{
    public class Randomizer_Node
    {
        public string category { get; set; }    //Item, Location, etc.
        public string name { get; set; }    //("Boomerang", "Forest_Temple_Entrance", etc.)

        public string ID { get; set; }  //Used if there are multiple copies of the same named item.  Eg, the Hookshot.
        public uint totalCopies { get; set; }   //How many total copies of the item are in the run.
                                                //Eg: Hookshot would be 2, while Strength_Upgrade would be 3

        //default constructor
        public Randomizer_Node()
        { }

        
    
    }
}
