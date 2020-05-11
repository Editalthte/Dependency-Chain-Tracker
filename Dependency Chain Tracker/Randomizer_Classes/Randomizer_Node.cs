using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;


namespace Dependency_Chain_Tracker
{
    public struct Randomizer_Node
    {
        private readonly string category { get; }    //Item, Location, etc.
        private readonly string name { get; }    //("Boomerang", "Forest_Temple_Entrance", etc.)

        //Differentiates multiple copies of the same named item.  Eg, the Hookshot.
        //Of type "string" to allow for non-numeric IDs, should the need arise.
        private readonly string ID { get; }

        
        private readonly string key { get; }    //the key is used to quickly cross-reference between dictionary and graph entries

        private readonly uint totalCopies { get; }   //How many total copies of the item are in the run.
                                                //Eg: Hookshot would be 2, while Strength_Upgrade would be 3

        //default constructor
        public Randomizer_Node(string INIT_CATEGORY, string INIT_NAME, string INIT_ID, uint INIT_TOTAL_COPIES)
        {
            category = INIT_CATEGORY;
            name = INIT_NAME;
            ID = INIT_ID;
            totalCopies = INIT_TOTAL_COPIES;
            key = name + ID;
        }

        
    
    }

    
}
