using EmployeeManagementBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class LeaveType_Master : System.Web.UI.Page
    {
        EmpLeaveBLL bLL = new EmpLeaveBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string LeaveType = txtLeaveType.Text;
            int NoOfLeaves = Int32.Parse(txtNoOfLeaves.Text);
            bLL.LeaveType = LeaveType;
            bLL.NoOfLeaves = NoOfLeaves;
            bool Status = false;
            if (btnSubmit.Text == "Update")
            {

            }
            else
            {
                Status = bLL.SaveLeaveType();
                if (Status)
                {
                    txtLeaveType.Text = "";
                    txtNoOfLeaves.Text = "";
                    Response.Write("<script>alert('Details Saved to DataBase')</script>");
                }
                else
                    Response.Write("<script>alert('Details not saved')</script>");

            }

        }
    }
}