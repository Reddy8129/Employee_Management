using EmployeeManagementBLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class AddLeaves_Master : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        EmpLeaveBLL bLL = new EmpLeaveBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Details"] == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Date", typeof(string));
                    dt.Columns.Add("Holiday Name", typeof(string));
                    ViewState["Details"] = dt;


                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            dt = (DataTable)ViewState["Details"];
            bLL.DtHolidayList = dt;
            bool Status = false;
            Status=bLL.SaveHolidays();
            if (Status)
            {
                Response.Write("<script>alert('Details Saved to DataBase')</script>");
                dt.Clear();
                gvEduDetails.DataSource = dt;
                gvEduDetails.DataBind();
            }
            else
                Response.Write("<script>alert('Details not saved')</script>");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string Date = txtDate.Text;
            string HolidayName = txtName.Text;
            dt = (DataTable)ViewState["Details"];
            DataRow dataRow = dt.NewRow();
            dataRow["Date"] = Date;
            dataRow["Holiday Name"] = HolidayName;
            dt.Rows.Add(dataRow);
            ViewState["Details"] = dt;
            gvEduDetails.DataSource = dt;
            gvEduDetails.DataBind();
            txtDate.Text = "";
            txtName.Text = "";
        }
    }
}