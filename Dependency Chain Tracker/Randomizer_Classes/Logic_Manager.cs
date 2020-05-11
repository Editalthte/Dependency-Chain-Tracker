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
        //Note that this needs to be restructured, they're here for now more for organizing thought-process

        //The "Master List" of all dependency nodes (items, locations, etc.) used for a given run.
        Dictionary<string, Randomizer_Node> dependency_node_dictionary = new Dictionary<string, Randomizer_Node>();

        //initialize/load the node dictionary with all dependencies
        void initialize_node_dictionary()
        {   throw new NotImplementedException();    }

        //Contains all the "logic threads", both in-logic and out-of-logic
        Dictionary<Randomizer_Node, Dependency_Thread> dependency_thread_dictionary = new Dictionary<Randomizer_Node, Dependency_Thread>();
        
        //initialize the thread dictionary with the main objective (the "in-logic" thread)
        void initialize_thread_dictionary()
        {   throw new NotImplementedException();    }



    }
}
