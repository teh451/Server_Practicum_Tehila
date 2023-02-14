using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;

namespace MyProject.WebAPI.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Tz { get; set; }
        public eStatusDTO Status { get; set; }
        public eHMODTO HMO { get; set; }
    }
}
