using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.WebAPI.Models
{
    public class ChildModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Tz { get; set; }
        public int ParentId { get; set; }
    }
}
