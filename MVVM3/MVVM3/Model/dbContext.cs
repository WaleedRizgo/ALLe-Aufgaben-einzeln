using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3.Model
{ 
    public class dbContext
{
    public static IEnumerable<Employee> GetEmployees()

    {
        List<Employee> Employess = new List<Employee>();
        Employess.Add(new Employee { ID = 1, Name = "WALEED", Titel = "MR", Job = GetJobs().FirstOrDefault(job => job.ID == 1) });
        Employess.Add(new Employee { ID = 2, Name = "Han", Titel = "MR", Job = GetJobs().FirstOrDefault(job => job.ID == 2) });
        Employess.Add(new Employee { ID = 3, Name = "DLO", Titel = "MR", Job = GetJobs().FirstOrDefault(job => job.ID == 2) });
        Employess.Add(new Employee { ID = 3, Name = "MHMD", Titel = "MR", Job = GetJobs().FirstOrDefault(job => job.ID == 2) });
        Employess.Add(new Employee { ID = 3, Name = "ALI", Titel = "MR", Job = GetJobs().FirstOrDefault(job => job.ID == 2) });
        Employess.Add(new Employee { ID = 3, Name = "SABAH", Titel = "MR", Job = GetJobs().FirstOrDefault(job => job.ID == 2) });
        Employess.Add(new Employee { ID = 3, Name = "SNO", Titel = "MR", Job = GetJobs().FirstOrDefault(job => job.ID == 2) });
        Employess.Add(new Employee { ID = 3, Name = "RIHO", Titel = "MR", Job = GetJobs().FirstOrDefault(job => job.ID == 2) });
        return Employess;

    }



    public static IEnumerable<Job> GetJobs()
    {
        List<Job> Jobs = new List<Job>();
        Jobs.Add(new Job { ID = 1, Name = "Admin" });
        Jobs.Add(new Job { ID = 2, Name = "Account" });
        return Jobs;

    } 
}
}
