using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication2.MVVM.ViewModel
{
    public class EmployeeViewModel
    {
        private List<DXApplication2.MVVM.Model.EmployeeModel> empl_list=new List<Model.EmployeeModel>();
        public EmployeeViewModel()
        {
            empl_list.Add(new Model.EmployeeModel(1, "kumari", "female", "dev", "banglore"));
            empl_list.Add(new Model.EmployeeModel(2, "Prakash", "male", "dev", "Mumbai"));
            empl_list.Add(new Model.EmployeeModel(3, "john", "male", "dev", "Hyderabad"));
            empl_list.Add(new Model.EmployeeModel(4, "siri", "female", "dev", "Chennai"));
            empl_list.Add(new Model.EmployeeModel(5, "Indhu", "female", "dev", "banglore"));

        }
        public List<DXApplication2.MVVM.Model.EmployeeModel> Emp_list
        {
            get { return empl_list; }
            set { empl_list = value; }
        }
    }
}
