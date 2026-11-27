using System.Windows.Controls;
using trainer_companion.MVVM;
using trainer_companion.Views.Students;

namespace trainer_companion.Navigation
{
    class Navigator : ObservableObjectBase
    {
        private readonly Stack<ObservableObjectBase> _history = new();
        private ObservableObjectBase? _current;

        public ObservableObjectBase? Current
        {
            get => _current;
            private set { _current = value; OnPropertyChanged(); }
        }

        public void GoTo(ObservableObjectBase next)
        {
            if (Current is not null) _history.Push(Current);
            Current = next;
        }

        public void Back()
        {
            if (_history.Count > 0) Current = _history.Pop();
        }
    }
}
