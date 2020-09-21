using MVVM2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM2.ViewModel
{
    class EmployeeViewModel
    {
        public static ObservableCollection<employee> Employees = new ObservableCollection<employee>(dbContext.GetEmployees());
        public static ObservableCollection<Job> Jobs = new ObservableCollection<Job>(dbContext.GetJobs());

    }
}
