using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace trainer_companion.Models
{
    internal class Student
    {
        public int StudentId { get; set; } // <TypeName>Id is a common convention for primary keys in EF Core
        public required string StudentName { get; set; }
        public virtual ObservableCollection<Note> Notes { get; private set; } = new ObservableCollection<Note>();
    }
}
