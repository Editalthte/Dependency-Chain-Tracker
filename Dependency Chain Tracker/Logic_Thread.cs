using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuikGraph;

namespace Dependency_Chain_Tracker
{
    using DependencyGraph = AdjacencyGraph<Lock_And_Key, TaggedEdge<Lock_And_Key, string>>;

    public class Logic_Thread
    {
        /*
            >The ID used to keep tabs on any particular logic thread.
            Will have "main" which contains all in-logic items,
            and all other threads will track their respective out-of-logic chains.

            >Non-main threads should probably be named (its ID) based on the out-of-logic item
            that kicked off that thread in the first place.
        */
        public string ID {  get; set;   }  

        /*
            Keeps tabs on if the thread is in logic or not.  Probably not super useful,
            since by definition all in-logic items are captured in the "main" thread.
            Might end up axing this attribute, keeping it for now just to see if we find a use for it later.
            Maybe as a sanity check?
        */
        public bool In_Logic {  get; set;   }

        /*
            Other attributes to consider adding:
            
            > A list of some kind that keeps track of child/parent threads
            

        */

        /*
            >The adjacency graph of items (Lock_And_Key) where the actual dependencies are stored.
            
            >Should be a directional adjacency graph, not sure if that's a specific class already implemented,
            or if that's just inherent in the type of connections made between the nodes.
            If the latter, need some kind of logic to ensure no circular connections are possible.
            
            >I'm not thrilled with the name, but not entirely sure what it should be instead.
        */
        public DependencyGraph graph {   get; set;   }

        /*{
            Name:   addItem()

            Description:    Adds the provided object to the graph.

            FLOW (WIP):     >Ingest and identify key parameters:
                                The object being added
                                The parent that the object belongs to

                            >Add object to the graph, with respect to its parent and direction

            Questions to be answered:   If the object is being auto-added (eg: because it's now in-logic),
                                        How is the "old" one handled?  Is that done here, or somewhere else?
                                        I want to say that sounds like a Controller's responsibility,
                                        but I'm not 100% sure.
        }*/
        public void addItem(/*Add parameters*/)
        {
            throw new NotImplementedException();
        }

        /*{
            Name:   removeItem()

            Description:    Removes/Deletes the referenced object

            FLOW (WIP):     >Ingest and identify key parameters:
                                The object being removed (Probably by the object's ID?)

                            >Identify if the object has children.
                                If so, this needs to be handled in some way.
                                    Failure?  Cascade?  Case-by-case?

                            >Remove the object from the graph,
                                AND its corresponding connecting edges


            Questions to be answered:   If the item is being moved from one graph to another,
                                        (eg, it's now in-logic) is there anything special that has
                                        to be done here to account for that?
                                        I can't think of anything off the top of my head,
                                        but something to keep in mind.
        }*/
        public void removeItem(/*Add parameters*/)
        {
            throw new NotImplementedException();           
        }

    }
}