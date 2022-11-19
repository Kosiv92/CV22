﻿using CV22.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion
    }
}