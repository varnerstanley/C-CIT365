using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MyScriptureJournal.Pages.MyJournal
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntry { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string BookTitle { get; set; }


        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        
       


        // public string MovieGenre { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {

            BookSort = String.IsNullOrEmpty(sortOrder) ? "Book" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<JournalEntry> entries = from s in _context.JournalEntry
                                             select s;


            switch (sortOrder)
            {
                case "Book":
                    entries = entries.OrderBy(s => s.Book);
                    break;
                case "Date":
                    entries = entries.OrderBy(s => s.EntryDate);
                    break;

                default:
                    entries = entries.OrderBy(s => s.Notes);
                    break;
            }

          //  JournalEntry = await entries.ToListAsync();


            // Use LINQ to get list of genres.
            IQueryable<string> bookQuery = from b in _context.JournalEntry
                                            orderby b.Book
                                            select b.Book;

           // var Entries = from b in _context.JournalEntry
                   // select b;

            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Notes.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(BookTitle))
            {
                entries = entries.Where(x => x.Book == BookTitle);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            JournalEntry = await entries.ToListAsync();

            //JournalEntry = await _context.JournalEntry.ToListAsync();

            
        }
    }
}
