using CV22.Infrastructure.Commands;
using CV22.Models;
using CV22.ViewModels.Base;
using System;
using System.Collections;
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

        #region TestDataPoints

        private IEnumerable<DataPoint> _TestDataPoints;

        public IEnumerable<DataPoint> TestDataPoints { get => _TestDataPoints; set => Set(ref _TestDataPoints, value); }

        #endregion

        private int _SelectedPageIndex;

        /// <summary>
        /// Number of selected tab
        /// </summary>
        public int SelectedPageIndex { get => _SelectedPageIndex; set => Set(ref _SelectedPageIndex, value); }

        public ICommand ChangeTabIndexCommand { get; }

        private bool CanChangeTabIndexCommandExecute(object p) => _SelectedPageIndex >= 0;

        private void OnChangeTabIndexCommandExecute(object p)
        {
            if(p is null) return;
            SelectedPageIndex += Convert.ToInt32(p);
        }

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
            ChangeTabIndexCommand = new CommonCommand(OnChangeTabIndexCommandExecute, CanChangeTabIndexCommandExecute);

            var data_points = new List<DataPoint>((int) (360 / 0.1));
            
            for (var x = 0d; x <= 360; x += 0.1)
            {
                const double to_rad = Math.PI / 180;
                var y = Math.Sin(x * to_rad);

                data_points.Add(new DataPoint { XValue= x, YValue = y});
            }

            TestDataPoints= data_points;
        }

    }
}
