using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM.View
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : UserControl
    {
        employee emp = new employee();
        public Employeee()
        {
            InitializeComponent();
            emp = new employee()
            {
                ID = 10,
                Name = "Waleed",
                Titel = "Herr"
            };
            DataContext = emp;
        }
    }
}
