using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore.Models
{
    // Student Model
    public class Student
    {
        public int Id { get; set; }


        [MinLength(3)]
        [MaxLength(20)]
        [Column("StdName")]
        [Required]
        public string ? Name { get; set; }


        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public override string ToString()
        {
            string deptName = Department?.Name ?? "No Department";
            return $"Id: {Id}, Name: {Name}, Department: {deptName}";
        }
    }
}
