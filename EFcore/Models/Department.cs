using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore.Models
{
    // Department Model
    public class Department
    {
        public int Id { get; set; }
        [MinLength(2)]
        [MaxLength(25)]
        public string Name { get; set; }

        // one  department has many students  1=>N
        public virtual List<Student> Students { get; set; } = new List<Student>();

        public override string ToString()
        {
            return $"DeptId: {Id}, Department Name: {Name}";
        }
    }
}
