using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication2.MVVM.ViewModel
{
    public class ManagerViewModel
    {
        private List<DXApplication2.MVVM.Model.EmployeeModel> manager_list = new List<Model.EmployeeModel>();
        public ManagerViewModel()
        {
            manager_list.Add(new Model.EmployeeModel(10, "Chandra", "female", "Manager", "banglore"));
            manager_list.Add(new Model.EmployeeModel(20, "Krishnaveni", "female", "Manager", "Hyderabad"));
            

        }
        public List<DXApplication2.MVVM.Model.EmployeeModel> Manager_list
        {
            get { return manager_list; }
            set { manager_list = value; }
        }
    }
}
