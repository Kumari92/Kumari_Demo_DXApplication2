using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication2.MVVM.Model
{
    public class EmployeeModel
    {
        private int id;
        private string name, gender, department, location;



        public EmployeeModel(int employeeid, string employeename, string employeegender, string employeedepartment, string employeelocation)
        {
            id = employeeid;
            name = employeename;
            department = employeedepartment;
            gender = employeegender;
            location = employeelocation;
        }
        public string Ename
        {
            get { return name; }
            set { name = value; }
        }
        public string Department
        {
            get { return department; }
            set { Department = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }

}
