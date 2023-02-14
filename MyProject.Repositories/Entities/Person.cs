using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eStatus { female,male}
    public enum eHMO { meuchedet,makabi,leumit,klalit}
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime BirthDate { get; set; }
        public eStatus status { get; set; }
        public eHMO HMO { get; set; }

    }
}
