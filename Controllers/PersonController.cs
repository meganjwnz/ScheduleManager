using ScheduleManager.Model;
using ScheduleManager.DAL;

namespace ScheduleManager.Controllers
{
    /// <summary>
    /// This class insures proper access to the DAL \
    /// and controls all manipulation of the person object(s)
    /// </summary>
    public class PersonController
    {
        PersonDAL personDAL = new PersonDAL();
<<<<<<< Updated upstream
=======
        #region addPerson
        /// <summary>
        /// Adds a person to the database
        /// </summary>
        /// <param name="addedPerson"></param>
>>>>>>> Stashed changes
        public void AddPerson(Person addedPerson)
        {
            this.personDAL.AddPerson(addedPerson);
        }
<<<<<<< Updated upstream
=======
        #endregion

        #region Return specified Persons
        /// <summary>
        /// returns a list of all persons - no where clause specified
        /// </summary>
        /// <returns></returns>
        public List<Person> GetAllPeoples()
        {
            string whereClause = "";
            return this.personDAL.GetDesiredPersons(whereClause);

        }

        /// <summary>
        /// Returns list of persons based upon inputed statusid
        /// </summary>
        /// <param name="statusId"></param>
        /// <returns></returns>
        public List<Person> GetAllPeopleByStatusId(int statusId)
        {
            string whereClause = "WHERE statusId = " + statusId.ToString();
            return this.personDAL.GetDesiredPersons(whereClause);
        }

        /// <summary>
        /// Returns list of persons based upon inputed RoleId
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<Person> GetAllPeopleByRoleId(int roleId)
        {
            string whereClause = "WHERE roleId = " + roleId.ToString();
            return this.personDAL.GetDesiredPersons(whereClause);
        }

        /// <summary>
        /// Returns list of persons based upon inputed id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Person> GetAllPeopleById(int Id)
        {
            string whereClause = "WHERE Id = " + Id.ToString();
            return this.personDAL.GetDesiredPersons(whereClause);
        }

        /// <summary>
        /// Returns list of persons based upon inputed first name
        /// </summary>
        /// <param name="FirstName"></param>
        /// <returns></returns>
        public List<Person> GetAllPeopleByFirstName(string FirstName)
        {
            string whereClause = "WHERE first_name = " + FirstName;
            return this.personDAL.GetDesiredPersons(whereClause);
        }

        /// <summary>
        /// Returns list of persons based upon inputed last name
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public List<Person> GetAllPeopleByLastName(string lastName)
        {
            string whereClause = "WHERE last_name = " + lastName;
            return this.personDAL.GetDesiredPersons(whereClause);
        }

        /// <summary>
        /// Returns list of persons based upon inputed first and last name
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public List<Person> GetAllPeopleByFirstAndLastName(string FirstName, string lastName)
        {
            string whereClause = "WHERE last_name = " + lastName + " And first_name = " + FirstName ;
            return this.personDAL.GetDesiredPersons(whereClause);
        }
        #endregion

        public void DeactivatePersonById(int personId)
        {
            //Call the Dal and set accepted personId to the inactive status 
        }


>>>>>>> Stashed changes
    }
}
