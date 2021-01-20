using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Models;

namespace DataAccess
{
    public partial class Group
    {
        [Required][Display(Name = "Mã Nhóm")]
        public int Id { get; set; }
        
        [Required][Display(Name = "Tên Nhóm")]
        public string Name { get; set; }
        
        [Display(Name = "Mô Tả Nhóm")]
        public string Description { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Group()
        {
            this.Students = new HashSet<Student>();
        }
    }
}