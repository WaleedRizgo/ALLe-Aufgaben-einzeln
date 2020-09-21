using MVVM3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3.ViewModel
{
    class EmployeeViewModel
    {
       
        
            public static ObservableCollection<Employee> Employees = new ObservableCollection<Employee>(dbContext.GetEmployees());
            public static ObservableCollection<Job> Jobs = new ObservableCollection<Job>(dbContext.GetJobs());

        
    }
}

