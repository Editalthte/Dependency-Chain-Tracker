using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace Dependency_Chain_Tracker.Randomizer_Classes
{
    //A directional graph that keeps track of a single "logical thread" of dependent items
    using Dependency_Thread = AdjacencyGraph<Randomizer_Node, TaggedEdge<Randomizer_Node, string>>;

    /*
        A wrapper for the Dependency_Thread class.
        Responsible for:

        - Spinning up new threads
        - Merging threads
        - Cleaning up/deleting threads
        - Keeping threads up to date
        - Enforcing randomizer logic/ruleset when adding/removing items
     
         
    */
    public class Logic_Manager
    {

    }
}
