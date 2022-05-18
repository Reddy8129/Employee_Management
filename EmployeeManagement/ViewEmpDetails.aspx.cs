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
    public partial class ViewEmpDetails : System.Web.UI.Page
    {
        BLL bLL = new BLL();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = bLL.GetEmpDetails();
            ViewState["EmpDetails"] = dt;
            gvEmpDetails.DataSource = dt;
            gvEmpDetails.DataBind();
        }

        protected void gvEmpDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Url;
            int Index= Convert.ToInt32(gvEmpDetails.SelectedIndex);
            dt = (DataTable)ViewState["EmpDetails"];
            DataRow dr = dt.Rows[Index];


           // EmpID First Name Last Name Gender  Address Phone No Zipcode EmailAddress Date of Birth   Designation Department  Location ReportingManager    Date of Joining Previous Employment

            Session["IsUpdate"] = "true";
            Url = "EmpDetails.aspx?Id=" + dr["EmpID"].ToString() +
                "&Firstname=" + dr["First Name"].ToString() +
                "&Lastname=" + dr["Last Name"].ToString() +
                "&Gender=" + dr["Gender"].ToString() +
                "&Address=" + dr["Address"].ToString() +
                "&Phno=" + dr["Phone No"].ToString() +
                "&Zipcode=" + dr["Zipcode"].ToString() +
                "&Email=" + dr["EmailAddress"].ToString() +
                "&Dob=" + dr["Date of Birth"].ToString() +
                "&Designation=" + dr["Designation"].ToString() +
                "&Department=" + dr["Department"].ToString() +
                "&Location=" + dr["Location"].ToString() +
                "&Manager=" + dr["ReportingManager"].ToString() +
                "&Doj=" + dr["Date of Joining"].ToString() +
                "&PrevEmp=" + dr["Previous Employment"].ToString();
            Response.Redirect(Url);

        }
    }
}