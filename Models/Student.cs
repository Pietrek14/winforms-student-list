using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Models
{
    public enum YearOfStudy
    {
        I,
        II,
        III
    }

    public class Student
    {
        private Guid _id;
        public Guid Id { get { return _id; } }
        public string Name { get; set; }
        public string LastName { get; set; }
        private DateTime _dateOfBirth;
        public DateTime DateOfBirth { get { return _dateOfBirth; } }
        public Address Address { get; set; }
        public YearOfStudy YearOfStudy { get; set; }

        public Student(string name, string lastName, DateTime dateOfBirth, Address address, YearOfStudy yearOfStudy)
        {
            this._id = Guid.NewGuid();
            this.Name = name;
            this.LastName = lastName;
            this._dateOfBirth = dateOfBirth;
            this.Address = address;
            this.YearOfStudy = yearOfStudy;
        }
    }
}
