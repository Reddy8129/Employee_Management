using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementDAL;

namespace EmployeeManagementBLL
{
    public class BLL
    {
        private string _firstname;
        private string _lastname;
        private string _gender;
        private string _address;
        private string _phno;
        private string _zipcode;
        private string _email;
        private string _dob;
        private string _designation;
        private string _department;
        private string _location;
        private string _manager;
        private string _doj;
        private string _previousEmployment;
        private DataTable _dataTable;
        private int _empId;
        private int _eduId;
        DAL dAL = new DAL();
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phno { get => _phno; set => _phno = value; }
        public string Zipcode { get => _zipcode; set => _zipcode = value; }
        public string Email { get => _email; set => _email = value; }
        public string Dob { get => _dob; set => _dob = value; }
        public string Designation { get => _designation; set => _designation = value; }
        public string Department { get => _department; set => _department = value; }
        public string Location { get => _location; set => _location = value; }
        public string Manager { get => _manager; set => _manager = value; }
        public string Doj { get => _doj; set => _doj = value; }
        public string PreviousEmployment { get => _previousEmployment; set => _previousEmployment = value; }
        public DataTable DataTable { get => _dataTable; set => _dataTable = value; }
        public int EmpId { get => _empId; set => _empId = value; }
        public int EduId { get => _eduId; set => _eduId = value; }

        public bool SaveEmpDetails()
        {
            return dAL.AddEmpDetailsToDB(_firstname, _lastname, _gender, _address, _phno, _zipcode, _email, _dob, _designation, _department, _location,_manager,_doj, _previousEmployment)&& dAL.AddEmpEducationDetailsToDB(_dataTable);
        }
        public bool UpdateEmpDetails(int Id)
        {
            return dAL.UpdateEmpDetailsToDB(Id, _firstname, _lastname, _gender, _address, _phno, _zipcode, _email, _dob, _designation, _department, _location, _manager, _doj, _previousEmployment)&& dAL.UpdateEmpEducationDetailsToDB(_dataTable);
        }
        public DataTable GetEmpDetails()
        {
            return dAL.DisplayEmpDetails();
        }
        public DataTable GetEmpEducationDetails()
        {
            return dAL.DisplayEmpEducationDetails(_empId);
        }
    }
}
