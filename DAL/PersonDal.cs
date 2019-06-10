using ScheduleManager.Model;
using System.Data;
using System.Data.SqlClient;

namespace ScheduleManager.DAL
{
    /// <summary>
    /// This class provides access to the database 
    /// It is conserned with Person 
    /// </summary>
    public class PersonDAL
    {
        public void AddPerson(Person addPerson)
        {
            SqlConnection connection = ScheduleManager_DB_Connection.GetConnection();
            try
            {
                SqlCommand command = new SqlCommand("spAddEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@last_name", addPerson.LastName));
                command.Parameters.Add(new SqlParameter("@first_name", addPerson.LastName));
                command.Parameters.Add(new SqlParameter("@date_of_birth", addPerson.LastName));
                command.Parameters.Add(new SqlParameter("@ssn", addPerson.LastName));
                command.Parameters.Add(new SqlParameter("@gender", addPerson.LastName));
                command.Parameters.Add(new SqlParameter("@street_address", addPerson.LastName));
                command.Parameters.Add(new SqlParameter("@phone", addPerson.LastName));
                command.Parameters.Add(new SqlParameter("@zipcode", addPerson.LastName));
                command.Parameters.Add(new SqlParameter("@username", addPerson.LastName));

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                connection.Close();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }            
            }
        }
    }
}
