using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public interface IStudentsRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        Student CreateStudent(Student student);
        IEnumerable<Subject> GetSubjectsForStudent(int studentId);
    }
}
