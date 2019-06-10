using ScheduleManager.Model;
using ScheduleManager.DAL;

namespace ScheduleManager.Controller
{
    /// <summary>
    /// This class insures proper access to the DAL \
    /// and controls all manipulation of the person object(s)
    /// </summary>
    public class PersonController
    {
        PersonDAL personDAL = new PersonDAL();
        public void AddPerson(Person addedPerson)
        {
            this.personDAL.AddPerson(addedPerson);
        }
    }
}
