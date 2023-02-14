using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum eStatusDTO { female, male }
    public enum eHMODTO { meuchedet, makabi, leumit, klalit }
    public class PersonDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime BirthDate { get; set; }
        public eStatusDTO statusDTO { get; set; }
        public eHMODTO HMODTO { get; set; }
    }
}
