using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class User
    {
        [ForeignKey("Student")]
        public string Id { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Priority Priority { get; set; }
        public virtual Student Student { get; set; }
    }
}