using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication2.MVVM.ViewModel
{
    public class HRViewModel
    {
        private List<DXApplication2.MVVM.Model.EmployeeModel> hr_list = new List<Model.EmployeeModel>();
        public HRViewModel()
        {
            hr_list.Add(new Model.EmployeeModel(100, "Lavanya", "female", "HR", "banglore"));
            hr_list.Add(new Model.EmployeeModel(200, "Madhavi", "female", "HR", "Hyderabad"));
            hr_list.Add(new Model.EmployeeModel(300, "Jai", "male", "HR", "Hyderabad"));
            hr_list.Add(new Model.EmployeeModel(400, "Ram", "male", "HR", "Chennai"));
            hr_list.Add(new Model.EmployeeModel(500, "Indhu", "female", "HR", "banglore"));

        }
        public List<DXApplication2.MVVM.Model.EmployeeModel> HR_list
        {
            get { return hr_list; }
            set { hr_list = value; }
        }
    }
}
