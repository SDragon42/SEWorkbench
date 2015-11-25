﻿using System;
using System.Windows.Input;

namespace Gilgame.SEWorkbench.ViewModels.Commands
{
    public class DeleteCommand : ICommand
    {
        private readonly ProjectManagerViewModel _Manager;

        public DeleteCommand(ProjectManagerViewModel project)
        {
            _Manager = project;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }

        public void Execute(object parameter)
        {
            if (_Manager != null)
            {
                _Manager.PerformDelete();
            }
        }
    }
}
