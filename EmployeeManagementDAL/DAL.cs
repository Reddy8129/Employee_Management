using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDAL
{
    public class DAL
    {
        static int EmpId;
        SqlConnection conn = null;
        string SqlConString = "Data Source=DESKTOP-9PIA4N4;Initial Catalog='Employee Management';Persist Security Info=True;User ID=sa;Password=prashanth@98";
        public bool AddEmpDetailsToDB(
            string Firstname,
            string LastName,
            string Gender,
            string Address,
            string Phno,
            string Zipcode,
            string Email,
            string Dob,
            string Designation,
            string Department,
            string location,
            string Manager,
            string Doj,
            string PreviousEmployment
            )
        {
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("EmployeeDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    cmd.Parameters.AddWithValue("@first_name",Firstname);
                    cmd.Parameters.AddWithValue("@last_name",LastName);
                    cmd.Parameters.AddWithValue("@gender",Gender);
                    cmd.Parameters.AddWithValue("@address", Address);
                    cmd.Parameters.AddWithValue("@phno",Phno);
                    cmd.Parameters.AddWithValue("@zipcode",Zipcode);
                    cmd.Parameters.AddWithValue("@email_address",Email);
                    cmd.Parameters.AddWithValue("@dob",Dob);
                    cmd.Parameters.AddWithValue("@designation",Designation);
                    cmd.Parameters.AddWithValue("@department",Department);
                    cmd.Parameters.AddWithValue("@location",location);
                    cmd.Parameters.AddWithValue("@reporting_manager",Manager);
                    cmd.Parameters.AddWithValue("@doj",Doj);
                    cmd.Parameters.AddWithValue("@previous_employment",PreviousEmployment);
                    conn.Open();
                    DbParameter preturn = cmd.CreateParameter();
                    preturn.ParameterName = "@Return_Value";
                    preturn.DbType = DbType.Int32;
                    preturn.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(preturn);
                    cmd.ExecuteNonQuery();
                    EmpId = (int)cmd.Parameters["@Return_Value"].Value;
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception from DAL " + e);
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public bool UpdateEmpDetailsToDB(
            int EmpId,
            string Firstname,
            string LastName,
            string Gender,
            string Address,
            string Phno,
            string Zipcode,
            string Email,
            string Dob,
            string Designation,
            string Department,
            string location,
            string Manager,
            string Doj,
            string PreviousEmployment
            )
        {
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("EmployeeDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Update");
                    cmd.Parameters.AddWithValue("@empid", EmpId);
                    cmd.Parameters.AddWithValue("@first_name", Firstname);
                    cmd.Parameters.AddWithValue("@last_name", LastName);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@address", Address);
                    cmd.Parameters.AddWithValue("@phno", Phno);
                    cmd.Parameters.AddWithValue("@zipcode", Zipcode);
                    cmd.Parameters.AddWithValue("@email_address", Email);
                    cmd.Parameters.AddWithValue("@dob", Dob);
                    cmd.Parameters.AddWithValue("@designation", Designation);
                    cmd.Parameters.AddWithValue("@department", Department);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@reporting_manager", Manager);
                    cmd.Parameters.AddWithValue("@doj", Doj);
                    cmd.Parameters.AddWithValue("@previous_employment", PreviousEmployment);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception from DAL " + e);
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public bool AddEmpEducationDetailsToDB(DataTable dt)
        {
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("EmployeeEducationDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    foreach(DataRow row in dt.Rows)
                    {
                        cmd.Parameters.AddWithValue("@Action", "Insert");
                        cmd.Parameters.AddWithValue("@empid", EmpId);
                        cmd.Parameters.AddWithValue("@school", row["School"].ToString());
                        cmd.Parameters.AddWithValue("@university", row["University"].ToString());
                        cmd.Parameters.AddWithValue("@degree", row["Degree"].ToString());
                        cmd.Parameters.AddWithValue("@course", row["Course"].ToString());
                        cmd.Parameters.AddWithValue("@percentage", row["Percentage/CGPA"].ToString());
                        cmd.Parameters.AddWithValue("@starting_date", row["StartDate"].ToString());
                        cmd.Parameters.AddWithValue("@ending_date", row["EndDate"].ToString());
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception from DAL " + e);
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public bool UpdateEmpEducationDetailsToDB(DataTable dt)
        {
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    int id;
                    int empid;
                    SqlCommand cmd = new SqlCommand("EmployeeEducationDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        id = row.Field<int>("Id");
                        empid = row.Field<int>("EmpId");
                        cmd.Parameters.AddWithValue("@Action", "Update");
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@empid", empid);
                        cmd.Parameters.AddWithValue("@school", row["School"].ToString());
                        cmd.Parameters.AddWithValue("@university", row["University"].ToString());
                        cmd.Parameters.AddWithValue("@degree", row["Degree"].ToString());
                        cmd.Parameters.AddWithValue("@course", row["Course"].ToString());
                        cmd.Parameters.AddWithValue("@percentage", row["Percentage/CGPA"].ToString());
                        cmd.Parameters.AddWithValue("@starting_date", row["StartDate"].ToString());
                        cmd.Parameters.AddWithValue("@ending_date", row["EndDate"].ToString());
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception from DAL " + e);
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public DataTable DisplayEmpDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("EmployeeDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Select");
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception from DAL " + e);
                return null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public DataTable DisplayEmpEducationDetails(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("EmployeeEducationDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Select");
                    cmd.Parameters.AddWithValue("@empid", Id);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception from DAL " + e);
                return null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

    }
}
