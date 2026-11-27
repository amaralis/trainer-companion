using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace trainer_companion.MVVM
{
    /// <summary>
    /// Provides notification support for changes to property values.
    /// </summary>
    /// <remarks>Inherit from this class to enable property change notifications. Call OnPropertyChanged to notify subscribers of property changes.</remarks>
    class ObservableObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
