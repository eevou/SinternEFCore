using EFcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EFcore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DbContext
            var db = new ApplicationDbContext();
            #endregion



            #region Add Departments
            var d1 = new Department { Name = "Computer Science" };
            var d2 = new Department { Name = "Electronics" };
            var d3 = new Department { Name = "Mechanical" };
            var d4 = new Department { Name = "Civil" };
            var d5 = new Department { Name = "Chemical" };
            db.Departments.AddRange(d1, d2, d3, d4, d5);
            db.SaveChanges();
            #endregion

            #region Add Students
            var s1 = new Student { Name = "John Doe", DepartmentId = d1.Id };
            var s2 = new Student { Name = "Jane Smith", DepartmentId = d1.Id };
            var s3 = new Student { Name = "Alice Johnson", DepartmentId = d2.Id };
            var s4 = new Student { Name = "Bob Wilson", DepartmentId = d2.Id };
            var s5 = new Student { Name = "Charlie Brown", DepartmentId = d3.Id };
            var s6 = new Student { Name = "Diana Prince", DepartmentId = d3.Id };
            var s7 = new Student { Name = "Eva Green", DepartmentId = d4.Id };
            var s8 = new Student { Name = "Frank Miller", DepartmentId = d4.Id };
            var s9 = new Student { Name = "Grace Lee", DepartmentId = d5.Id };
            var s10 = new Student { Name = "Henry Ford", DepartmentId = d5.Id };
            db.Students.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            db.SaveChanges();
            #endregion

            #region Display All Students
            var allStudents = db.Students.ToList();
            foreach (var s in allStudents)
            {
                Console.WriteLine(s);//$"Id: {s.Id}, Name: {s.Name}, DeptId: {s.DepartmentId}"
            }
            #endregion

            Console.WriteLine("===================1================");

            #region Display All Departments
            var allDepartments = db.Departments.ToList();
            foreach (var d in allDepartments)
            {
                Console.WriteLine(d); //  
            }
            #endregion
            Console.WriteLine("===================2================");

            #region Display Students With Department Name [Include]
            var studentsWithDept = db.Students.Include(s => s.Department).ToList();
            foreach (var s in studentsWithDept)
            {
               
                Console.WriteLine(s);
            }
            #endregion
            Console.WriteLine("===================3================");


            #region Display Students With DepartmentId = 1
            var dept1Students = db.Students.Where(s => s.DepartmentId == 1).ToList();
            foreach (var s in dept1Students)
            {
                Console.WriteLine(s);  //
            }
            #endregion
            Console.WriteLine("===================4================");

            #region Display Students With DeptId = 1 OrderBy Name Descending
            var dept1StudentsDesc = db.Students
                .Where(s => s.DepartmentId == 1)
                .OrderByDescending(s => s.Name)
                .ToList();
            foreach (var s in dept1StudentsDesc)
            {
                Console.WriteLine($"Student: {s.Name}");
            }
            #endregion
        }
    }
}
