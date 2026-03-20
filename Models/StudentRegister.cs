using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Models
{
    public class StudentRegister
    {
        private Dictionary<Guid, Student> students = new();

        public void AddStudent(Student student)
        {
            students[student.Id] = student;
        }

        public Student GetStudent(Guid id)
        {
            return students[id];
        }

        public void DropStudent(Guid id)
        {
            if (!students.ContainsKey(id))
            {
                throw new KeyNotFoundException($"tried to drop a nonexistent student with id {id}");
            }

            students.Remove(id);
        }

        public uint StudentCount()
        {
            return (uint)students.Count;
        }
    }
}
