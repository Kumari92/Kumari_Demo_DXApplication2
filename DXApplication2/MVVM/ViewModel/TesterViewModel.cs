using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication2.MVVM.ViewModel
{
    public class TesterViewModel
    {
        private List<DXApplication2.MVVM.Model.EmployeeModel> tester_list = new List<Model.EmployeeModel>();
        public TesterViewModel()
        {
            tester_list.Add(new Model.EmployeeModel(1000, "Sruthi", "female", "Tester", "banglore"));
            tester_list.Add(new Model.EmployeeModel(2000, "Keerthi", "female", "Tester", "Hyderabad"));


        }
        public List<DXApplication2.MVVM.Model.EmployeeModel> Tester_list
        {
            get { return tester_list; }
            set { tester_list = value; }
        }
    }
}
