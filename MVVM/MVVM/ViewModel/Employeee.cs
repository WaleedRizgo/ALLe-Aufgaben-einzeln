using MVVM.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM
{
    public class employee : INotifyPropertyChanged
    {
        public int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; OnPropertyChanged("ID"); }
        }

        public string _Titel;
        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; OnPropertyChanged("Titel"); }
        }

        public string _Name;      

        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged("Name"); }
        }


        public ICommand ClickCommand = new RelayCommand(ClickExecute, CanClickExecute);

        public static bool CanClickExecute(object obj)
        {
            throw new NotImplementedException();
        }

        public static void ClickExecute(object obj)
        {
            throw new NotImplementedException();
        }




        //ثابت Viewmodel
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            // make sure only to call this if the value actually changes

            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
