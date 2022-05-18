using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDAL
{
    public class EmpLeaveDAL
    {
        SqlConnection conn = null;
        string SqlConString = "Data Source=DESKTOP-9PIA4N4;Initial Catalog='Employee Management';Persist Security Info=True;User ID=sa;Password=prashanth@98";

        public bool AddLeaveType(string LeaveType, int NoOfLeaves)
        {
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("ProcLeaveTypeMaster", conn);
                    cmd.CommandType=CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    cmd.Parameters.AddWithValue("@Id", 0);
                    cmd.Parameters.AddWithValue("@LeaveType", LeaveType);
                    cmd.Parameters.AddWithValue("@NoOfLeaves", NoOfLeaves);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
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
        public bool AddHolidays(DataTable dt)
        {
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("HolidayList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        cmd.Parameters.AddWithValue("@Date", row["Date"].ToString());
                        cmd.Parameters.AddWithValue("@Holiday", row["Holiday Name"].ToString());
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
                return true;
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
        public DataTable DisplayLeaveType()
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("DisplayLeaveType", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt); 
                    return dt;
                }

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
        public DataTable DisplayHolidays()
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("DisplayHolidays", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
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
        public float DisplayNoOfLeavesLeft(int EmpId, string LeaveType)
        {
            float count;
            try
            {
                using (conn = new SqlConnection(SqlConString))
                {
                    SqlCommand cmd = new SqlCommand("DisplayNoOfLeavesLeft", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpId", EmpId);
                    cmd.Parameters.AddWithValue("@LeaveType", LeaveType);
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                    return count;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception from DAL " + e);
                return -1;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
