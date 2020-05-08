using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dependency_Chain_Tracker;
using Dependency_Chain_Tracker.Data;
using QuikGraph;



namespace Dependency_Chain_Tracker.Controllers
{
    using Dependency_Thread = AdjacencyGraph<Randomizer_Node, TaggedEdge<Randomizer_Node, string>>;

    public class Logic_Manager_Controller : Controller
    {

        #region SCAFFOLDING

        private readonly Dependency_Chain_TrackerContext _context;

        public Logic_Manager_Controller(Dependency_Chain_TrackerContext context)
        {
            _context = context;
        }

        // GET: Lock_And_Key
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lock_And_Key.ToListAsync());
        }

        // GET: Lock_And_Key/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lock_And_Key = await _context.Lock_And_Key
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lock_And_Key == null)
            {
                return NotFound();
            }

            return View(lock_And_Key);
        }

        // GET: Lock_And_Key/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lock_And_Key/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TotalCopies,InLogic,Sphere")] Randomizer_Node lock_And_Key)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lock_And_Key);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lock_And_Key);
        }

        // GET: Lock_And_Key/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lock_And_Key = await _context.Lock_And_Key.FindAsync(id);
            if (lock_And_Key == null)
            {
                return NotFound();
            }
            return View(lock_And_Key);
        }

        // POST: Lock_And_Key/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,TotalCopies,InLogic,Sphere")] Randomizer_Node lock_And_Key)
        {
            if (id != lock_And_Key.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lock_And_Key);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Lock_And_KeyExists(lock_And_Key.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lock_And_Key);
        }

        // GET: Lock_And_Key/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lock_And_Key = await _context.Lock_And_Key
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lock_And_Key == null)
            {
                return NotFound();
            }

            return View(lock_And_Key);
        }

        // POST: Lock_And_Key/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lock_And_Key = await _context.Lock_And_Key.FindAsync(id);
            _context.Lock_And_Key.Remove(lock_And_Key);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Lock_And_KeyExists(string id)
        {
            return _context.Lock_And_Key.Any(e => e.ID == id);
        }

        #endregion SCAFFOLDING

        //Reponsible for kicking off the startup sequence for a "run".
        //Calls FreshStart if it's an entirely new run, before then calling Load().
        //Need some way to differentiate between a file path for "fresh" stuff and "existing" stuff.  Maybe naming conventions?
        public void Start(string DIRECTORY_PATH)
        {
            bool isFreshStart = true;   //Add some way to determine if this is fresh or not.

            if (isFreshStart)
            { FreshStart(DIRECTORY_PATH); }  //Pass path of read-only directory for initial overhead

            Load(DIRECTORY_PATH);


        }

        //Book-keeping/overhead for initial generation of JSON files (ie, multiple copies of an item that need to be generated)
        public void FreshStart(string DIRECTORY_PATH)
        {


        }

        //Builds the initial list of graphs, and stores it in the session/persistant storage
        //First looks for serialized graph object to load from; will load from JSON files if it doesn't exist or fails.
        public void Load(string DIRECTORY_PATH)
        {
            var mainGraph = new Dependency_Thread();

            //The list of graphs which drives basically all the logic.
            //The graphs are made up of vertices of Lock_And_Key instances, which are the Items.
            List<Dependency_Thread> graphs = new List<Dependency_Thread>();

            //Store list into session or some other form of persistant storage

            //look for serialized graph object.  If found, attempt to load from that.  If not found or fails, build the graph from the JSON files.
            

            //Since the graph objects are ultimiately in charge of managing their Lock_And_Key items,
            //would it make sense for a wrapper class to "bake in" functions that handle it?

      

        }
    }

}
