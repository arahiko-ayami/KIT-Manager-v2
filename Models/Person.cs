using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class Person
    {
        [Required][Display(Name = ("Họ Tên"))]
        public string Name { get; set; }
        
        [Display(Name = ("Ngày Sinh"))]
        public DateTime DateOfBirth { get; set; }
        
        [Display(Name = ("Giới tính"))]
        public Gender? Gender { get; set; }
        
        public Contact Contact { get; set; }
    }
}