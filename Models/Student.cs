using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DataAccess;

namespace Models
{
    public partial class Student : Person
    {
        [Key][Display(Name = ("Mã SV"))]
        public string Id { get; set; }
        
        [Required][Display(Name = "Lớp")]
        public string Class { get; set; }
        
        public ICollection<Group> Groups { get; set; }

        public Student()
        {
            this.Groups = new HashSet<Group>();
        }
    }
}