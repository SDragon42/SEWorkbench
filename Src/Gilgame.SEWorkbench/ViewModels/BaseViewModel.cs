﻿using System;
using System.ComponentModel;

namespace Gilgame.SEWorkbench.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private BaseViewModel _Parent;
        public BaseViewModel Parent
        {
            get
            {
                return _Parent;
            }
            private set
            {
                if (_Parent != value)
                {
                    _Parent = value;
                    OnPropertyChanged("Parent");
                }
            }
        }

        public BaseViewModel(BaseViewModel parent)
        {
            Parent = parent;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
