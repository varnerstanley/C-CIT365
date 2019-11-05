using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        //Gets or sets id, title, notes, book and entry date used for the database entry.

        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Required]
        public string Notes { get; set; }

        [Required]
        public string Book { get; set; }

        [Display(Name = "Journal Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

    }

}
