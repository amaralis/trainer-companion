using System.Collections.ObjectModel;
using trainer_companion.Models;
using trainer_companion.MVVM;
using trainer_companion.Repositories.Students;

namespace trainer_companion.ViewModels.Students
{
    internal class AllStudentsViewModel : ObservableObjectBase
    {
        private StudentRepository _studentRepository = new StudentRepository();
        public ObservableCollection<Student> Students { get; } = new();

        public AllStudentsViewModel()
        {

        }

        public async Task InitializeAsync()
        {
            Students.Clear();

            var students = await _studentRepository.GetAllStudentsAsync();

            foreach (Student s in students)
            {
                Students.Add(s);
            }
        }
    }
}
