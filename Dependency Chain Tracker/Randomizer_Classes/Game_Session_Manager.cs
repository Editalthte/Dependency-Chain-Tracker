using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Chain_Tracker.Randomizer_Classes
{
    /*
        Responsible for managing any given game session or "run".
        Includes functions such as:

        - Saving
        - Loading
        - Performing first-time setup/initialization         
    */
    public class Game_Session_Manager
    {
        #region Data_Members

        //holds the current working directory for the game session
        private string session_directory_path;
        /*
            TODO:   Need to decide on "default" directory structure and naming conventions
        */

        #endregion Data_Members




        #region Methods

        //Determines if the current "run" to be loaded is pre-existing or not
        public bool isFreshStart()
        {
            throw new NotImplementedException();
        }


        /*
            If the current "run" is entirely new, this function needs to be called.
            Responsible for creating a new save directory, generating multi-copy nodes, etc.
        */
        public void initializeNewSession()
        {
            throw new NotImplementedException();
        }

        //Loads all required data from files into memory/objects
        //ie, graphs, dictionaries, etc.
        public void load()
        {
            throw new NotImplementedException();
        }


        //Saves the current run state to local files
        public void save()
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}
