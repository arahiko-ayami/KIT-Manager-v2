using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class Contact
    {
        [Column("Email")]
        public string Email { get; set; }
        
        [Column("PhoneNumber")][Display(Name = "SĐT")]
        public string PhoneNumber { get; set; }
    }
}