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
    public partial class EmpDetails : System.Web.UI.Page
    {
        DataTable dt = null;
        BLL bLL = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Details"] == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("School", typeof(string));
                    dt.Columns.Add("University", typeof(string));
                    dt.Columns.Add("Degree", typeof(string));
                    dt.Columns.Add("Course", typeof(string));
                    dt.Columns.Add("Percentage/CGPA", typeof(string));
                    dt.Columns.Add("StartDate", typeof(string));
                    dt.Columns.Add("EndDate", typeof(string));
                    ViewState["Details"] = dt;

                    
                }
            }
            //When redirected from ViewEmpDetails
            if (Session["IsUpdate"] == "true")
            {
                Session.Remove("IsUpdate");
                ViewState["EmpId"]= int.Parse(Request.QueryString["Id"]);

                txtFirstName.Text = Request.QueryString["Firstname"];
                txtLastName.Text = Request.QueryString["Lastname"];
                radioGender.SelectedValue = Request.QueryString["Gender"];
                txtAddress.Text = Request.QueryString["Address"];
                txtPhone.Text = Request.QueryString["Phno"];
                txtCode.Text = Request.QueryString["Zipcode"];
                txtEmail.Text = Request.QueryString["Email"];
                txtDob.Text = Request.QueryString["Dob"];
                txtDesignation.SelectedValue = Request.QueryString["Designation"];
                txtDepartment.SelectedValue = Request.QueryString["Department"];
                txtLocation.Text = Request.QueryString["Location"];
                txtManager.Text = Request.QueryString["Manager"];
                txtDOJ.Text = Request.QueryString["Doj"];
                txtPreviousEmployment.Text = Request.QueryString["PrevEmp"];
                GetEmpEducationDetailsByEmpId();
                btnSubmit.Text = "Update";
            }
        }
        private void BindDataToGrid()
        {
            ViewState["Details"] = dt;
            gvEduDetails.DataSource = dt;
            gvEduDetails.DataBind();
            gvConfirmDet.DataSource = dt;
            gvConfirmDet.DataBind();
        }

        protected void gvEduDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=Convert.ToInt32(gvEduDetails.SelectedIndex);
            dt = (DataTable)ViewState["Details"];
            DataRow dr=dt.Rows[index];
            txtSchool.Text = dr["School"].ToString();
            txtUniversity.Text= dr["University"].ToString();
            txtDegree.Text= dr["Degree"].ToString();
            txtCourse.Text = dr["Course"].ToString();
            txtPercentageCgpa.Text = dr["Percentage/CGPA"].ToString();
            txtStartDate.Text = dr["StartDate"].ToString();
            txtEndingDate.Text = dr["EndDate"].ToString();
            
            btnAddEduDet.Text = "Update";   //Change Add button to Update
            this.gvEduDetails.Columns[0].Visible = false;   //Disable edit and delete buttons when updating
            this.gvEduDetails.Columns[1].Visible = false;
            ViewState["Index"] = Convert.ToInt32(gvEduDetails.SelectedRow.RowIndex);    //Save row index for deleting row after update



        }

        protected void gvEduDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = Convert.ToInt32(e.RowIndex);
            dt = ViewState["Details"] as DataTable;
            dt.Rows[i].Delete();
            BindDataToGrid();
        }

        protected void gvEduDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEduDetails.PageIndex = e.NewPageIndex;
            gvEduDetails.DataBind();
        }

        protected void btnAddEduDet_Click(object sender, EventArgs e)
        {
            
            string School = txtSchool.Text;
            string University = txtUniversity.Text;
            string Degree = txtDegree.Text;
            string Course = txtCourse.Text;
            string PercentageOrCGPA = txtPercentageCgpa.Text;
            string StartDate = txtStartDate.Text;
            string EndingDate = txtEndingDate.Text;
            dt = (DataTable)ViewState["Details"];

            if (btnAddEduDet.Text == "Update")
            {
                int i = 0;
                if (ViewState["Index"] != null)
                    i = Convert.ToInt32(ViewState["Index"]);
                dt.Rows[i].Delete();
                dt.AcceptChanges();
                btnAddEduDet.Text = "ADD";
                this.gvEduDetails.Columns[0].Visible = true;
                this.gvEduDetails.Columns[1].Visible = true;
            }
            DataRow NewRow = dt.NewRow();
            NewRow["School"] = School;
            NewRow["University"] = University;
            NewRow["Degree"] = Degree;
            NewRow["Course"] = Course;
            NewRow["Percentage/CGPA"] = PercentageOrCGPA;
            NewRow["StartDate"] = StartDate;
            NewRow["EndDate"] = EndingDate;
            dt.Rows.Add(NewRow);
            //dt.Rows.Add(School, University, Degree, Course, PercentageOrCGPA, StartDate, EndingDate);
            BindDataToGrid();
            clearEduDetails();
        }
        private void clearEduDetails()
        {
            txtSchool.Text = "";
            txtUniversity.Text = "";
            txtDegree.Text = "";
            txtCourse.Text = "";
            txtPercentageCgpa.Text = "";
            txtStartDate.Text = "";
            txtEndingDate.Text = "";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Gender = radioGender.SelectedValue;
            string Address = txtAddress.Text;
            string Phno = txtPhone.Text;
            string Zipcode = txtCode.Text;
            string Email = txtEmail.Text;
            string Dob = txtDob.Text;
            string Designation = txtDesignation.SelectedValue;
            string Department = txtDepartment.SelectedValue;
            string Location = txtLocation.Text;
            string Manager = txtManager.Text;
            string Doj = txtDOJ.Text;
            string PreviousEmployment = txtPreviousEmployment.Text;

            bLL.Firstname = FirstName;
            bLL.Lastname = LastName;
            bLL.Gender = Gender;
            bLL.Address = Address;
            bLL.Phno = Phno;
            bLL.Zipcode = Zipcode;
            bLL.Email = Email;
            bLL.Dob = Dob;
            bLL.Designation = Designation;
            bLL.Department = Department;
            bLL.Location = Location;
            bLL.Manager = Manager;
            bLL.Doj = Doj;
            bLL.PreviousEmployment = PreviousEmployment;
            dt = (DataTable)ViewState["Details"];
            bLL.DataTable = dt;
            bool Success = false;
            if (btnSubmit.Text == "Update")
            {
                int empid=(int)ViewState["EmpId"];
                Success = bLL.UpdateEmpDetails(empid);
                if (Success)
                {
                    Response.Write("<script>alert('Employee details having Employee Id "+ViewState["EmpId"].ToString() +" is Updated to DataBase')</script>");
                    dt.Clear();
                    BindDataToGrid();
                    ClearWnSubmit();
                    Response.Redirect("/ViewEmpDetails.aspx");
                }
                else
                    Response.Write("<script>alert('Employee details not updated')</script>");

            }
            else
            {
                Success= bLL.SaveEmpDetails();
                if (Success)
                {
                    Response.Write("<script>alert('Emloyee details Saved to DataBase')</script>");
                    dt.Clear();
                    BindDataToGrid();
                    ClearWnSubmit();
                }
                else
                    Response.Write("<script>alert('Employee details not saved')</script>");
            }
            
        }
        private void ClearWnSubmit()
        {
            txtFirstName.Text="";
            txtLastName.Text="";
            radioGender.SelectedValue="";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtCode.Text = "";
            txtEmail.Text = "";
            txtDob.Text = "";
            txtDesignation.SelectedValue = "";
            txtDepartment.SelectedValue = "";
            txtLocation.Text = "";
            txtManager.Text = "";
            txtDOJ.Text = "";
            txtPreviousEmployment.Text = "";
        }
        private void GetEmpEducationDetailsByEmpId()
        {
            int Id = (int)ViewState["EmpId"];
            bLL.EmpId = Id;
            ViewState["Details"] = bLL.GetEmpEducationDetails();
            dt = (DataTable)ViewState["Details"];
            dt.Columns[2].ColumnName = "School";
            dt.Columns[3].ColumnName = "University";
            dt.Columns[4].ColumnName = "Degree";
            dt.Columns[5].ColumnName = "Course";
            dt.Columns[6].ColumnName = "Percentage/CGPA";
            dt.Columns[7].ColumnName = "StartDate";
            dt.Columns[8].ColumnName = "EndDate";
            ViewState["Details"] = dt;
            BindDataToGrid();
        }
    }
}