using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace AssignmentC
{
    class Student
    {
        //Attributes
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public int SelectedID { get; set; }

        //server connection
        static string myconnstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        
        //select
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "Select * from Students";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        //register
        public bool StudentAdd(Student Obj)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool success = false;

            try
            {
                string sql = "INSERT INTO Students(FirstName, LastName, Gender, Age, PhoneNumber) " +
                             "VALUES (@FirstName, @LastName, @Gender, @Age, @PhoneNumber)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = LastName;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 100).Value = Gender;
                cmd.Parameters.Add("@Age", SqlDbType.Int, 100).Value = Age;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int, 100).Value = PhoneNumber;
                conn.Open();
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        //update
        public bool StudentUpdate(Student Obj)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool success = false;

            try
            {
                string sql = "UPDATE Students SET " +
                    "FirstName = '" + FirstName + 
                    "', LastName = '" + LastName + 
                    "', Gender = '" + Gender + 
                    "', Age = '" + Age + 
                    "', PhoneNumber = '" + PhoneNumber + 
                    "' WHERE Id = '" + Id + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = LastName;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 100).Value = Gender;
                cmd.Parameters.Add("@Age", SqlDbType.Int, 100).Value = Age;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int, 100).Value = PhoneNumber;
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        //delete
        public bool StudentDelete(Student Obj)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool success = false;

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE Students WHERE Id = @Id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

    }

}
