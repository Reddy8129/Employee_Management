using EmployeeManagementDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementBLL
{
    public class EmpLeaveBLL
    {
        private int _id;
        private string _leaveType;
        private int _noOfLeaves;
        private DataTable _dtHolidayList;

        EmpLeaveDAL dAL = new EmpLeaveDAL();

        public int Id { get => _id; set => _id = value; }
        public string LeaveType { get => _leaveType; set => _leaveType = value; }
        public int NoOfLeaves { get => _noOfLeaves; set => _noOfLeaves = value; }
        public DataTable DtHolidayList { get => _dtHolidayList; set => _dtHolidayList = value; }

        public bool SaveLeaveType()
        {
            return dAL.AddLeaveType(_leaveType, _noOfLeaves);
        }
        public bool SaveHolidays()
        {
            return dAL.AddHolidays(_dtHolidayList);
        }
        public DataTable GetLeaveTypes()
        {
            return dAL.DisplayLeaveType();
        }
        public DataTable GetHolidays()
        {
            return dAL.DisplayHolidays();
        }
        public float GetNoOfLeavesLeft(int EmpId, string Leave_type)
        {
            return dAL.DisplayNoOfLeavesLeft(EmpId, Leave_type);
        }
    }
}
