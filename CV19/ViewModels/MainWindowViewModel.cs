using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;


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
        #region Команды

        public ICommand CloseApplicatonCommand { get; }
        private bool CanCloseApplicationExecat(object p) => true;
        private void OnCloseApplicationExecate(object p)
        {
            Application.Current.Shutdown();
        }

            #endregion
        public MainWindowViewModel()
        {
            CloseApplicatonCommand = new LambdaCommand(OnCloseApplicationExecate,CanCloseApplicationExecat);
        }
    }
}
