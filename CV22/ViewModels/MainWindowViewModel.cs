using CV22.Infrastructure.Commands;
using CV22.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV22.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        #region WindowTitle

        private string _Title = "Мой заголовок";

        /// <summary>Title of Window</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);

        }

        /// <summary>
        /// Programm status
        /// </summary>
        public string Status { get => _Status; set => Set(ref _Status, value); }
        #endregion

        private string _Status = "Готов!";

        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new CommonCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        }

    }
}
