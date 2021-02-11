using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV19.ViewModels
{
  internal  class MainWindowViewModel:ViewModel
    {
        #region Зоголовка окна
        private string _Title="Анализ статистик и CV19";
        public string Title
        {
            get=>_Title; 
            set => Set(ref _Title,value);
        }
        #endregion


    }
}
