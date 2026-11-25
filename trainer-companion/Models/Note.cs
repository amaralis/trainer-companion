using System;
using System.Collections.Generic;
using System.Text;

namespace trainer_companion.Models
{
    internal class Note
    {
        public int NoteId { get; set; } // <TypeName>Id is a common convention for primary keys in EF Core
        public int StudentId { get; set; } // Foreign key to the Student entity
        public virtual required Student Student { get; set; }
        public required string NoteContent { get; set; }
    }
}
