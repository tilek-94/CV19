using CV19.Infrastructure.Commands;
using CV19.Models.Decanat;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

        public ObservableCollection<Group> Groups { get; }
        private Group _SelectedGroup;
        public Group SelectedGroup
        {
            get=> _SelectedGroup;
            set => Set(ref _SelectedGroup,value);
        }
        public MainWindowViewModel()
        {
            CloseApplicatonCommand = new LambdaCommand(OnCloseApplicationExecate,CanCloseApplicationExecat);
           
            var student_index = 1;
            var students = Enumerable.Range(1, 10).Select(i=> new Student(){ 
            Name=$"Name {student_index}",
            Surname=$"Surname {student_index}",
            Patronymic=$"Ptronimic {student_index++}",
            Brithday=DateTime.Now,
             Rating=0
              }
                );
            var groups = Enumerable.Range(1, 20).Select(i => new Group()
            {
                Name = $"Группа{i}",
                Students = new ObservableCollection<Student>(students)
            }); 
            Groups = new ObservableCollection<Group>(groups);
        }
    }
}
