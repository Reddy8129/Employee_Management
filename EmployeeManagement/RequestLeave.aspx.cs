using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagementBLL;

namespace EmployeeManagement
{
    public partial class RequestLeave : System.Web.UI.Page
    {
        EmpLeaveBLL BLL = new EmpLeaveBLL();
        DateTime StartDate;
        DateTime EndDate;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLL.GetLeaveTypes();
            ddLeavetype.DataSource = dt;
            ddLeavetype.DataBind();
            ddLeavetype.DataTextField = "LeaveType";
            ddLeavetype.DataValueField = "NoOfLeaves";
            ddLeavetype.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string Current_Date = DateTime.Now.ToString();
            
            int EmpId;
            if (!int.TryParse(txtEmpId.Text, out EmpId))
                EmpId = 0;
            string LeaveType = ddLeavetype.Text;
            StartDate = DateTime.ParseExact(txtFromDate.Text, "yyyy-MM-dd", null);
            EndDate = DateTime.ParseExact(txtToDate.Text, "yyyy-MM-dd", null);
            String[] WeekDays = ExtractWeekends(StartDate, EndDate);
            float No_of_leaves_requested = WeekDays.Length;
            float No_of_leaves_taken = BLL.GetNoOfLeavesLeft(EmpId, LeaveType);
            int Tot_no_of_leaves = Int32.Parse(ddLeavetype.SelectedValue.ToString());
            if (No_of_leaves_requested + No_of_leaves_taken <= Tot_no_of_leaves)
            {

            }

        }
        private String[] ExtractWeekends(DateTime StartDate, DateTime EndDate)
        {
            DataTable dt = new DataTable();
            TimeSpan diff = EndDate - StartDate;
            int days = diff.Days;
            String[] Weekdays = { };
            //Get HolidayList from database
            dt = BLL.GetHolidays();
            string[] HolidayList = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
                HolidayList[i] = dt.Rows[i][0].ToString();
            //Extract Weekends
            for (var i = 0; i<=days; i++)
            {
                var testDate = StartDate.AddDays(i);
                switch (testDate.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        break;
                    default:
                        Weekdays = Weekdays.Concat(new[] { testDate.ToString("yyyy-MM-dd") }).ToArray();
                        break;
                }
            }
            //Extract Holidays          
            foreach (string date in Weekdays)
            {
                if(HolidayList.Contains(date))
                    Weekdays= Weekdays.Where(val => val != date).ToArray();
            }
            return Weekdays;
        }
    }
}