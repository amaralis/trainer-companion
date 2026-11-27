using System;
using System.Collections.Generic;
using System.Text;
using trainer_companion.MVVM;
using trainer_companion.Navigation;

namespace trainer_companion.ViewModels
{
    class MainViewModel : ObservableObjectBase
    {
        public Navigator Navigator { get; }
        public MainViewModel(Navigator navigator)
        {
            this.Navigator = navigator;
        }

    }
}
