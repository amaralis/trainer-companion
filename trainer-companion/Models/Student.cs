using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace trainer_companion.Models
{
    internal class Student
    {
        public int Id { get; set; } // Primary key for the Student entity
        public required string Name { get; set; }
        public virtual ObservableCollection<Note> Notes { get; private set; } = new ObservableCollection<Note>();
    }
}
