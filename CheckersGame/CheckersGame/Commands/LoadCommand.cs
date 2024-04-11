using CheckersGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CheckersGame.Commands
{
    internal class LoadCommand : ICommand
    {
        private MeniuViewModel MeniuVM {  get; set; }
        public LoadCommand(/*MeniuViewModel meniuVM*/) 
        {
            //MeniuVM = meniuVM;
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Load() { }

        public void Execute(object parameter)
        {
            Load();
        }
        public event EventHandler CanExecuteChanged;
    }
}
